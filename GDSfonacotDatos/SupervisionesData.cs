using GDSfonacotDatos.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GDSfonacotDatos.Utilities.Util;
using System.Data.Entity;

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

        public MethodResponse<int> ActualizarSupervision(HistorialSupervisiones supervision)
        {

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<int> { Code = 0 };

                    if (supervision.IdSupervisiones == 0)
                    {
                        //Edicion de Historial de supervisiones
                        //error
                    }
                    else
                    {

                        //Edicion de Historial de supervisiones
                        var objUsuario = context.HistorialSupervisiones.Where(x => x.IdSupervisiones == supervision.IdSupervisiones).FirstOrDefault();

                        objUsuario.IdSupervisiones = supervision.IdSupervisiones;
                        objUsuario.Idstatus = supervision.Idstatus;
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
                        objUsuario.FechaCreacionContest = contestacion.FechaCreacionContest;
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

        public MethodResponse<int> GuardarSeguimientoSupervisor(SeguimientoSupervision_Supervisores seguimiento)
        {

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<int> { Code = 0 };

                    if (seguimiento.Idseguimiento == 0)
                    {
                        //guardar una constestacion nueva
                        var usuariosDB = context.SeguimientoSupervision_Supervisores.Add(seguimiento);
                        context.SaveChanges();
                    }
                    else
                    {

                        //Edicion de una constestacion de sucursal
                        var objUsuario = context.SeguimientoSupervision_Supervisores.Where(x => x.Idseguimiento == seguimiento.Idseguimiento).FirstOrDefault();
                        objUsuario.Idsupervision = seguimiento.Idsupervision;
                        objUsuario.Idseguimiento = seguimiento.Idseguimiento;
                        objUsuario.FechaSeguimCreacion = seguimiento.FechaSeguimCreacion;
                        objUsuario.IdusuarioCreador = seguimiento.IdusuarioCreador;
                       
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




        public MethodResponse<List<DatosSupervisores>> ObtenerSupervisores()
        {
            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<List<DatosSupervisores>> { Code = 0 };

                    var usuariosDB = context.Usuarios
                        .Where(x=>x.IdNivel==3)
                        .Select(x => new DatosSupervisores { IdUsuario = x.IdUsuario, IdNivel = x.IdNivel, Nombre_Usuario = x.Nombre_Usuario }).ToList();



                    //var usuariosDB = context.Usuarios.Where(x => x.IdUsuario == IdUsuario && IdUsuario == 0).ToList();


                    response.Result = usuariosDB;
                    return response;
                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<List<DatosSupervisores>> { Code = -100, Message = ex.Message };
            }

        }

        //Obtiene los datos de la contestacion generada por la sucursal,
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
                        .Where(q1 =>  (q1.HistSup2.HistSup.IdSupervisiones == Idsupervision))
                        .Select(x => new DatosBuscarContestacion
                        {
                            //datos de la supervision original
                           Idsupervision = x.Constsuc.Idsupervision,
                            DescripcionSucursal = x.HistSup2.Suc.DescripcionSucursal,
                            NoSucursal=x.HistSup2.Suc.NoSucursal,
                            Director_Estatal=x.HistSup2.Suc.Director_Estatal,
                            Director_Regional=x.HistSup2.Suc.Director_Regional,
                            NoSupervision=x.HistSup2.HistSup.NoSupervision,
                            //datos de la contestacion
                            Idcontestacion = x.Constsuc.Idcontestacion,
                            Inmueble =x.Constsuc.Inmueble,
                            Gestion_direccion=x.Constsuc.Gestion_direccion,
                            Originacion=x.Constsuc.Originacion,
                            Tarjetas_transfer=x.Constsuc.Tarjetas_transfer,
                            Credito=x.Constsuc.Credito,
                            Utys=x.Constsuc.Utys,
                            Promocionales=x.Constsuc.Promocionales,
                            Cobranza=x.Constsuc.Cobranza,
                            Fondofijo=x.Constsuc.Fondofijo,
                            AcuerdosCompromisos=x.Constsuc.AcuerdosCompromisos,
                            NoOficio = x.Constsuc.NoOficio,
                            Idstatus=x.HistSup2.HistSup.Idstatus
                            
                           




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

        public MethodResponse<DatosHistSupervision> ObtenerDatosHistoricoSupervision(int Idsupervision)
        {
            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<DatosHistSupervision> { Code = 0 };

                    var consultarContestacionDB = context.HistorialSupervisiones
                        .Join(context.Sucursales, tabla1 => tabla1.IdSucursal, tabla2 => tabla2.IdSucursal, (HistSup, Suc) => new { HistSup, Suc })
                         .Join(context.ctRegional, tabla1 => tabla1.Suc.IdRegional, tabla2 => tabla2.IdRegional, (suc2, reg) => new { suc2, reg })
                        .Join(context.ContestacionesSuperv_Sucursales, tabla1 => tabla1.suc2.HistSup.IdSupervisiones, tabla2 => tabla2.Idsupervision, (HistSup2, Constsuc) => new { HistSup2, Constsuc })
                       .Join(context.Usuarios, tabla1 => tabla1.HistSup2.suc2.HistSup.Idsupervisor1, tabla2 => tabla2.IdUsuario, (HistSup3, Usu1) => new { HistSup3, Usu1 })
                       .Join(context.Usuarios, tabla1 => tabla1.HistSup3.HistSup2.suc2.HistSup.Idsupervisor2, tabla3 => tabla3.IdUsuario, (HistSup4, Usu2) => new { HistSup4, Usu2 })
                        .Where(q1 => (q1.HistSup4.HistSup3.HistSup2.suc2.HistSup.IdSupervisiones == Idsupervision && q1.HistSup4.HistSup3.HistSup2.reg.IdRegional == q1.HistSup4.HistSup3.HistSup2.suc2.Suc.IdRegional && q1.HistSup4.Usu1.IdUsuario == q1.HistSup4.HistSup3.HistSup2.suc2.HistSup.Idsupervisor1 && q1.Usu2.IdUsuario == q1.HistSup4.HistSup3.HistSup2.suc2.HistSup.Idsupervisor2))
                      
                        .Select(x => new DatosHistSupervision
                        {
                            //datos de la supervision original
                            Idsupervision = x.HistSup4.HistSup3.Constsuc.Idsupervision,
                            Supervisor1 = x.HistSup4.Usu1.Nombre_Usuario,
                            Supervisor2 = x.Usu2.Nombre_Usuario,            
                            NoSupervision = x.HistSup4.HistSup3.HistSup2.suc2.HistSup.NoSupervision,
                            //datos de la contestacion
                            FechaSupervision = x.HistSup4.HistSup3.HistSup2.suc2.HistSup.FechaSupervision,
                            Idcontestacion = x.HistSup4.HistSup3.Constsuc.Idcontestacion,
                            Inmueble = x.HistSup4.HistSup3.Constsuc.Inmueble,
                            Gestion_direccion = x.HistSup4.HistSup3.Constsuc.Gestion_direccion,
                            Originacion = x.HistSup4.HistSup3.Constsuc.Originacion,
                            Tarjetas_transfer = x.HistSup4.HistSup3.Constsuc.Tarjetas_transfer,
                            Credito = x.HistSup4.HistSup3.Constsuc.Credito,
                            Utys = x.HistSup4.HistSup3.Constsuc.Utys,
                            Promocionales = x.HistSup4.HistSup3.Constsuc.Promocionales,
                            Cobranza = x.HistSup4.HistSup3.Constsuc.Cobranza,
                            Fondofijo = x.HistSup4.HistSup3.Constsuc.Fondofijo,
                            AcuerdosCompromisos = x.HistSup4.HistSup3.Constsuc.AcuerdosCompromisos,
                            NoOficio = x.HistSup4.HistSup3.Constsuc.NoOficio,
                            Idstatus = x.HistSup4.HistSup3.HistSup2.suc2.HistSup.Idstatus,
                            //datos la sucursal
                             DescripcionSucursal = x.HistSup4.HistSup3.HistSup2.suc2.Suc.DescripcionSucursal,
                            NoSucursal = x.HistSup4.HistSup3.HistSup2.suc2.Suc.NoSucursal,
                            Dirección=x.HistSup4.HistSup3.HistSup2.suc2.Suc.Dirección,
                            Representaciones=x.HistSup4.HistSup3.HistSup2.suc2.Suc.Representaciones,
                            DireccionRegional=x.HistSup4.HistSup3.HistSup2.reg.Descripcion,
                            Director_Estatal = x.HistSup4.HistSup3.HistSup2.suc2.Suc.Director_Estatal,
                            Director_Regional = x.HistSup4.HistSup3.HistSup2.suc2.Suc.Director_Regional,
                            Coordinador_Administrativo=x.HistSup4.HistSup3.HistSup2.suc2.Suc.Coordinador_Administrativo,
                            Coordinador_Cobranza=x.HistSup4.HistSup3.HistSup2.suc2.Suc.Coordinador_Cobranza,
                            Coordinador_Crédito=x.HistSup4.HistSup3.HistSup2.suc2.Suc.Coordinador_Crédito,
                            Analistas=x.HistSup4.HistSup3.HistSup2.suc2.Suc.Analistas,
                            Ventanillas=x.HistSup4.HistSup3.HistSup2.suc2.Suc.Ventanillas,
                            Analistas_Otorgamiento_de_Crédito=x.HistSup4.HistSup3.HistSup2.suc2.Suc.Analistas_Otorgamiento_de_Crédito,
                            Analistas_Administrativo_y_SAM=x.HistSup4.HistSup3.HistSup2.suc2.Suc.Analistas_Administrativo_y_SAM,
                            Analistas_Crédito_Control_Documental=x.HistSup4.HistSup3.HistSup2.suc2.Suc.Analistas_Crédito_Control_Documental,
                            Analistas_Cobranza=x.HistSup4.HistSup3.HistSup2.suc2.Suc.Analistas_Cobranza,
                            Empresas_Afiliadas=x.HistSup4.HistSup3.HistSup2.suc2.Suc.Empresas_Afiliadas,
                            Trabajadores_Afiliados=x.HistSup4.HistSup3.HistSup2.suc2.Suc.Trabajadores_Afiliados,
                            Potencial_de_Empresas=x.HistSup4.HistSup3.HistSup2.suc2.Suc.Potencial_de_Empresas,
                            Potencial_de_Trabajadores=x.HistSup4.HistSup3.HistSup2.suc2.Suc.Potencial_de_Trabajadores,
                            Empresas_Status_1=x.HistSup4.HistSup3.HistSup2.suc2.Suc.Empresas_Status_1,
                            Empresas_Status_18=x.HistSup4.HistSup3.HistSup2.suc2.Suc.Empresas_Status_18,
                            Empresas_Status_21=x.HistSup4.HistSup3.HistSup2.suc2.Suc.Empresas_Status_21,
                            Empresas_Status_30=x.HistSup4.HistSup3.HistSup2.suc2.Suc.Empresas_Status_30,
                            Meta_Anual=x.HistSup4.HistSup3.HistSup2.suc2.Suc.Meta_Anual,
                            Meta_Mensual=x.HistSup4.HistSup3.HistSup2.suc2.Suc.Meta_Mensual,
                            Colocación_Anual=x.HistSup4.HistSup3.HistSup2.suc2.Suc.Colocación_Anual,
                            Colocación_Mensual=x.HistSup4.HistSup3.HistSup2.suc2.Suc.Colocación_Mensual,
                            Fecha_baja=x.HistSup4.HistSup3.HistSup2.suc2.Suc.Fecha_baja,
                            Meta_Acumulada_Porcentaje=x.HistSup4.HistSup3.HistSup2.suc2.Suc.Meta_Acumulada_Porcentaje,
                            Cobranza_Meta_Anual=x.HistSup4.HistSup3.HistSup2.suc2.Suc.Cobranza_Meta_Anual,
                            Cobranza_Porcentaje_Meta=x.HistSup4.HistSup3.HistSup2.suc2.Suc.Cobranza_Porcentaje_Meta,
                            Cobranza_Cumplimiento_Meta=x.HistSup4.HistSup3.HistSup2.suc2.Suc.Cobranza_Cumplimiento_Meta,
                            IdRegional=x.HistSup4.HistSup3.HistSup2.suc2.Suc.IdRegional,
                            Fotografia=x.HistSup4.HistSup3.HistSup2.suc2.Suc.Fotografia
                            

                        }).SingleOrDefault();

                    if (consultarContestacionDB != null) response.Result = consultarContestacionDB;
                    return response;
                    //  response.Result = HistoricoSucursalesDB;
                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<DatosHistSupervision> { Code = -100, Message = ex.Message };
            }
        }

        public MethodResponse<DatosBuscarSupervision> ObtenerDatosSupervision(int IdSupervisiones, string filter, int clavestatus)
        {
            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<DatosBuscarSupervision> { Code = 0 };

                    var HistoricoSucursalesDB = context.HistorialSupervisiones // seleccion de tabla inicial
                        .Join(context.Sucursales, tabla1 => tabla1.IdSucursal, tabla2 => tabla2.IdSucursal, (HistSup, Suc) => new { HistSup, Suc }) // se realiza el join para crear el contexto completo es decir todos los dato 
                         .Join(context.Usuarios, tabla1 => tabla1.HistSup.Idsupervisor1, tabla2 => tabla2.IdUsuario, (HistSup2, Usu1) => new { HistSup2, Usu1 })
                          .Join(context.Usuarios, tabla1 => tabla1.HistSup2.HistSup.Idsupervisor2, tabla2 => tabla2.IdUsuario, (HistSup3, Usu2) => new { HistSup3, Usu2 })
                        .Join(context.ctRegional, tabla1 => tabla1.HistSup3.HistSup2.Suc.IdRegional, tabla2 => tabla2.IdRegional, (suc2, reg) => new { suc2, reg })
                         
                        .Where(sc => sc.suc2.HistSup3.HistSup2.HistSup.Idstatus == clavestatus && sc.reg.IdRegional == sc.suc2.HistSup3.HistSup2.Suc.IdRegional && (sc.suc2.HistSup3.HistSup2.HistSup.IdSupervisiones == IdSupervisiones) && (sc.suc2.HistSup3.HistSup2.HistSup.NoSupervision.Contains(filter))) //ya teniendo los datos, se filtran con el where
                        .Select(x => new DatosBuscarSupervision
                        {
                            IdSupervisiones = x.suc2.HistSup3.HistSup2.HistSup.IdSupervisiones,  // solo eligen los datos a utilizar, y com dijera la peregila :-D liiiisto :-D
                            NoSupervision = x.suc2.HistSup3.HistSup2.HistSup.NoSupervision,
                            FechaSupervision = x.suc2.HistSup3.HistSup2.HistSup.FechaSupervision,
                            DescripcionSucursal = x.suc2.HistSup3.HistSup2.Suc.DescripcionSucursal,
                            Director_Regional = x.suc2.HistSup3.HistSup2.Suc.Director_Regional,
                            Director_Estatal = x.suc2.HistSup3.HistSup2.Suc.Director_Estatal,
                            NoSucursal = x.suc2.HistSup3.HistSup2.Suc.NoSucursal,
                            DireccionRegional = x.reg.Descripcion,
                            Representaciones = x.suc2.HistSup3.HistSup2.Suc.Representaciones,
                            Idstatus=x.suc2.HistSup3.HistSup2.HistSup.Idstatus,
                            Supervisor1=x.suc2.HistSup3.Usu1.Nombre_Usuario,
                            Supervisor2=x.suc2.Usu2.Nombre_Usuario
                          
                            
                            
                            


                        }).SingleOrDefault();

                    if (HistoricoSucursalesDB != null) response.Result = HistoricoSucursalesDB;
                    return response;
                    //  response.Result = HistoricoSucursalesDB;


                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<DatosBuscarSupervision> { Code = -100, Message = ex.Message };
            }
        }
        //Obtiene las supervisiones realizando una busqueda por sucursal
        public MethodResponse<List<DatosGridSupervisiones>> ObtenerSupervisonesporSuc(int IdSupervisiones, string filter, int clavestatus)
        {
            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<List<DatosGridSupervisiones>> { Code = 0 };

                    var HistoricoSucursalesDB = context.HistorialSupervisiones // seleccion de tabla inicial
                        .Join(context.Sucursales, tabla1 => tabla1.IdSucursal, tabla2 => tabla2.IdSucursal, (HistSup, Suc) => new { HistSup, Suc }) // se realiza el join para crear el contexto completo es decir todos los dato 
                        .Where(sc => sc.HistSup.NoSupervision != null && sc.HistSup.Idstatus == clavestatus && (sc.HistSup.IdSupervisiones == IdSupervisiones || IdSupervisiones == 0) && (sc.Suc.DescripcionSucursal.Contains(filter) || filter == "")) //ya teniendo los datos, se filtran con el where
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

        //Obtiene las supervisiones por Sucursales, dependiendo del tipo de usuario que seas
        public MethodResponse<List<DatosGridSupervisiones>> ObtenerSupervisonesporSucIndividual(int IdSupervisiones,int[] clavestatus)
        {
            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<List<DatosGridSupervisiones>> { Code = 0 };


                    if (Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 1004 || Globales.objpasardatosusuario.IdNivel == 3)
                    {
                        
                            var HistoricoSucursalesDB = context.HistorialSupervisiones // seleccion de tabla inicial
                           .Join(context.Sucursales, tabla1 => tabla1.IdSucursal, tabla2 => tabla2.IdSucursal, (HistSup, Suc) => new { HistSup, Suc }) // se realiza el join para crear el contexto completo es decir todos los dato 
                           .Join(context.ctEstatusSupervision, tabla1 => tabla1.HistSup.Idstatus, tabla3 => tabla3.idstatus, (histsup2, estat) => new { histsup2, estat })
                           .Where(sc => sc.histsup2.HistSup.NoSupervision != null && sc.histsup2.Suc.IdSucursal == sc.histsup2.HistSup.IdSucursal && sc.histsup2.HistSup.Idstatus == sc.estat.idstatus && clavestatus.Contains((int)sc.histsup2.HistSup.Idstatus) && (sc.histsup2.HistSup.IdSupervisiones == IdSupervisiones || IdSupervisiones == 0)) //ya teniendo los datos, se filtran con el where
                           .Select(x => new DatosGridSupervisiones
                           {
                               IdSupervisiones = x.histsup2.HistSup.IdSupervisiones,  // solo eligen los datos a utilizar, y com dijera la peregila :-D liiiisto :-D
                               NoSupervision = x.histsup2.HistSup.NoSupervision,
                               FechaSupervision = x.histsup2.HistSup.FechaSupervision,
                               DescripcionSucursal = x.histsup2.Suc.DescripcionSucursal,
                               Estatus = x.estat.statusdescrip

                           }).ToList();
                            response.Result = HistoricoSucursalesDB;
                            return response;
                        
                        
                      
                    }
                    else
                    {
                        var HistoricoSucursalesDB = context.HistorialSupervisiones // seleccion de tabla inicial
                        .Join(context.Sucursales, tabla1 => tabla1.IdSucursal, tabla2 => tabla2.IdSucursal, (HistSup, Suc) => new { HistSup, Suc }) // se realiza el join para crear el contexto completo es decir todos los dato 
                        .Join(context.ctEstatusSupervision, tabla1 => tabla1.HistSup.Idstatus, tabla3 => tabla3.idstatus, (histsup2, estat) => new { histsup2, estat })
                        .Where(sc => sc.histsup2.HistSup.NoSupervision != null && sc.histsup2.Suc.IdSucursal==sc.histsup2.HistSup.IdSucursal  && sc.histsup2.HistSup.IdSucursal==Globales.objpasardatosusuario.IdSucursal && sc.histsup2.HistSup.Idstatus == sc.estat.idstatus && clavestatus.Contains((int)sc.histsup2.HistSup.Idstatus) && (sc.histsup2.HistSup.IdSupervisiones == IdSupervisiones || IdSupervisiones == 0)) //ya teniendo los datos, se filtran con el where
                        .Select(x => new DatosGridSupervisiones
                        {
                            IdSupervisiones = x.histsup2.HistSup.IdSupervisiones,  // solo eligen los datos a utilizar, y com dijera la peregila :-D liiiisto :-D
                           NoSupervision = x.histsup2.HistSup.NoSupervision,
                            FechaSupervision = x.histsup2.HistSup.FechaSupervision,
                            DescripcionSucursal = x.histsup2.Suc.DescripcionSucursal,
                            Estatus = x.estat.statusdescrip

                        }).ToList();
                        response.Result = HistoricoSucursalesDB;
                        return response;
                    }
                
                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<List<DatosGridSupervisiones>> { Code = -100, Message = ex.Message };
            }
        }

        public MethodResponse<List<DatosGridSupervisiones>> ObtenerSupervisonesporSucFechas(int IdSupervisiones, int[] clavestatus,DateTime fechaini,DateTime fechafin)
        {
            var fechainiformat = new DateTime(fechaini.Year, fechaini.Month, fechaini.Day);
            var fechafinformat = new DateTime(fechafin.Year, fechafin.Month, fechafin.Day);
            //string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(fechafin));

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<List<DatosGridSupervisiones>> { Code = 0 };

                    #region queryactual
                    if (Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 1004 || Globales.objpasardatosusuario.IdNivel == 3)
                    {

                        var HistoricoSucursalesDB = context.HistorialSupervisiones // seleccion de tabla inicial
                       .Join(context.Sucursales, tabla1 => tabla1.IdSucursal, tabla2 => tabla2.IdSucursal, (HistSup, Suc) => new { HistSup, Suc }) // se realiza el join para crear el contexto completo es decir todos los dato 
                       .Join(context.ctEstatusSupervision, tabla1 => tabla1.HistSup.Idstatus, tabla3 => tabla3.idstatus, (histsup2, estat) => new { histsup2, estat })
                       .Where(sc => sc.histsup2.HistSup.NoSupervision != null && DbFunctions.TruncateTime(sc.histsup2.HistSup.FechaSupervision) >= DbFunctions.TruncateTime(fechaini) &&
                      DbFunctions.TruncateTime(sc.histsup2.HistSup.FechaSupervision) <= DbFunctions.TruncateTime(fechafin) && sc.histsup2.Suc.IdSucursal == sc.histsup2.HistSup.IdSucursal && sc.histsup2.HistSup.Idstatus == sc.estat.idstatus
                       && clavestatus.Contains((int)sc.histsup2.HistSup.Idstatus) && (sc.histsup2.HistSup.IdSupervisiones == IdSupervisiones || IdSupervisiones == 0)) //ya teniendo los datos, se filtran con el where
                       .Select(x => new DatosGridSupervisiones
                       {
                           IdSupervisiones = x.histsup2.HistSup.IdSupervisiones,  // solo eligen los datos a utilizar, y com dijera la peregila :-D liiiisto :-D
                               NoSupervision = x.histsup2.HistSup.NoSupervision,
                           FechaSupervision = x.histsup2.HistSup.FechaSupervision,
                           DescripcionSucursal = x.histsup2.Suc.DescripcionSucursal,
                           Estatus = x.estat.statusdescrip

                       }).ToList();
                        response.Result = HistoricoSucursalesDB;
                        return response;
                    }
                    else
                    {
                        var HistoricoSucursalesDB = context.HistorialSupervisiones // seleccion de tabla inicial
                        .Join(context.Sucursales, tabla1 => tabla1.IdSucursal, tabla2 => tabla2.IdSucursal, (HistSup, Suc) => new { HistSup, Suc }) // se realiza el join para crear el contexto completo es decir todos los dato 
                        .Join(context.ctEstatusSupervision, tabla1 => tabla1.HistSup.Idstatus, tabla3 => tabla3.idstatus, (histsup2, estat) => new { histsup2, estat })
                        .Where(sc => sc.histsup2.HistSup.NoSupervision != null && sc.histsup2.Suc.IdSucursal == sc.histsup2.HistSup.IdSucursal &&
                        DbFunctions.TruncateTime(sc.histsup2.HistSup.FechaSupervision) >= DbFunctions.TruncateTime(fechaini) &&
                      DbFunctions.TruncateTime(sc.histsup2.HistSup.FechaSupervision) <= DbFunctions.TruncateTime(fechafin) && sc.histsup2.HistSup.IdSucursal == Globales.objpasardatosusuario.IdSucursal && sc.histsup2.HistSup.Idstatus == sc.estat.idstatus && clavestatus.Contains((int)sc.histsup2.HistSup.Idstatus) && (sc.histsup2.HistSup.IdSupervisiones == IdSupervisiones || IdSupervisiones == 0)) //ya teniendo los datos, se filtran con el where
                        .Select(x => new DatosGridSupervisiones
                        {
                            IdSupervisiones = x.histsup2.HistSup.IdSupervisiones,  // solo eligen los datos a utilizar, y com dijera la peregila :-D liiiisto :-D
                            NoSupervision = x.histsup2.HistSup.NoSupervision,
                            FechaSupervision = x.histsup2.HistSup.FechaSupervision,
                            DescripcionSucursal = x.histsup2.Suc.DescripcionSucursal,
                            Estatus = x.estat.statusdescrip

                        }).ToList();
                        response.Result = HistoricoSucursalesDB;
                        return response;
                    }
                    #endregion

                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<List<DatosGridSupervisiones>> { Code = -100, Message = ex.Message };
            }
        }

        public MethodResponse<List<DatosGridSupervisiones>> ObtenerUnaSup_porSucIndividual(int IdSupervisiones, int[] clavestatus,string filter)
        {
            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<List<DatosGridSupervisiones>> { Code = 0 };


                    if (Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 1004 || Globales.objpasardatosusuario.IdNivel == 3)
                    {

                        var HistoricoSucursalesDB = context.HistorialSupervisiones // seleccion de tabla inicial
                       .Join(context.Sucursales, tabla1 => tabla1.IdSucursal, tabla2 => tabla2.IdSucursal, (HistSup, Suc) => new { HistSup, Suc }) // se realiza el join para crear el contexto completo es decir todos los dato 
                       .Join(context.ctEstatusSupervision, tabla1 => tabla1.HistSup.Idstatus, tabla3 => tabla3.idstatus, (histsup2, estat) => new { histsup2, estat })
                       .Where(sc => sc.histsup2.HistSup.NoSupervision != null && sc.histsup2.Suc.IdSucursal == sc.histsup2.HistSup.IdSucursal && sc.histsup2.HistSup.Idstatus == sc.estat.idstatus && clavestatus.Contains((int)sc.histsup2.HistSup.Idstatus) && (sc.histsup2.HistSup.IdSupervisiones == IdSupervisiones || IdSupervisiones == 0) 
                       && (sc.histsup2.HistSup.NoSupervision.Contains(filter) || filter == "")) //ya teniendo los datos, se filtran con el where
                       .Select(x => new DatosGridSupervisiones
                       {
                           IdSupervisiones = x.histsup2.HistSup.IdSupervisiones,  // solo eligen los datos a utilizar, y com dijera la peregila :-D liiiisto :-D
                               NoSupervision = x.histsup2.HistSup.NoSupervision,
                           FechaSupervision = x.histsup2.HistSup.FechaSupervision,
                           DescripcionSucursal = x.histsup2.Suc.DescripcionSucursal,
                           Estatus = x.estat.statusdescrip

                       }).ToList();
                        response.Result = HistoricoSucursalesDB;
                        return response;



                    }
                    else
                    {
                        var HistoricoSucursalesDB = context.HistorialSupervisiones // seleccion de tabla inicial
                        .Join(context.Sucursales, tabla1 => tabla1.IdSucursal, tabla2 => tabla2.IdSucursal, (HistSup, Suc) => new { HistSup, Suc }) // se realiza el join para crear el contexto completo es decir todos los dato 
                        .Join(context.ctEstatusSupervision, tabla1 => tabla1.HistSup.Idstatus, tabla3 => tabla3.idstatus, (histsup2, estat) => new { histsup2, estat })
                        .Where(sc => sc.histsup2.HistSup.NoSupervision != null && sc.histsup2.Suc.IdSucursal == sc.histsup2.HistSup.IdSucursal && sc.histsup2.HistSup.IdSucursal == Globales.objpasardatosusuario.IdSucursal && sc.histsup2.HistSup.Idstatus == sc.estat.idstatus && clavestatus.Contains((int)sc.histsup2.HistSup.Idstatus) && (sc.histsup2.HistSup.IdSupervisiones == IdSupervisiones || IdSupervisiones == 0)) //ya teniendo los datos, se filtran con el where
                        .Select(x => new DatosGridSupervisiones
                        {
                            IdSupervisiones = x.histsup2.HistSup.IdSupervisiones,  // solo eligen los datos a utilizar, y com dijera la peregila :-D liiiisto :-D
                            NoSupervision = x.histsup2.HistSup.NoSupervision,
                            FechaSupervision = x.histsup2.HistSup.FechaSupervision,
                            DescripcionSucursal = x.histsup2.Suc.DescripcionSucursal,
                            Estatus = x.estat.statusdescrip

                        }).ToList();
                        response.Result = HistoricoSucursalesDB;
                        return response;
                    }

                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<List<DatosGridSupervisiones>> { Code = -100, Message = ex.Message };
            }
        }

     




    }
}
