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

    }
}
