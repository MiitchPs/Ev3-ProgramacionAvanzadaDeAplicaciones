using Microsoft.EntityFrameworkCore;

namespace WebApp.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Marca> tblMarcas { get; set; }
        public DbSet<Tipo> tblTipos { get; set; }
        public DbSet<Categoria> tblCategorias { get; set; }
        public DbSet<Producto> tblProductos { get; set; }
        public DbSet<Sucursal> tblSucursales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration
                .GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
