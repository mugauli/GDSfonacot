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
    
    public partial class Reasignaciones
    {
        public int Idreasignacion { get; set; }
        public string MotivoReasigna { get; set; }
        public Nullable<System.DateTime> fechareasignada { get; set; }
        public Nullable<int> Idsupervision { get; set; }
        public Nullable<int> Idusuariocreador { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
    
        public virtual HistorialSupervisiones HistorialSupervisiones { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}