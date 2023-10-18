using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DAL.Modelo
{
    public class Alumno
    {
        public int AlumnoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

    }
    public partial class DbAlumnos : DbContext
    {
        public DbAlumnos()
        {
        }

        public DbAlumnos(DbContextOptions<DbAlumnos> options)
            : base(options)
        {
        }
        public virtual DbSet<Alumno> Alumnos { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=gestorBibliotecaPersonal;User Id=postgres;Password=Mitobyy12.");
            }
        }
    }

}