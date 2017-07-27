using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDSfonacotDatos.DTO;
using static GDSfonacotDatos.Utilities.Util;

namespace GDSfonacotDatos.Data
{
    public class ContestacionesData
    {
        public MethodResponse<int> GuardarConstestacionSucursal(ContestacionesSuperv_Sucursales contestacion)
        {

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<int> { Code = 0 };

                    if (contestacion.Idcontestacion == 0)
                    {
                        //guardar una constestacion nueva
                        var usuariosDB = context.ContestacionesSuperv_Sucursales.Add(contestacion);
                        context.SaveChanges();
                    }
                    else
                    {

                        //Edicion de una constestacion de sucursal
                        var objUsuario = context.ContestacionesSuperv_Sucursales.Where(x => x.Idcontestacion == contestacion.Idcontestacion).FirstOrDefault();
                        objUsuario.Idsupervision = contestacion.Idsupervision;
                        objUsuario.Idcontestacion = contestacion.Idcontestacion;
                        objUsuario.Inmueble = contestacion.Inmueble;
                        objUsuario.Gestion_direccion = contestacion.Gestion_direccion;
                        objUsuario.Originacion = contestacion.Originacion;
                        objUsuario.Tarjetas_transfer = contestacion.Tarjetas_transfer;
                        objUsuario.Credito = contestacion.Credito;
                        objUsuario.Utys = contestacion.Utys;
                        objUsuario.Promocionales = contestacion.Promocionales;
                        objUsuario.Cobranza = contestacion.Cobranza;
                        objUsuario.Fondofijo = contestacion.Fondofijo;
                        objUsuario.AcuerdosCompromisos = contestacion.AcuerdosCompromisos;
                        objUsuario.NoOficio = contestacion.NoOficio;
                        objUsuario.FechaRespuesta = contestacion.FechaRespuesta;
                        objUsuario.Idusuariocreador = contestacion.Idusuariocreador;





                        context.SaveChanges();

                    }
                    //Cambios de chucho

                    return response;
                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<int> { Code = -100, Message = ex.Message };
            }
        }

        public MethodResponse<DatosBuscarContestacion> ObtenerDatosContestacionSupervision(int Idsupervision)
        {
            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<DatosBuscarContestacion> { Code = 0 };

                    var consultarContestacionDB = context.HistorialSupervisiones
                        .Join(context.Sucursales, tabla1 => tabla1.IdSucursal, tabla2 => tabla2.IdSucursal, (HistSup, Suc) => new { HistSup, Suc })
                        .Join(context.ContestacionesSuperv_Sucursales, tabla1 => tabla1.HistSup.IdSupervisiones, tabla2 => tabla2.Idsupervision, (HistSup2, Constsuc) => new { HistSup2, Constsuc })
                        .Where(q1 => (q1.HistSup2.HistSup.IdSupervisiones == Idsupervision && q1.HistSup2.HistSup.IdSupervisiones==q1.Constsuc.Idsupervision))
                        .Select(x => new DatosBuscarContestacion
                        {
                            //datos de la supervision original
                            Idsupervision = x.Constsuc.Idsupervision,
                            DescripcionSucursal = x.HistSup2.Suc.DescripcionSucursal,
                            NoSucursal = x.HistSup2.Suc.NoSucursal,
                            Director_Estatal = x.HistSup2.Suc.Director_Estatal,
                            Director_Regional = x.HistSup2.Suc.Director_Regional,
                            NoSupervision = x.HistSup2.HistSup.NoSupervision,
                            //datos de la contestacion
                            Idcontestacion = x.Constsuc.Idcontestacion,
                            Inmueble = x.Constsuc.Inmueble,
                            Gestion_direccion = x.Constsuc.Gestion_direccion,
                            Originacion = x.Constsuc.Originacion,
                            Tarjetas_transfer = x.Constsuc.Tarjetas_transfer,
                            Credito = x.Constsuc.Credito,
                            Utys = x.Constsuc.Utys,
                            Promocionales = x.Constsuc.Promocionales,
                            Cobranza = x.Constsuc.Cobranza,
                            Fondofijo = x.Constsuc.Fondofijo,
                            AcuerdosCompromisos = x.Constsuc.AcuerdosCompromisos,
                            NoOficio = x.Constsuc.NoOficio,
                            Idstatus = x.HistSup2.HistSup.Idstatus,
                            FechaRespuesta = x.Constsuc.FechaRespuesta,
                            FechaSupervision = x.HistSup2.HistSup.FechaSupervision







                        }).SingleOrDefault();

                    if (consultarContestacionDB != null) response.Result = consultarContestacionDB;
                    return response;
                    //  response.Result = HistoricoSucursalesDB;
                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<DatosBuscarContestacion> { Code = -100, Message = ex.Message };
            }
        }

        public MethodResponse<ContestacionesSuperv_Sucursales> BuscarNoOficio(string Oficio)
        {

            try
            {


                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<ContestacionesSuperv_Sucursales> { Code = 0 };

                    var nooficio = context.ContestacionesSuperv_Sucursales.Where(x => x.NoOficio == Oficio.Trim()).SingleOrDefault();

                    if (nooficio != null) response.Result = nooficio;

                    return response;
                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<ContestacionesSuperv_Sucursales> { Code = -100, Message = ex.Message };
            }
        }
    }
}
