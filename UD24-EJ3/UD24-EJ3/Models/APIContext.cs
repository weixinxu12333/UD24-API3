using Microsoft.EntityFrameworkCore;

namespace UD24_EJ3.Models
{
    public class APIContext: DbContext
    {
        public APIContext(DbContextOptions<APIContext> options)
            : base(options) { }

        public DbSet<Cientifico> Cientificos { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Asignado_a> Asignados_a { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cientifico>()
                .HasKey(c => c.Dni);
        }

    }
}
