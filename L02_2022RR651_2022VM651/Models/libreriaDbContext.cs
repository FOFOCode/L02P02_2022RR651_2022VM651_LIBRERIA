using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer;

namespace L02_2022RR651_2022VM651.Models
{
    public class libreriaDbContext: DbContext
    {
        public libreriaDbContext(DbContextOptions<libreriaDbContext> options) : base(options) { }

        public DbSet<autores> autores { get; set; }
        public DbSet<libros> libros { get; set; }
        public DbSet<clientes> clientes { get; set; }
        public DbSet<categorias> categorias { get; set; }
        public DbSet<comentarios_libros> comentarios_libros { get; set; }
        public DbSet<pedido_detalle> pedido_detalles { get; set; }
        public DbSet<pedido_encabezado> pedidos_encabezado { get; set; }
    }
}
