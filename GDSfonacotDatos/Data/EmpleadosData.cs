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
                        empleadoDB.IdRegional = empleado.IdRegional;
                        empleadoDB.IdSucursal = empleado.IdSucursal;
                        empleadoDB.IdTipoPersonal = empleado.IdTipoPersonal;
                        empleadoDB.IdArea = empleado.IdArea;
                        empleadoDB.IdPerfilSistema = empleado.IdPerfilSistema;
                        empleadoDB.IdActividad = empleado.IdActividad;

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
                    response.Result =  context.Empleados.Where(x => (x.IdEmpleado == IdEmpleado || IdEmpleado == 0) && (x.IdSucursal == IdSucursal || IdSucursal == 0)).ToList();
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

        public MethodResponse<List<EmpleadosDGV>> ObtenerEmpleadosGeneral(int IdSucursal,int IdPerfilsistema)
        {
            var response = new MethodResponse<List<EmpleadosDGV>> { Code = 0 };

            try
            {

                using (var context = new GDSfonacotEntities())
                {
                    response.Result = context.Empleados
                        .Where(x => (x.IdSucursal==IdSucursal && x.IdPerfilSistema==IdPerfilsistema))
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

        public MethodResponse<List<EmpleadosDGV>> ObtenerEmpleadosGeneral2(int IdSucursal, int IdTipoPersonal)
        {
            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<List<EmpleadosDGV>> { Code = 0 };



                    var devolverdatos = context.Empleados // seleccion de tabla inicial
                          .Join(context.ctPerfilSistema, tabla1 => tabla1.IdPerfilSistema, tabla2 => tabla2.IdPerfilSistema, (emp, perfil) => new { emp, perfil })
                          .Join(context.ctTipoPersonal, tabla1 => tabla1.emp.IdTipoPersonal, tabla2 => tabla2.IdTipoPersonal, (emp2, tipopers) => new { emp2, tipopers })// se realiza el join para crear el contexto completo es decir todos los dato 
                          .Where(ep => ep.emp2.emp.IdPerfilSistema ==ep.emp2.perfil.IdPerfilSistema && ep.emp2.emp.IdSucursal == IdSucursal && ep.emp2.emp.IdTipoPersonal==IdTipoPersonal)

                         .Select(x => new EmpleadosDGV
                         {
                             IdEmpleado = x.emp2.emp.IdEmpleado,
                             Gafete = x.emp2.emp.Gafete,
                             Nombre = x.emp2.emp.Nombre,
                             Horario = x.emp2.emp.Horario,
                             Jornada = x.emp2.emp.Jornada,
                             TipoPersonal = x.tipopers.Descripcion,
                             TipoPerfil=x.emp2.perfil.Descripcion

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


        public MethodResponse<List<EmpleadosDGV>> ObtenerEmpleadosAdministrativos(int IdSucursal)
        {
            var response = new MethodResponse<List<EmpleadosDGV>> { Code = 0 };

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    response.Result = context.Empleados
                        .Where(x => (x.IdSucursal == IdSucursal || IdSucursal == 0))
                        .Select(x=> new EmpleadosDGV { IdEmpleado = x.IdEmpleado, Gafete = x.Gafete , Nombre = x.Nombre, Horario = x.Horario , Jornada = x.Jornada })
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

        public MethodResponse<List<EmpleadosDGV>> ObtenerEmpleadosOriginacion( int IdSucursal)
        {
            var response = new MethodResponse<List<EmpleadosDGV>> { Code = 0 };

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    response.Result = context.Empleados
                        .Where(x => (x.IdSucursal == IdSucursal || IdSucursal == 0))
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

        public MethodResponse<List<EmpleadosDGV>> ObtenerEmpleadosCredito(int IdSucursal)
        {
            var response = new MethodResponse<List<EmpleadosDGV>> { Code = 0 };

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    response.Result = context.Empleados
                        .Where(x => (x.IdSucursal == IdSucursal || IdSucursal == 0))
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

        public MethodResponse<List<EmpleadosDGV>> ObtenerEmpleadosCobranza(int IdSucursal)
        {
            var response = new MethodResponse<List<EmpleadosDGV>> { Code = 0 };

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    response.Result = context.Empleados
                        .Where(x => (x.IdSucursal == IdSucursal || IdSucursal == 0))
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

        public MethodResponse<List<EmpleadosDGV>> ObtenerEmpleadosOutsourcing(int IdSucursal)
        {
            var response = new MethodResponse<List<EmpleadosDGV>> { Code = 0 };

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    response.Result = context.Empleados
                        .Where(x => (x.IdSucursal == IdSucursal || IdSucursal == 0))
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
    }
}
