using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GDSfonacotDatos.Utilities.Util;
namespace GDSfonacotDatos.Data
{
   public class CierresData
    {
        public MethodResponse<int> GuadarCierre(Cierres cierre)
        {
            var response = new MethodResponse<int> { Code = 0 };

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    if (cierre.Idcierre == 0)
                    {
                        context.Cierres.Add(cierre);
                        context.SaveChanges();

                    }
                    else
                    {
                        var empleadoDB = context.Cierres.FirstOrDefault(x => x.Idcierre == cierre.Idcierre);

                        empleadoDB.MotivoCierre = cierre.MotivoCierre;
                        empleadoDB.fechacierre = cierre.fechacierre.Value;
                       // empleadoDB.FechaCreacion = cierre.FechaCreacion.Value;
                        empleadoDB.solventada = cierre.solventada;
                        empleadoDB.Idsupervision = cierre.Idsupervision;
                        empleadoDB.Idusuariocreador = cierre.Idusuariocreador;
                       
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
