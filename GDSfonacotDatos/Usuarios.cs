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
    
    public partial class Usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuarios()
        {
            this.Historial_de_Supervisiones = new HashSet<Historial_de_Supervisiones>();
            this.Historial_de_Supervisiones1 = new HashSet<Historial_de_Supervisiones>();
            this.TiraAuditora = new HashSet<TiraAuditora>();
        }
    
        public int IdUsuario { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Usuario { get; set; }
        public string Pass { get; set; }
        public Nullable<int> IdNivel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Historial_de_Supervisiones> Historial_de_Supervisiones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Historial_de_Supervisiones> Historial_de_Supervisiones1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TiraAuditora> TiraAuditora { get; set; }
        public virtual Usuarios_Nivel Usuarios_Nivel { get; set; }
    }
}
