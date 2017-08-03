using GDSfonacotDatos.DTO;
using static GDSfonacotDatos.Utilities.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GDSfonacotDatos.Data
{
    public class SucursalesData
    {
        public MethodResponse<List<DatosSucursales>> ObtenerSucursales(int IdSucursal)
        {

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<List<DatosSucursales>> { Code = 0 };

                    var usuariosDB = context.Sucursales
                        .Join(context.ctRegional, tabla1 => tabla1.IdRegional, tabla2 => tabla2.IdRegional, (suc, reg) => new { suc, reg })
                        .Where(x => x.suc.IdSucursal == IdSucursal && x.reg.IdRegional == x.suc.IdRegional)
                      .Select(x => new DatosSucursales
                      {
                          IdSucursal = x.suc.IdSucursal,
                          NoSucursal = x.suc.NoSucursal,
                          DireccionRegional = x.reg.Descripcion,
                          DescripcionSucursal = x.suc.DescripcionSucursal,
                          Dirección = x.suc.Dirección,
                          Representaciones = x.suc.Representaciones,
                          Director_Regional = x.reg.Titular,
                          Director_Estatal = x.suc.Director_Estatal,
                          Coordinador_Administrativo = x.suc.Coordinador_Administrativo,
                          Coordinador_Crédito = x.suc.Coordinador_Crédito,
                          Coordinador_Cobranza = x.suc.Coordinador_Cobranza,
                          Analistas = x.suc.Analistas,
                          Ventanillas = x.suc.Ventanillas,
                          Analistas_Otorgamiento_de_Crédito = x.suc.Analistas_Otorgamiento_de_Crédito,
                          Analistas_Administrativo_y_SAM = x.suc.Analistas_Administrativo_y_SAM,
                          Analistas_Crédito_Control_Documental = x.suc.Analistas_Crédito_Control_Documental,
                          Analistas_Cobranza = x.suc.Analistas_Cobranza,
                          Fotografia = x.suc.Fotografia,
                          Empresas_Afiliadas = x.suc.Empresas_Afiliadas,
                          Trabajadores_Afiliados = x.suc.Trabajadores_Afiliados,
                          Potencial_de_Empresas = x.suc.Potencial_de_Empresas,
                          Potencial_de_Trabajadores = x.suc.Potencial_de_Trabajadores,
                          Empresas_Status_1 = x.suc.Empresas_Status_1,
                          Empresas_Status_18 = x.suc.Empresas_Status_18,
                          Empresas_Status_21 = x.suc.Empresas_Status_21,
                          Empresas_Status_30 = x.suc.Empresas_Status_30,
                          Meta_Anual = x.suc.Meta_Anual,
                          Meta_Mensual = x.suc.Meta_Mensual,
                          Colocación_Anual = x.suc.Colocación_Anual,
                          Colocación_Mensual = x.suc.Colocación_Mensual,
                          Fecha_baja = x.suc.Fecha_baja,
                          Meta_Acumulada_Porcentaje = x.suc.Meta_Acumulada_Porcentaje,
                          Cobranza_Meta_Anual = x.suc.Cobranza_Meta_Anual,
                          Cobranza_Meta_Mensual = x.suc.Cobranza_Meta_Mensual,
                          Cobranza_Porcentaje_Meta = x.suc.Cobranza_Porcentaje_Meta,
                          Cobranza_Cumplimiento_Meta = x.suc.Cobranza_Cumplimiento_Meta,
                          IdRegional = x.suc.IdRegional,
                          Latitud = x.suc.Latitud,
                          Altitud=x.suc.Altitud,
                          IdsucursalPadre=x.suc.IdsucursalPadre
                      }

                      ).ToList();
                    response.Result = usuariosDB;

                    return response;
                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<List<DatosSucursales>> { Code = -100, Message = ex.Message };
            }
        }

        public MethodResponse<Sucursales> BuscarNoSucursal(int nosucursal)
        {

            try
            {


                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<Sucursales> { Code = 0 };

                    var sucDB = context.Sucursales.Where(x => x.NoSucursal == nosucursal).SingleOrDefault();

                    if (sucDB != null) response.Result = sucDB;

                    return response;
                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<Sucursales> { Code = -100, Message = ex.Message };
            }
        }

        public MethodResponse<DatosSucursales> ObtenerSucursal(int IdSucursal)
        {

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<DatosSucursales> { Code = 0 };

                    var usuariosDB = context.Sucursales
                        .Join(context.ctRegional, tabla1 => tabla1.IdRegional, tabla2 => tabla2.IdRegional, (suc, reg) => new { suc, reg })
                        .Where(x => x.suc.IdSucursal == IdSucursal && x.reg.IdRegional == x.suc.IdRegional)
                      .Select(x => new DatosSucursales
                      {
                          IdSucursal = x.suc.IdSucursal,
                          NoSucursal = x.suc.NoSucursal,
                          DireccionRegional = x.reg.Descripcion,
                          DescripcionSucursal = x.suc.DescripcionSucursal,
                          Dirección = x.suc.Dirección,
                          Representaciones = x.suc.Representaciones,
                          Director_Regional = x.reg.Titular,
                          Director_Estatal = x.suc.Director_Estatal,
                          Coordinador_Administrativo = x.suc.Coordinador_Administrativo,
                          Coordinador_Crédito = x.suc.Coordinador_Crédito,
                          Coordinador_Cobranza = x.suc.Coordinador_Cobranza,
                          Analistas = x.suc.Analistas,
                          Ventanillas = x.suc.Ventanillas,
                          Analistas_Otorgamiento_de_Crédito = x.suc.Analistas_Otorgamiento_de_Crédito,
                          Analistas_Administrativo_y_SAM = x.suc.Analistas_Administrativo_y_SAM,
                          Analistas_Crédito_Control_Documental = x.suc.Analistas_Crédito_Control_Documental,
                          Analistas_Cobranza = x.suc.Analistas_Cobranza,
                          Fotografia = x.suc.Fotografia,
                          Empresas_Afiliadas = x.suc.Empresas_Afiliadas,
                          Trabajadores_Afiliados = x.suc.Trabajadores_Afiliados,
                          Potencial_de_Empresas = x.suc.Potencial_de_Empresas,
                          Potencial_de_Trabajadores = x.suc.Potencial_de_Trabajadores,
                          Empresas_Status_1 = x.suc.Empresas_Status_1,
                          Empresas_Status_18 = x.suc.Empresas_Status_18,
                          Empresas_Status_21 = x.suc.Empresas_Status_21,
                          Empresas_Status_30 = x.suc.Empresas_Status_30,
                          Meta_Anual = x.suc.Meta_Anual,
                          Meta_Mensual = x.suc.Meta_Mensual,
                          Colocación_Anual = x.suc.Colocación_Anual,
                          Colocación_Mensual = x.suc.Colocación_Mensual,
                          Fecha_baja = x.suc.Fecha_baja,
                          Meta_Acumulada_Porcentaje = x.suc.Meta_Acumulada_Porcentaje,
                          Cobranza_Meta_Anual = x.suc.Cobranza_Meta_Anual,
                          Cobranza_Meta_Mensual = x.suc.Cobranza_Meta_Mensual,
                          Cobranza_Porcentaje_Meta = x.suc.Cobranza_Porcentaje_Meta,
                          Cobranza_Cumplimiento_Meta = x.suc.Cobranza_Cumplimiento_Meta,
                          IdRegional = x.suc.IdRegional,
                          Latitud = x.suc.Latitud,
                          Altitud = x.suc.Altitud,
                          IdsucursalPadre = x.suc.IdsucursalPadre
                      }

                      ).SingleOrDefault();
                    response.Result = usuariosDB;

                    return response;
                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<DatosSucursales>{ Code = -100, Message = ex.Message };
            }
        }

        public MethodResponse<List<DatosSucursales>> ObtenerRegionSucursal(int IdSucursal)
        {

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<List<DatosSucursales>> { Code = 0 };

                    var usuariosDB = context.Sucursales
                        .Join(context.ctRegional, tabla1 => tabla1.IdRegional, tabla2 => tabla2.IdRegional, (suc, reg) => new { suc, reg })
                        .Where(x => x.suc.IdSucursal == IdSucursal && x.reg.IdRegional == x.suc.IdRegional)
                      .Select(x => new DatosSucursales
                      {
                          IdSucursal = x.suc.IdSucursal,
                          NoSucursal = x.suc.NoSucursal,
                          DireccionRegional = x.reg.Descripcion,
                          IdRegional = x.suc.IdRegional,
                          Director_Regional=x.reg.Titular


                      }

                      ).ToList();
                    response.Result = usuariosDB;

                    return response;
                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<List<DatosSucursales>> { Code = -100, Message = ex.Message };
            }
        }

        public MethodResponse<List<DatosSucursales>> ObtenerRegionTitular(int Idregion)
        {

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<List<DatosSucursales>> { Code = 0 };

                    var usuariosDB = context.ctRegional
                        .Join(context.ctRegional, tabla1 => tabla1.IdRegional, tabla2 => tabla2.IdRegional, (suc, reg) => new { suc, reg })
                        .Where(x => x.suc.IdRegional ==x.reg.IdRegional && x.reg.IdRegional ==Idregion)
                      .Select(x => new DatosSucursales
                      {
                          //IdSucursal = x.suc.IdSucursal,
                          //NoSucursal = x.suc.NoSucursal,
                          DireccionRegional = x.reg.Descripcion,
                          IdRegional = x.suc.IdRegional,
                          Director_Regional = x.reg.Titular


                      }

                      ).ToList();
                    response.Result = usuariosDB;

                    return response;
                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<List<DatosSucursales>> { Code = -100, Message = ex.Message };
            }
        }

        public MethodResponse<List<DatosComboSucursales>> ObtenerSucursalesFilter(string filter)
        {

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<List<DatosComboSucursales>> { Code = 0 };
                    if (Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 1004 || Globales.objpasardatosusuario.IdNivel == 3)
                    {
                        var usuariosDB = context.Sucursales
                      .Join(context.ctRegional, tabla1 => tabla1.IdRegional, tabla2 => tabla2.IdRegional, (suc, reg) => new { suc, reg })
                      .Where(x => x.reg.IdRegional == x.suc.IdRegional && x.suc.DescripcionSucursal.Contains(filter))
                      .Select(x => new DatosComboSucursales { IdSucursal = x.suc.IdSucursal, NoSucursal = x.suc.NoSucursal, NameSucursal = x.suc.DescripcionSucursal, DireccionRegional = x.reg.Descripcion }).ToList();



                        //var usuariosDB = context.Usuarios.Where(x => x.IdUsuario == IdUsuario && IdUsuario == 0).ToList();


                        response.Result = usuariosDB;

                        return response;
                    }
                    else
                    {
                        var usuariosDB = context.Sucursales
                     .Join(context.ctRegional, tabla1 => tabla1.IdRegional, tabla2 => tabla2.IdRegional, (suc, reg) => new { suc, reg })
                     .Where(x => x.reg.IdRegional == x.suc.IdRegional && x.suc.IdSucursal==Globales.objpasardatosusuario.IdSucursal && x.suc.DescripcionSucursal.Contains(filter))
                     .Select(x => new DatosComboSucursales { IdSucursal = x.suc.IdSucursal, NoSucursal = x.suc.NoSucursal, NameSucursal = x.suc.DescripcionSucursal, DireccionRegional = x.reg.Descripcion }).ToList();



                        //var usuariosDB = context.Usuarios.Where(x => x.IdUsuario == IdUsuario && IdUsuario == 0).ToList();


                        response.Result = usuariosDB;

                        return response;
                    }
                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<List<DatosComboSucursales>> { Code = -100, Message = ex.Message };
            }
        }

        public MethodResponse<List<DatosComboSucursales>> ObtenerSucursalesporNivelUsuario()
        {

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    var response = new MethodResponse<List<DatosComboSucursales>> { Code = 0 };
                      var usuariosDB = context.Sucursales
                     .Join(context.ctRegional, tabla1 => tabla1.IdRegional, tabla2 => tabla2.IdRegional, (suc, reg) => new { suc, reg })
                     .Where(x => x.reg.IdRegional == x.suc.IdRegional && x.suc.IdSucursal == Globales.objpasardatosusuario.IdSucursal)
                     .Select(x => new DatosComboSucursales { IdSucursal = x.suc.IdSucursal, NoSucursal = x.suc.NoSucursal, NameSucursal = x.suc.DescripcionSucursal, DireccionRegional = x.reg.Descripcion }).ToList();



                        //var usuariosDB = context.Usuarios.Where(x => x.IdUsuario == IdUsuario && IdUsuario == 0).ToList();


                        response.Result = usuariosDB;

                        return response;
                    
                }

            }
            catch (Exception ex)
            {

                return new MethodResponse<List<DatosComboSucursales>> { Code = -100, Message = ex.Message };
            }
        }
        public MethodResponse<int> GuadarSucursal(Sucursales sucursal)
        {
            var response = new MethodResponse<int> { Code = 0 };

            try
            {
                using (var context = new GDSfonacotEntities())
                {
                    if (sucursal.IdSucursal== 0)
                    {
                        context.Sucursales.Add(sucursal);
                        context.SaveChanges();
                    }
                    else
                    {
                        var sucursalDB = context.Sucursales.FirstOrDefault(x => x.IdSucursal == sucursal.IdSucursal);
                        sucursalDB.NoSucursal = sucursal.NoSucursal;
                        sucursalDB.DescripcionSucursal = sucursal.DescripcionSucursal;
                        sucursalDB.Dirección = sucursal.Dirección;
                        sucursalDB.Representaciones = sucursal.Representaciones;
                        sucursalDB.Director_Regional = sucursal.Director_Regional;
                        sucursalDB.Director_Estatal = sucursal.Director_Estatal;
                        sucursalDB.Coordinador_Administrativo = sucursal.Coordinador_Administrativo;
                        sucursalDB.Coordinador_Crédito = sucursal.Coordinador_Crédito;
                        sucursalDB.Coordinador_Cobranza = sucursal.Coordinador_Cobranza;
                        sucursalDB.Analistas = sucursal.Analistas;
                        sucursalDB.Ventanillas = sucursal.Ventanillas;
                        sucursalDB.Analistas_Otorgamiento_de_Crédito = sucursal.Analistas_Otorgamiento_de_Crédito;
                        sucursalDB.Analistas_Administrativo_y_SAM = sucursal.Analistas_Administrativo_y_SAM;
                        sucursalDB.Analistas_Crédito_Control_Documental = sucursal.Analistas_Crédito_Control_Documental;
                        sucursalDB.Analistas_Cobranza = sucursal.Analistas_Cobranza;
                        sucursalDB.Fotografia = sucursal.Fotografia;
                        sucursalDB.Empresas_Afiliadas = sucursal.Empresas_Afiliadas;
                        sucursalDB.Trabajadores_Afiliados = sucursal.Trabajadores_Afiliados;
                        sucursalDB.Potencial_de_Empresas = sucursal.Potencial_de_Empresas;
                        sucursalDB.Potencial_de_Trabajadores = sucursal.Potencial_de_Trabajadores;
                        sucursalDB.Empresas_Status_1 = sucursal.Empresas_Status_1;
                        sucursalDB.Empresas_Status_18 = sucursal.Empresas_Status_18;
                        sucursalDB.Empresas_Status_21 = sucursal.Empresas_Status_21;
                        sucursalDB.Empresas_Status_30 = sucursal.Empresas_Status_30;
                        sucursalDB.Meta_Anual = sucursal.Meta_Anual;
                        sucursalDB.Meta_Mensual = sucursal.Meta_Mensual;
                        sucursalDB.Colocación_Anual = sucursal.Colocación_Anual;
                        sucursalDB.Colocación_Mensual = sucursal.Colocación_Mensual;
                        sucursalDB.Fecha_baja = sucursal.Fecha_baja;
                        sucursalDB.Meta_Acumulada_Porcentaje = sucursal.Meta_Acumulada_Porcentaje;
                        sucursalDB.Cobranza_Meta_Anual = sucursal.Cobranza_Meta_Anual;
                        sucursalDB.Cobranza_Meta_Mensual = sucursal.Cobranza_Meta_Mensual;
                        sucursalDB.Cobranza_Porcentaje_Meta = sucursal.Cobranza_Porcentaje_Meta;
                        sucursalDB.Cobranza_Cumplimiento_Meta = sucursal.Cobranza_Cumplimiento_Meta;
                        sucursalDB.IdRegional = sucursal.IdRegional;
                        sucursalDB.Altitud = sucursal.Altitud;
                        sucursalDB.Latitud = sucursal.Latitud;
                        sucursalDB.IdsucursalPadre = sucursal.IdsucursalPadre;


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



    }
}
