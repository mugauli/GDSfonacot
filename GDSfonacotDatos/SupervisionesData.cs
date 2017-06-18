using GDSfonacotDatos.DTO;
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
        public MethodResponse<int> GuardarSupervision(Historial_de_Supervisiones supervision)
        {

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<int> { Code = 0 };

                    if (supervision.IdSupervisiones == 0)
                    {
                        var usuariosDB = context.Historial_de_Supervisiones.Add(supervision);
                        context.SaveChanges();
                    }
                    else
                    {
                        var objUsuario = context.Historial_de_Supervisiones.Where(x => x.IdSupervisiones == supervision.IdSupervisiones).FirstOrDefault();


                        objUsuario.IdSucursal = supervision.IdSucursal;
                        objUsuario.NoSupervision = supervision.NoSupervision;
                        objUsuario.FechaSupervision = supervision.FechaSupervision;
                        objUsuario.AfiliacionOtorgamientoCredito = supervision.AfiliacionOtorgamientoCredito;
                        objUsuario.ActividadesPromocionAfiliaciónCT = supervision.ActividadesPromocionAfiliaciónCT;
                        objUsuario.ProcesoCobranza = supervision.ProcesoCobranza;
                        objUsuario.Revisión_de_UTYS = supervision.Revisión_de_UTYS;
                        objUsuario.Situaciones_de_Orden_General_e_Infraestructura = supervision.Situaciones_de_Orden_General_e_Infraestructura;
                        objUsuario.AcuerdosCompromisos = supervision.AcuerdosCompromisos;
                        objUsuario.No_de_Respuesta_Supervision = supervision.No_de_Respuesta_Supervision;
                        objUsuario.FechaRespuestaSupervision = supervision.FechaRespuestaSupervision;
                        objUsuario.Seguimiento_a_la_Supervisión = supervision.Seguimiento_a_la_Supervisión;
                        objUsuario.Respuesta_Supervision = supervision.Respuesta_Supervision;
                        objUsuario.Solventada = supervision.Solventada;
                        objUsuario.IdSupervisor1 = supervision.IdSupervisor1;
                        objUsuario.IdSupervisor2 = supervision.IdSupervisor2;
                        objUsuario.NoOficio = supervision.NoOficio;

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

        public MethodResponse<List<Historial_de_Supervisiones>> ObtenerSupervisones(int IdSupervisiones, string filter)
        {
            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<List<Historial_de_Supervisiones>> { Code = 0 };

                    var usuariosDB = context.Historial_de_Supervisiones
                        .Join(context.Sucursales, s => s.IdSucursal, c => c.IdSucursal, (s, c) => new { s, c })
                        .Where(sc => (sc.s.IdSupervisiones == IdSupervisiones || IdSupervisiones == 0) && (sc.c.DescripcionSucursal.Contains(filter) || filter == "")).Select(x => x.s).ToList();

                    response.Result = usuariosDB;

                    return response;
                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<List<Historial_de_Supervisiones>> { Code = -100, Message = ex.Message };
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

        public MethodResponse<List<DatosGridSupervisiones>> ObtenerSupervisonesporSuc(int IdSupervisiones, string filter)
        {
            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<List<DatosGridSupervisiones>> { Code = 0 };

                    var HistoricoSucursalesDB = context.Historial_de_Supervisiones // seleccion de tabla inicial
                        .Join(context.Sucursales, tabla1 => tabla1.IdSucursal, tabla2 => tabla2.IdSucursal, (HistSup, Suc) => new { HistSup, Suc }) // se realiza el join para crear el contexto completo es decir todos los dato 
                        .Where(sc => sc.HistSup.NoSupervision!=null &&  (sc.HistSup.IdSupervisiones == IdSupervisiones || IdSupervisiones == 0) && (sc.Suc.DescripcionSucursal.Contains(filter) || filter == "")) //ya teniendo los datos, se filtran con el where
                        .Select(x => new DatosGridSupervisiones { IdSupervisiones = x.HistSup.IdSupervisiones,  // solo eligen los datos a utilizar, y com dijera la peregila :-D liiiisto :-D
                                                                  NoSupervision = x.HistSup.NoSupervision,
                                                                  FechaSupervision = x.HistSup.FechaSupervision,
                                                                  DescripcionSucursal = x.Suc.DescripcionSucursal }).ToList();

                    response.Result = HistoricoSucursalesDB;

                    return response;
                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<List<DatosGridSupervisiones>> { Code = -100, Message = ex.Message };
            }
        }

    }
}
