using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using allin1.Models;
using rrorViewModel.Models;

namespace allin1.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

public DbSet<allin1.Models.Employee> Employee { get; set; } = default!;

public DbSet<rrorViewModel.Models.Department> Department { get; set; } = default!;
}
