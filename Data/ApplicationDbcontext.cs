using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NhanSuBTL.Models;

namespace NhanSuBTL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<NhanSuBTL.Models.Employee> Employee { get; set; } = default!;
        public DbSet<NhanSuBTL.Models.Department> Department { get; set; } = default!;
    }
}
