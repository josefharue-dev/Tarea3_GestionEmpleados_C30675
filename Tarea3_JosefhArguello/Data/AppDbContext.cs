using Microsoft.EntityFrameworkCore;
using Tarea3_JosefhArguello.Models;

namespace Tarea3_JosefhArguello.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Empleado> Empleados { get; set; }
    }
}
