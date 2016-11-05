using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Entidades;
namespace DAL
{
    public class RegistroyMapeoDb : DbContext
    {
        public RegistroyMapeoDb(): base("name=ConStr")
        {

        }

        public  DbSet<Estudiantes>Estudiantes { get; set; }

        public DbSet<Grupos> Grupo { get; set; }

        public DbSet<GruposEstudiante>  GruposEstudiante { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Grupos>()
        //        .HasMany<Estudiantes>(g => g.Estudiantes)
        //        .WithMany(e => e.Grupos)
        //        .Map(Ge =>
        //        {
        //            Ge.MapLeftKey("GrupoId");
        //            Ge.MapRightKey("EstudianteId");
        //            Ge.ToTable("GruposEstudiante");
        //        });
        //}

    }
}
