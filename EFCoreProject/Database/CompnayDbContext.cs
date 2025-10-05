using EFCoreProject.model;
using Microsoft.EntityFrameworkCore;

namespace EFCoreProject.Database
{
    public class CompnayDbContext: DbContext
    {
        public CompnayDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
