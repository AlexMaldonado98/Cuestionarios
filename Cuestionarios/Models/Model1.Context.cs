﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cuestionarios.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class cuestionariosDBEntities : DbContext
    {
        public cuestionariosDBEntities()
            : base("name=cuestionariosDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cuestionarios> cuestionarios { get; set; }
        public virtual DbSet<preguntas> preguntas { get; set; }
        public virtual DbSet<respuestas> respuestas { get; set; }
    }
}
