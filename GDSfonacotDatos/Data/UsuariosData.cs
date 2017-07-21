using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDSfonacotDatos.DTO;
using static GDSfonacotDatos.Utilities.Util;

namespace GDSfonacotDatos.Data
{
    public class UsuariosData
    {
        public MethodResponse<List<DatosUsuario>> ObtenerUsuarios(int Idusuario)
        {

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<List<DatosUsuario>> { Code = 0 };

                    var usuariosDB = context.Usuarios
                        .Join(context.Usuarios_Nivel, tabla1 => tabla1.IdNivel, tabla2 => tabla2.IdNivel, (usu, nivelusu) => new { usu, nivelusu })
                        .Join(context.Sucursales, tabla1 => tabla1.usu.IdSucursal, tabla3 => tabla3.IdSucursal, (usu2, suc) => new { usu2, suc })
                        .Where(x => x.usu2.nivelusu.IdNivel == x.usu2.usu.IdNivel && x.suc.IdSucursal == x.usu2.usu.IdNivel)
                      .Select(x => new DatosUsuario
                      {
                          IdUsuario = x.usu2.usu.IdUsuario,
                          IdNivel = x.usu2.usu.IdNivel,
                          NivelUsuarioDescrip = x.usu2.nivelusu.Nivel_Usuario,
                          IdSucursal = x.usu2.usu.IdSucursal,
                          DescripcionSucursal = x.suc.DescripcionSucursal,
                          fechaalta = x.usu2.usu.fechaalta,
                          fechabaja = x.usu2.usu.fechabaja,
                          Nombre_Usuario = x.usu2.usu.Nombre_Usuario,
                          Pass = x.usu2.usu.Pass,
                          Usuario=x.usu2.usu.Usuario


                      }

                      ).ToList();
                    response.Result = usuariosDB;

                    return response;
                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<List<DatosUsuario>> { Code = -100, Message = ex.Message };
            }
        }

        public MethodResponse<int> GuardarUsuario(Usuarios usuario)
        {
            var response = new MethodResponse<int> { Code = 0 };

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    if (usuario.IdUsuario == 0)
                    {
                        context.Usuarios.Add(usuario);
                        context.SaveChanges();
                    }
                    else
                    {
                        var usuariosDB = context.Usuarios.FirstOrDefault(x => x.IdSucursal == usuario.IdUsuario);
                        usuariosDB.IdUsuario = usuario.IdUsuario;
                        usuariosDB.IdNivel = usuario.IdNivel;
                        usuariosDB.IdSucursal = usuario.IdSucursal;
                        usuariosDB.fechaalta = usuario.fechaalta;
                        usuariosDB.fechabaja = usuario.fechabaja;
                        usuariosDB.Nombre_Usuario = usuario.Nombre_Usuario;
                        usuariosDB.Pass = usuario.Pass;
                        usuariosDB.Usuario = usuario.Usuario;
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
