using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GDSfonacotDatos.Utilities.Util;

namespace GDSfonacotDatos.Data
{
    /// <summary>
    /// Obtencion de catalogos
    /// UMG
    /// 24/06/2017
    /// </summary>
    public class CatalogosData
    {
        public MethodResponse<List<ctActividad>> ObtenerActividad()
        {
            var response = new MethodResponse<List<ctActividad>> { Code = 0 };

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    response.Result = context.ctActividad.ToList();
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

        public MethodResponse<List<ctArea>> ObtenerArea()
        {
            var response = new MethodResponse<List<ctArea>> { Code = 0 };

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    response.Result = context.ctArea.ToList();
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

        public MethodResponse<List<ctPerfilSistema>> ObtenerPerfilSistema()
        {
            var response = new MethodResponse<List<ctPerfilSistema>> { Code = 0 };

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    response.Result = context.ctPerfilSistema.ToList();
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

        public MethodResponse<List<ctRegional>> ObtenerRegional()
        {
            var response = new MethodResponse<List<ctRegional>> { Code = 0 };

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    response.Result = context.ctRegional.ToList();
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

        public MethodResponse<List<ctTipoPersonal>> ObtenerTipoPersonal()
        {
            var response = new MethodResponse<List<ctTipoPersonal>> { Code = 0 };

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    response.Result = context.ctTipoPersonal.ToList();
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

        public MethodResponse<List<Usuarios_Nivel>> ObtenerNivelUsuario()
        {
            var response = new MethodResponse<List<Usuarios_Nivel>> { Code = 0 };

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    response.Result = context.Usuarios_Nivel.ToList();
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
