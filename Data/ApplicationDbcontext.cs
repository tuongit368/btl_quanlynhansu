using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NhanSu.Models;

namespace NhanSu.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<NhanSu.Models.Employee> Employee { get; set; } = default!;
        public DbSet<NhanSu.Models.Department> Department { get; set; } = default!;
    }
}
