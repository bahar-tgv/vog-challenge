using Microsoft.EntityFrameworkCore;
using VogCodeChallenge.Entities;

namespace VogCodeChallenge.API.Data
{
    public class RelationalDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }
    }
}
