using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GDSfonacotDatos.Utilities.Util;

namespace GDSfonacotDatos.Data
{
    public class ReasignacionesData
    {
        public MethodResponse<int> GuardarReasignacion(Reasignaciones reasignacion)
        {
            var response = new MethodResponse<int> { Code = 0 };

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    if (reasignacion.Idreasignacion== 0)
                    {
                        context.Reasignaciones.Add(reasignacion);
                        context.SaveChanges();

                    }
                    else
                    {
                        var empleadoDB = context.Reasignaciones.FirstOrDefault(x => x.Idreasignacion == reasignacion.Idreasignacion);

                        empleadoDB.MotivoReasigna = reasignacion.MotivoReasigna;
                        empleadoDB.fechareasignada = reasignacion.fechareasignada.Value;
                        empleadoDB.FechaCreacion = reasignacion.FechaCreacion.Value;
                        empleadoDB.Idsupervision = reasignacion.Idsupervision;
                        empleadoDB.Idusuariocreador = reasignacion.Idusuariocreador;

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
    }
}
