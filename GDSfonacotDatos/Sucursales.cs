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
    
    public partial class Sucursales
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sucursales()
        {
            this.Empleados = new HashSet<Empleados>();
            this.HistorialSupervisiones = new HashSet<HistorialSupervisiones>();
            this.Usuarios = new HashSet<Usuarios>();
        }
    
        public int IdSucursal { get; set; }
        public short NoSucursal { get; set; }
        public string DireccionRegional { get; set; }
        public string DescripcionSucursal { get; set; }
        public string Dirección { get; set; }
        public string Representaciones { get; set; }
        public string Director_Regional { get; set; }
        public string Director_Estatal { get; set; }
        public string Coordinador_Administrativo { get; set; }
        public string Coordinador_Crédito { get; set; }
        public string Coordinador_Cobranza { get; set; }
        public Nullable<short> Analistas { get; set; }
        public Nullable<short> Ventanillas { get; set; }
        public Nullable<short> Analistas_Otorgamiento_de_Crédito { get; set; }
        public Nullable<short> Analistas_Administrativo_y_SAM { get; set; }
        public Nullable<short> Analistas_Crédito_Control_Documental { get; set; }
        public Nullable<short> Analistas_Cobranza { get; set; }
        public byte[] Fotografia { get; set; }
        public Nullable<int> Empresas_Afiliadas { get; set; }
        public Nullable<int> Trabajadores_Afiliados { get; set; }
        public Nullable<int> Potencial_de_Empresas { get; set; }
        public Nullable<int> Potencial_de_Trabajadores { get; set; }
        public Nullable<int> Empresas_Status_1 { get; set; }
        public Nullable<int> Empresas_Status_18 { get; set; }
        public Nullable<int> Empresas_Status_21 { get; set; }
        public Nullable<int> Empresas_Status_30 { get; set; }
        public Nullable<decimal> Meta_Anual { get; set; }
        public Nullable<decimal> Meta_Mensual { get; set; }
        public Nullable<decimal> Colocación_Anual { get; set; }
        public Nullable<decimal> Colocación_Mensual { get; set; }
        public Nullable<System.DateTime> Fecha_baja { get; set; }
        public Nullable<decimal> Meta_Acumulada_Porcentaje { get; set; }
        public string Cobranza_Meta_Anual { get; set; }
        public string Cobranza_Porcentaje_Meta { get; set; }
        public string Cobranza_Cumplimiento_Meta { get; set; }
        public Nullable<int> IdRegional { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empleados> Empleados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistorialSupervisiones> HistorialSupervisiones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuarios> Usuarios { get; set; }
        public virtual ctRegional ctRegional { get; set; }
    }
}
