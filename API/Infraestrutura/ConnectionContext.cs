using API.Model;
using Microsoft.EntityFrameworkCore;

namespace API.Infraestrutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Employee> Employees {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        =>         optionsBuilder.UseNpgsql(
                   "Server=localhost;" +
                   "Port=5432;Database=employee;" +
                   "User Id=postgres;" +
                   "Password=0311;");
        
    }
}
