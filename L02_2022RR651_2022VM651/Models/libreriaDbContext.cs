using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer;

namespace L02_2022RR651_2022VM651.Models
{
    public class libreriaDbContext: DbContext
    {
        public libreriaDbContext(DbContextOptions<libreriaDbContext> options) : base(options) { }




    }
}
