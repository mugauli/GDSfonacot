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
                        .Where(x => x.usu2.nivelusu.IdNivel == x.usu2.usu.IdNivel && x.suc.IdSucursal == x.usu2.usu.IdSucursal && x.usu2.usu.IdUsuario == Idusuario)
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
                          Usuario = x.usu2.usu.Usuario,
                          fechareingreso = x.usu2.usu.fechareingreso
                          


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

        public MethodResponse<List<UsuariosDGV>> ObtenerUsuariosGeneral(int IdSucursal, int IdNivelusuario)
        {
            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<List<UsuariosDGV>> { Code = 0 };



                    var devolverdatos = context.Usuarios // seleccion de tabla inicial
                         .Join(context.Usuarios_Nivel, tabla1 => tabla1.IdNivel, tabla2 => tabla2.IdNivel, (usu, nivelusu) => new { usu, nivelusu })
                        .Join(context.Sucursales, tabla1 => tabla1.usu.IdSucursal, tabla3 => tabla3.IdSucursal, (usu2, suc) => new { usu2, suc })
                        .Where(x => x.usu2.nivelusu.IdNivel == x.usu2.usu.IdNivel && x.suc.IdSucursal == x.usu2.usu.IdSucursal && x.usu2.usu.IdSucursal == IdSucursal && x.usu2.usu.IdNivel==IdNivelusuario)

                         .Select(x => new UsuariosDGV
                         {
                          IdUsuario=x.usu2.usu.IdUsuario,
                          Nombre_Usuario=x.usu2.usu.Nombre_Usuario,                        
                          NivelUsuarioDescrip=x.usu2.nivelusu.Nivel_Usuario,
                          DescripcionSucursal = x.suc.DescripcionSucursal
                         }).ToList();

                    response.Result = devolverdatos;

                    return response;
                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<List<UsuariosDGV>> { Code = -100, Message = ex.Message };
            }
        }

        public MethodResponse<int> GuardarUsuario(Usuarios usuario, bool inactivar)
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
                        var usuariosDB = context.Usuarios.FirstOrDefault(x => x.IdUsuario == usuario.IdUsuario);
                        usuariosDB.IdUsuario = usuario.IdUsuario;
                        usuariosDB.IdNivel = usuario.IdNivel;
                        usuariosDB.IdSucursal = usuario.IdSucursal;

                        if (inactivar == true)
                        {
                            usuariosDB.fechabaja = usuario.fechabaja;
                           usuariosDB.fechareingreso= usuario.fechareingreso;
                        }
                        else
                        {
                            usuariosDB.fechareingreso = usuario.fechareingreso;
                            usuariosDB.fechabaja = usuario.fechabaja;
                        }

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
    }
}
