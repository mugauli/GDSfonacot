﻿using GDSfonacotDatos.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GDSfonacotDatos.Utilities.Util;

namespace GDSfonacotDatos
{
    public class SupervisionesData
    {
        public MethodResponse<int> GuardarSupervision(HistorialSupervisiones supervision)
        {

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<int> { Code = 0 };

                    if (supervision.IdSupervisiones == 0)
                    {
                        var usuariosDB = context.HistorialSupervisiones.Add(supervision);
                        context.SaveChanges();
                    }
                    else
                    {

                        //Edicion de Historial de supervisiones
                        var objUsuario = context.HistorialSupervisiones.Where(x => x.IdSupervisiones == supervision.IdSupervisiones).FirstOrDefault();
                       
                        objUsuario.IdSucursal = supervision.IdSucursal;
                        objUsuario.NoSupervision = supervision.NoSupervision;
                        objUsuario.FechaSupervision = supervision.FechaSupervision;
                        objUsuario.Inmueble = supervision.Inmueble;
                        objUsuario.Gestion_direccion = supervision.Gestion_direccion;
                        objUsuario.Originacion = supervision.Originacion;
                        objUsuario.Tarjetas_transfer = supervision.Tarjetas_transfer;
                        objUsuario.Credito = supervision.Credito;
                        objUsuario.Utys = supervision.Utys;
                        objUsuario.Promocionales = supervision.Promocionales;
                        objUsuario.Cobranza = supervision.Cobranza;
                        objUsuario.Fondofijo = supervision.Fondofijo;
                        objUsuario.AcuerdosCompromisos = supervision.AcuerdosCompromisos;
                        objUsuario.Idusuariocreador = supervision.Idusuariocreador;
                        objUsuario.Idstatus = supervision.Idstatus;
                        objUsuario.Idsupervisor1 = supervision.Idsupervisor1;
                        objUsuario.Idsupervisor2 = supervision.Idsupervisor2;

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

        public MethodResponse<List<HistorialSupervisiones>> ObtenerSupervisones(int IdSupervisiones, string filter)
        {
            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<List<HistorialSupervisiones>> { Code = 0 };

                    var usuariosDB = context.HistorialSupervisiones
                        .Join(context.Sucursales, s => s.IdSucursal, c => c.IdSucursal, (s, c) => new { s, c })
                        .Where(sc => (sc.s.IdSupervisiones == IdSupervisiones || IdSupervisiones == 0) && (sc.c.DescripcionSucursal.Contains(filter) || filter == "")).Select(x => x.s).ToList();

                    response.Result = usuariosDB;

                    return response;
                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<List<HistorialSupervisiones>> { Code = -100, Message = ex.Message };
            }
        }

        public MethodResponse<List<Usuarios>> ObtenerUsuarios(int IdUsuario)
        {

            try
            {


                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<List<Usuarios>> { Code = 0 };

                    var usuariosDB = context.Usuarios.Where(x => x.IdUsuario == IdUsuario || IdUsuario == 0).ToList();

                    response.Result = usuariosDB;

                    return response;
                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<List<Usuarios>> { Code = -100, Message = ex.Message };
            }
        }

        public MethodResponse<Usuarios> LoginUsuario(string Usuario, string password)
        {

            try
            {


                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<Usuarios> { Code = 0 };

                    var usuariosDB = context.Usuarios.Where(x => x.Usuario == Usuario && x.Pass == password).SingleOrDefault();

                    if (usuariosDB != null) response.Result = usuariosDB;

                    return response;
                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<Usuarios> { Code = -100, Message = ex.Message };
            }
        }



        public MethodResponse<HistorialSupervisiones> BuscarSupervision(string Supervision)
        {

            try
            {


                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<HistorialSupervisiones> { Code = 0 };

                    var nosupver = context.HistorialSupervisiones.Where(x => x.NoSupervision == Supervision).SingleOrDefault();

                    if (nosupver != null) response.Result = nosupver;

                    return response;
                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<HistorialSupervisiones> { Code = -100, Message = ex.Message };
            }
        }

        public MethodResponse<List<Sucursales>> ObtenerSucursales(int IdSucursal)
        {

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<List<Sucursales>> { Code = 0 };

                    var usuariosDB = context.Sucursales.Where(x => x.IdSucursal == IdSucursal || IdSucursal == 0).ToList();

                    response.Result = usuariosDB;

                    return response;
                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<List<Sucursales>> { Code = -100, Message = ex.Message };
            }
        }

        public MethodResponse<List<DatosComboSucursales>> ObtenerSucursalesCombo()
        {

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<List<DatosComboSucursales>> { Code = 0 };

                    var usuariosDB = context.Sucursales.OrderBy(x => x.NoSucursal)
                       .Select(x => new DatosComboSucursales { IdSucursal = x.IdSucursal, NameSucursal = (x.NoSucursal + " - " + x.DescripcionSucursal) }).ToList();

                    response.Result = usuariosDB;

                    return response;
                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<List<DatosComboSucursales>> { Code = -100, Message = ex.Message };
            }
        }

        public MethodResponse<List<DatosComboSucursales>> ObtenerSucursalesFilter(string filter)
        {

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<List<DatosComboSucursales>> { Code = 0 };

                    var usuariosDB = context.Sucursales.OrderBy(x => x.NoSucursal)
                        .Where(x=>x.DescripcionSucursal.Contains(filter))
                        .Select(x => new DatosComboSucursales { IdSucursal = x.IdSucursal, NoSucursal = x.NoSucursal, NameSucursal = x.DescripcionSucursal, DireccionRegional = x.DireccionRegional }).ToList();

                    response.Result = usuariosDB;

                    return response;
                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<List<DatosComboSucursales>> { Code = -100, Message = ex.Message };
            }
        }



        public MethodResponse<List<DatosGridSupervisiones>> ObtenerSupervisonesporSuc(int IdSupervisiones, string filter)
        {
            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<List<DatosGridSupervisiones>> { Code = 0 };

                    var HistoricoSucursalesDB = context.HistorialSupervisiones // seleccion de tabla inicial
                        .Join(context.Sucursales, tabla1 => tabla1.IdSucursal, tabla2 => tabla2.IdSucursal, (HistSup, Suc) => new { HistSup, Suc }) // se realiza el join para crear el contexto completo es decir todos los dato 
                        .Where(sc => sc.HistSup.NoSupervision != null && (sc.HistSup.IdSupervisiones == IdSupervisiones || IdSupervisiones == 0) && (sc.Suc.DescripcionSucursal.Contains(filter) || filter == "")) //ya teniendo los datos, se filtran con el where
                        .Select(x => new DatosGridSupervisiones
                        {
                            IdSupervisiones = x.HistSup.IdSupervisiones,  // solo eligen los datos a utilizar, y com dijera la peregila :-D liiiisto :-D
                            NoSupervision = x.HistSup.NoSupervision,
                            FechaSupervision = x.HistSup.FechaSupervision,
                            DescripcionSucursal = x.Suc.DescripcionSucursal
                        }).ToList();

                    response.Result = HistoricoSucursalesDB;

                    return response;
                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<List<DatosGridSupervisiones>> { Code = -100, Message = ex.Message };
            }
        }

        public bool GuardarImagen(int idSucursal, byte[] imagen)
        {
            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var sucursalDB = context.Sucursales.Where(x => x.IdSucursal == idSucursal).FirstOrDefault();

                    sucursalDB.Fotografia = imagen;

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return true;
        }

    }
}
