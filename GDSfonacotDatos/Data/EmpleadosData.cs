using GDSfonacotDatos.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GDSfonacotDatos.Utilities.Util;


namespace GDSfonacotDatos.Data
{
    public class EmpleadosData
    {
        public MethodResponse<int> GuadarEmpleado(Empleados empleado)
        {
            var response = new MethodResponse<int> { Code = 0 };

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    if (empleado.IdEmpleado == 0)
                    {
                        context.Empleados.Add(empleado);
                        context.SaveChanges();
                       
                    }
                    else
                    {
                        var empleadoDB = context.Empleados.FirstOrDefault(x => x.IdEmpleado == empleado.IdEmpleado);

                        empleadoDB.Nombre = empleado.Nombre;
                        empleadoDB.Gafete = empleado.Gafete;
                        empleadoDB.Jornada = empleado.Jornada;
                        empleadoDB.Horario = empleado.Horario;
                        empleadoDB.IdSucursal = empleado.IdSucursal;
                        empleadoDB.IdTipoPersonal = empleado.IdTipoPersonal;
                        empleadoDB.IdArea = empleado.IdArea;
                        empleadoDB.IdPerfilSistema = empleado.IdPerfilSistema;
                        empleadoDB.IdActividad = empleado.IdActividad;
                        empleadoDB.fechabaja = empleado.fechabaja;
                        empleadoDB.fechareingreso = empleado.fechareingreso;
                        empleadoDB.IdClasificacion = empleado.IdClasificacion;

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

        public MethodResponse<List<Empleados>> ObtenerEmpleados(int IdEmpleado, int IdSucursal)
        {
            var response = new MethodResponse<List<Empleados>> { Code = 0 };

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    response.Result = context.Empleados.Where(x => (x.IdEmpleado == IdEmpleado || IdEmpleado == 0) && (x.IdSucursal == IdSucursal || IdSucursal == 0)).ToList();
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

        public MethodResponse<List<EmpleadosDGV>> ObtenerEmpleadosGeneralPerfilSistema(int IdSucursal, int IdPerfilsistema)
        {
            var response = new MethodResponse<List<EmpleadosDGV>> { Code = 0 };

            try
            {

                using (var context = new GDSfonacotEntities())
                {
                    response.Result = context.Empleados
                        .Where(x => (x.IdSucursal == IdSucursal && x.IdPerfilSistema == IdPerfilsistema))
                        .Select(x => new EmpleadosDGV { IdEmpleado = x.IdEmpleado, Gafete = x.Gafete, Nombre = x.Nombre, Horario = x.Horario, Jornada = x.Jornada })
                        .ToList();
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

        public MethodResponse<List<EmpleadosDGV>> ObtenerEmpleadosGeneralporTipoPersonal(int IdSucursal, int IdTipoPersonal)
        {
            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<List<EmpleadosDGV>> { Code = 0 };



                    var devolverdatos = context.Empleados // seleccion de tabla inicial
                           .Join(context.ctPerfilSistema, tabla1 => tabla1.IdPerfilSistema, tabla2 => tabla2.IdPerfilSistema, (emp, perfil) => new { emp, perfil })
                          .Join(context.ctTipoPersonal, tabla1 => tabla1.emp.IdTipoPersonal, tabla2 => tabla2.IdTipoPersonal, (emp2, tipopers) => new { emp2, tipopers })// se realiza el join para crear el contexto completo es decir todos los dato 
                         .Join(context.ctActividad, tabla1 => tabla1.emp2.emp.IdActividad, tabla2 => tabla2.IdActividad, (emp3, activi) => new { emp3, activi })
                          .Join(context.ctClasificaciones, tabla1 => tabla1.emp3.emp2.emp.IdClasificacion, tabla2 => tabla2.IdClasificacion, (emp4, clasif) => new { emp4, clasif })
                          .Where(ep => ep.emp4.activi.IdActividad == ep.emp4.emp3.emp2.emp.IdActividad && ep.emp4.emp3.emp2.emp.IdPerfilSistema == ep.emp4.emp3.emp2.perfil.IdPerfilSistema && ep.emp4.emp3.emp2.emp.IdSucursal == IdSucursal && ep.emp4.emp3.emp2.emp.IdTipoPersonal == IdTipoPersonal)

                         .Select(x => new EmpleadosDGV
                         {
                             IdEmpleado = x.emp4.emp3.emp2.emp.IdEmpleado,
                             Gafete = x.emp4.emp3.emp2.emp.Gafete,
                             Nombre = x.emp4.emp3.emp2.emp.Nombre,
                             Horario = x.emp4.emp3.emp2.emp.Horario,
                             Jornada = x.emp4.emp3.emp2.emp.Jornada,
                             TipoPersonal = x.emp4.emp3.tipopers.Descripcion,
                             TipoPerfil = x.emp4.emp3.emp2.perfil.Descripcion,
                             TipoActividad = x.emp4.activi.Descripcion,
                             ClasifDescripcion=x.clasif.ClasifDescripcion

                         }).ToList();

                    response.Result = devolverdatos;

                    return response;
                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<List<EmpleadosDGV>> { Code = -100, Message = ex.Message };
            }
        }

        public MethodResponse<List<EmpleadosDGV>> ObtenerEmpleadosGeneral(int IdSucursal)
        {
            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<List<EmpleadosDGV>> { Code = 0 };



                    var devolverdatos = context.Empleados // seleccion de tabla inicial
                          .Join(context.ctPerfilSistema, tabla1 => tabla1.IdPerfilSistema, tabla2 => tabla2.IdPerfilSistema, (emp, perfil) => new { emp, perfil })
                          .Join(context.ctTipoPersonal, tabla1 => tabla1.emp.IdTipoPersonal, tabla2 => tabla2.IdTipoPersonal, (emp2, tipopers) => new { emp2, tipopers })// se realiza el join para crear el contexto completo es decir todos los dato 
                            .Join(context.ctActividad, tabla1 => tabla1.emp2.emp.IdActividad, tabla2 => tabla2.IdActividad, (emp3, activi) => new { emp3, activi })
                              .Join(context.ctClasificaciones, tabla1 => tabla1.emp3.emp2.emp.IdClasificacion, tabla2 => tabla2.IdClasificacion, (emp4, clasif) => new { emp4, clasif })
                          .Where(ep => ep.emp4.activi.IdActividad == ep.emp4.emp3.emp2.emp.IdActividad &&  ep.emp4.emp3.emp2.emp.IdPerfilSistema == ep.emp4.emp3.emp2.perfil.IdPerfilSistema && ep.emp4.emp3.emp2.emp.IdSucursal == IdSucursal && ep.emp4.emp3.emp2.emp.IdTipoPersonal ==ep.emp4.emp3.tipopers.IdTipoPersonal)

                         .Select(x => new EmpleadosDGV
                         {
                             IdEmpleado = x.emp4.emp3.emp2.emp.IdEmpleado,
                             Gafete = x.emp4.emp3.emp2.emp.Gafete,
                             Nombre = x.emp4.emp3.emp2.emp.Nombre,
                             Horario = x.emp4.emp3.emp2.emp.Horario,
                             Jornada = x.emp4.emp3.emp2.emp.Jornada,
                             TipoPersonal = x.emp4.emp3.tipopers.Descripcion,
                             TipoPerfil = x.emp4.emp3.emp2.perfil.Descripcion,
                             TipoActividad = x.emp4.activi.Descripcion,
                             ClasifDescripcion=x.clasif.ClasifDescripcion

                         }).ToList();

                    response.Result = devolverdatos;

                    return response;
                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<List<EmpleadosDGV>> { Code = -100, Message = ex.Message };
            }
        }

        public MethodResponse<Empleados> BuscarGafeteEmpleado(string gafete)
        {

            try
            {


                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<Empleados> { Code = 0 };

                    var empDB = context.Empleados.Where(x => x.Gafete == gafete.Trim()).SingleOrDefault();

                    if (empDB != null) response.Result = empDB;

                    return response;
                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<Empleados> { Code = -100, Message = ex.Message };
            }
        }


    }
}
