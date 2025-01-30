using Microsoft.EntityFrameworkCore;
using STAR_WARS_API.Controllers.Entities;

namespace STAR_WARS_API
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        
        // *
        // Creara una tabla con los datos de cada entidad
        // *
        public DbSet<Character> Characters { get; set; }
    }
}
