//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GDSfonacotDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empleados
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Gafete { get; set; }
        public string Jornada { get; set; }
        public string Horario { get; set; }
        public int IdSucursal { get; set; }
        public int IdTipoPersonal { get; set; }
        public int IdArea { get; set; }
        public int IdPerfilSistema { get; set; }
        public int IdActividad { get; set; }
        public Nullable<System.DateTime> fechaalta { get; set; }
        public Nullable<System.DateTime> fechabaja { get; set; }
        public Nullable<System.DateTime> fechareingreso { get; set; }
        public Nullable<int> IdClasificacion { get; set; }
    
        public virtual ctActividad ctActividad { get; set; }
        public virtual ctArea ctArea { get; set; }
        public virtual ctClasificaciones ctClasificaciones { get; set; }
        public virtual ctPerfilSistema ctPerfilSistema { get; set; }
        public virtual ctTipoPersonal ctTipoPersonal { get; set; }
        public virtual Sucursales Sucursales { get; set; }
    }
}
