﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GDSfonacotEntities : DbContext
    {
        public GDSfonacotEntities()
            : base("name=GDSfonacotEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ContestacionesSuperv_Sucursales> ContestacionesSuperv_Sucursales { get; set; }
        public virtual DbSet<ctActividad> ctActividad { get; set; }
        public virtual DbSet<ctArea> ctArea { get; set; }
        public virtual DbSet<ctEstatusSupervision> ctEstatusSupervision { get; set; }
        public virtual DbSet<ctPerfilSistema> ctPerfilSistema { get; set; }
        public virtual DbSet<ctRegional> ctRegional { get; set; }
        public virtual DbSet<ctTipoPersonal> ctTipoPersonal { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<HistorialSupervisiones> HistorialSupervisiones { get; set; }
        public virtual DbSet<SeguimientoSupervision_Supervisores> SeguimientoSupervision_Supervisores { get; set; }
        public virtual DbSet<Sucursales> Sucursales { get; set; }
        public virtual DbSet<TiraAuditora> TiraAuditora { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Usuarios_Nivel> Usuarios_Nivel { get; set; }
    }
}
