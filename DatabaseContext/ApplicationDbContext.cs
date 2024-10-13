using Microsoft.EntityFrameworkCore;

namespace PruebaAPI.DatabaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Pelicula> Peliculas { get; set; }
    }
}
