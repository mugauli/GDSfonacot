﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GDSfonacotDatos.Utilities.Util;
using GDSfonacotDatos.DTO;

namespace GDSfonacotDatos.Data
{
    public class SeguimientosData
    {
     

        public MethodResponse<int> GuadarSeguimiento(SeguimientoSupervision_Supervisores seguimiento)
        {
            var response = new MethodResponse<int> { Code = 0 };

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    if (seguimiento.Idseguimiento == 0)
                    {
                        context.SeguimientoSupervision_Supervisores.Add(seguimiento);
                        context.SaveChanges();

                    }
                    else
                    {
                        var empleadoDB = context.SeguimientoSupervision_Supervisores.FirstOrDefault(x => x.Idseguimiento == seguimiento.Idseguimiento);

  

                        context.SaveChanges();


                    }
                }
                return response;
            }
            catch (Exception ex)
            {
                response.Code = -100;
                response.Message = ex.Message;
                return response;
            }


        }

        public MethodResponse<DatosBuscarSeguimiento> ObtenerDatosSeguimientoSupervision(int Idsupervision,int IdSeguimiento)
        {
            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<DatosBuscarSeguimiento> { Code = 0 };

                    var consultarContestacionDB = context.HistorialSupervisiones
                        .Join(context.Sucursales, tabla1 => tabla1.IdSucursal, tabla2 => tabla2.IdSucursal, (HistSup, Suc) => new { HistSup, Suc })
                        .Join(context.SeguimientoSupervision_Supervisores, tabla1 => tabla1.HistSup.IdSupervisiones, tabla2 => tabla2.Idsupervision, (HistSup2, SegSup) => new { HistSup2, SegSup })
                        .Where(q1 => (q1.HistSup2.HistSup.IdSupervisiones == Idsupervision && q1.SegSup.Idseguimiento==IdSeguimiento))
                        .Select(x => new DatosBuscarSeguimiento
                        {
                            //datos de la supervision original
                            Idsupervision = x.SegSup.Idsupervision,
                            DescripcionSucursal = x.HistSup2.Suc.DescripcionSucursal,
                            NoSucursal = x.HistSup2.Suc.NoSucursal,
                            Director_Estatal = x.HistSup2.Suc.Director_Estatal,
                            Director_Regional = x.HistSup2.Suc.Director_Regional,
                            NoSupervision = x.HistSup2.HistSup.NoSupervision,
                            //datos del seguimiento
                            Idseguimiento = x.SegSup.Idseguimiento,
                            Inmueble = x.SegSup.Inmueble,
                            Gestion_direccion = x.SegSup.Gestion_direccion,
                            Originacion = x.SegSup.Originacion,
                            Tarjetas_transfer = x.SegSup.Tarjetas_transfer,
                            Credito = x.SegSup.Credito,
                            Utys = x.SegSup.Utys,
                            Promocionales = x.SegSup.Promocionales,
                            Cobranza = x.SegSup.Cobranza,
                            Fondofijo = x.SegSup.Fondofijo,
                            AcuerdosCompromisos = x.SegSup.AcuerdosCompromisos,
                            


                        }).SingleOrDefault();

                    if (consultarContestacionDB != null) response.Result = consultarContestacionDB;
                    return response;
                    //  response.Result = HistoricoSucursalesDB;
                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<DatosBuscarSeguimiento> { Code = -100, Message = ex.Message };
            }
        }

        public MethodResponse<List<DatosgridSeguimientoSup>> ObtenerSegSupervisonesporSucIndividual(int IdSupervisiones, int IdSeguimiento)
        {
            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<List<DatosgridSeguimientoSup>> { Code = 0 };


                    if (Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 1004 || Globales.objpasardatosusuario.IdNivel == 3)
                    {

                        var HistoricoSucursalesDB = context.HistorialSupervisiones // seleccion de tabla inicial
                       .Join(context.Sucursales, tabla1 => tabla1.IdSucursal, tabla2 => tabla2.IdSucursal, (HistSup, Suc) => new { HistSup, Suc }) // se realiza el join para crear el contexto completo es decir todos los dato 
                       .Join(context.ctEstatusSupervision, tabla1 => tabla1.HistSup.Idstatus, tabla3 => tabla3.idstatus, (histsup2, estat) => new { histsup2, estat })
                       .Join(context.SeguimientoSupervision_Supervisores, tabla1 => tabla1.histsup2.HistSup.IdSupervisiones, tabla2 => tabla2.Idsupervision, (HistSup3, SegSup) => new { HistSup3, SegSup })
                       .Where(sc => sc.HistSup3.histsup2.HistSup.NoSupervision != null && sc.HistSup3.histsup2.Suc.IdSucursal == sc.HistSup3.histsup2.HistSup.IdSucursal && sc.HistSup3.histsup2.HistSup.Idstatus == sc.HistSup3.estat.idstatus && sc.SegSup.Idseguimiento == IdSeguimiento && (sc.HistSup3.histsup2.HistSup.IdSupervisiones == IdSupervisiones || IdSupervisiones == 0)) //ya teniendo los datos, se filtran con el where
                       .Select(x => new DatosgridSeguimientoSup
                       {
                           IdSupervisiones = x.HistSup3.histsup2.HistSup.IdSupervisiones,  // solo eligen los datos a utilizar, y com dijera la peregila :-D liiiisto :-D
                           Idseguimiento = x.SegSup.Idseguimiento,
                           NoSupervision = x.HistSup3.histsup2.HistSup.NoSupervision,
                           FechaSupervision = x.HistSup3.histsup2.HistSup.FechaSupervision,
                           DescripcionSucursal = x.HistSup3.histsup2.Suc.DescripcionSucursal,
                           Estatus = x.HistSup3.estat.statusdescrip

                       }).ToList();
                        response.Result = HistoricoSucursalesDB;
                        return response;



                    }
                    else
                    {
                        var HistoricoSucursalesDB = context.HistorialSupervisiones // seleccion de tabla inicial
                       .Join(context.Sucursales, tabla1 => tabla1.IdSucursal, tabla2 => tabla2.IdSucursal, (HistSup, Suc) => new { HistSup, Suc }) // se realiza el join para crear el contexto completo es decir todos los dato 
                       .Join(context.ctEstatusSupervision, tabla1 => tabla1.HistSup.Idstatus, tabla3 => tabla3.idstatus, (histsup2, estat) => new { histsup2, estat })
                       .Join(context.SeguimientoSupervision_Supervisores, tabla1 => tabla1.histsup2.HistSup.IdSupervisiones, tabla2 => tabla2.Idsupervision, (HistSup3, SegSup) => new { HistSup3, SegSup })
                       .Where(sc => sc.HistSup3.histsup2.HistSup.NoSupervision != null && sc.HistSup3.histsup2.Suc.IdSucursal == sc.HistSup3.histsup2.HistSup.IdSucursal && sc.HistSup3.histsup2.HistSup.IdSucursal == Globales.objpasardatosusuario.IdSucursal && sc.HistSup3.histsup2.HistSup.Idstatus == sc.HistSup3.estat.idstatus && sc.SegSup.Idseguimiento == IdSeguimiento && (sc.HistSup3.histsup2.HistSup.IdSupervisiones == IdSupervisiones || IdSupervisiones == 0)) //ya teniendo los datos, se filtran con el where
                       .Select(x => new DatosgridSeguimientoSup

                       {
                           IdSupervisiones = x.HistSup3.histsup2.HistSup.IdSupervisiones,  // solo eligen los datos a utilizar, y com dijera la peregila :-D liiiisto :-D
                           Idseguimiento = x.SegSup.Idseguimiento,
                           NoSupervision = x.HistSup3.histsup2.HistSup.NoSupervision,
                           FechaSupervision = x.HistSup3.histsup2.HistSup.FechaSupervision,
                           DescripcionSucursal = x.HistSup3.histsup2.Suc.DescripcionSucursal,
                           Estatus = x.HistSup3.estat.statusdescrip

                       }).ToList();
                        response.Result = HistoricoSucursalesDB;
                        return response;
                    }

                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<List<DatosgridSeguimientoSup>> { Code = -100, Message = ex.Message };
            }
        }
        public MethodResponse<List<DatosgridSeguimientoSup>> ObtenerSegSupervisones(int IdSupervisiones, int[] clavestatus)
        {
            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<List<DatosgridSeguimientoSup>> { Code = 0 };


                    if (Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 1004 || Globales.objpasardatosusuario.IdNivel == 3)
                    {

                        var HistoricoSucursalesDB = context.HistorialSupervisiones // seleccion de tabla inicial
                       .Join(context.Sucursales, tabla1 => tabla1.IdSucursal, tabla2 => tabla2.IdSucursal, (HistSup, Suc) => new { HistSup, Suc }) // se realiza el join para crear el contexto completo es decir todos los dato 
                       .Join(context.ctEstatusSupervision, tabla1 => tabla1.HistSup.Idstatus, tabla3 => tabla3.idstatus, (histsup2, estat) => new { histsup2, estat })
                       .Join(context.SeguimientoSupervision_Supervisores, tabla1 => tabla1.histsup2.HistSup.IdSupervisiones, tabla2 => tabla2.Idsupervision, (HistSup3, SegSup) => new { HistSup3, SegSup })
                       .Where(sc => sc.HistSup3.histsup2.HistSup.NoSupervision != null && sc.HistSup3.histsup2.Suc.IdSucursal == sc.HistSup3.histsup2.HistSup.IdSucursal && sc.HistSup3.histsup2.HistSup.Idstatus == sc.HistSup3.estat.idstatus && clavestatus.Contains((int)sc.HistSup3.histsup2.HistSup.Idstatus) && (sc.HistSup3.histsup2.HistSup.IdSupervisiones == IdSupervisiones || IdSupervisiones == 0)) //ya teniendo los datos, se filtran con el where
                       .Select(x => new DatosgridSeguimientoSup
                       {
                           IdSupervisiones = x.HistSup3.histsup2.HistSup.IdSupervisiones,  // solo eligen los datos a utilizar, y com dijera la peregila :-D liiiisto :-D
                           Idseguimiento=x.SegSup.Idseguimiento,
                           FechaSeguimCreacion=x.SegSup.FechaSeguimCreacion,
                           NoSupervision = x.HistSup3.histsup2.HistSup.NoSupervision,
                           FechaSupervision = x.HistSup3.histsup2.HistSup.FechaSupervision,
                           DescripcionSucursal = x.HistSup3.histsup2.Suc.DescripcionSucursal,
                           Estatus = x.HistSup3.estat.statusdescrip

                       }).ToList();
                        response.Result = HistoricoSucursalesDB;
                        return response;



                    }
                    else
                    {
                        var HistoricoSucursalesDB = context.HistorialSupervisiones // seleccion de tabla inicial
                       .Join(context.Sucursales, tabla1 => tabla1.IdSucursal, tabla2 => tabla2.IdSucursal, (HistSup, Suc) => new { HistSup, Suc }) // se realiza el join para crear el contexto completo es decir todos los dato 
                       .Join(context.ctEstatusSupervision, tabla1 => tabla1.HistSup.Idstatus, tabla3 => tabla3.idstatus, (histsup2, estat) => new { histsup2, estat })
                       .Join(context.SeguimientoSupervision_Supervisores, tabla1 => tabla1.histsup2.HistSup.IdSupervisiones, tabla2 => tabla2.Idsupervision, (HistSup3, SegSup) => new { HistSup3, SegSup })
                       .Where(sc => sc.HistSup3.histsup2.HistSup.NoSupervision != null && sc.HistSup3.histsup2.Suc.IdSucursal == sc.HistSup3.histsup2.HistSup.IdSucursal && sc.HistSup3.histsup2.HistSup.IdSucursal == Globales.objpasardatosusuario.IdSucursal && sc.HistSup3.histsup2.HistSup.Idstatus == sc.HistSup3.estat.idstatus && clavestatus.Contains((int)sc.HistSup3.histsup2.HistSup.Idstatus) && (sc.HistSup3.histsup2.HistSup.IdSupervisiones == IdSupervisiones || IdSupervisiones == 0)) //ya teniendo los datos, se filtran con el where
                       .Select(x => new DatosgridSeguimientoSup

                       {
                           IdSupervisiones = x.HistSup3.histsup2.HistSup.IdSupervisiones,  // solo eligen los datos a utilizar, y com dijera la peregila :-D liiiisto :-D
                           Idseguimiento = x.SegSup.Idseguimiento,
                           NoSupervision = x.HistSup3.histsup2.HistSup.NoSupervision,
                           FechaSupervision = x.HistSup3.histsup2.HistSup.FechaSupervision,
                           DescripcionSucursal = x.HistSup3.histsup2.Suc.DescripcionSucursal,
                           Estatus = x.HistSup3.estat.statusdescrip

                       }).ToList();
                        response.Result = HistoricoSucursalesDB;
                        return response;
                    }

                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<List<DatosgridSeguimientoSup>> { Code = -100, Message = ex.Message };
            }
        }

    }
}
