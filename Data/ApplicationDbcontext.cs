using Microsoft.EntityFrameworkCore;
using NhanSu.Models;

namespace NhanSu.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {}

        public DbSet<Employee> Employee { get; set; }

        public DbSet<NhanSu.Models.Department> Department { get; set; } = default!;
    }
}