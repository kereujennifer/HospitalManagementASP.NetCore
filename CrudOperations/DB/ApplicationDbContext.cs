using CrudOperations.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudOperations.DB
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee>Employees { get; set; }
    }
}
