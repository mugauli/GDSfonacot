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
    
    public partial class SeguimientoSupervision_Supervisores
    {
        public int Idseguimiento { get; set; }
        public Nullable<int> Idsupervision { get; set; }
        public string OficioRespuesta { get; set; }
        public Nullable<System.DateTime> FechaRespuesta { get; set; }
        public Nullable<bool> Solventada { get; set; }
        public string SeguimientoSupervisor { get; set; }
        public Nullable<int> IdusuarioCreador { get; set; }
        public Nullable<System.DateTime> FechaSeguimCreacion { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
        public virtual Historial_de_Supervisiones Historial_de_Supervisiones { get; set; }
    }
}