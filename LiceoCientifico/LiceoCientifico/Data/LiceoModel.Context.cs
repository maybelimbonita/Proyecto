﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LiceoCientifico.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BDLiceoCientificoEntities : DbContext
    {
        public BDLiceoCientificoEntities()
            : base("name=BDLiceoCientificoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<AlumnoxMateria> AlumnoxMateria { get; set; }
        public virtual DbSet<AlumnoXSeccion> AlumnoXSeccion { get; set; }
        public virtual DbSet<DetallePago> DetallePago { get; set; }
        public virtual DbSet<Grado> Grado { get; set; }
        public virtual DbSet<Maestro> Maestro { get; set; }
        public virtual DbSet<Materia> Materia { get; set; }
        public virtual DbSet<Pagos> Pagos { get; set; }
        public virtual DbSet<Permisos> Permisos { get; set; }
        public virtual DbSet<Seccion> Seccion { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TipoPago> TipoPago { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<PermisosxUsuario> PermisosxUsuario { get; set; }
    }
}
