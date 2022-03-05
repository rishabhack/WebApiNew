using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    public class EmpDbContext : IdentityDbContext<ApplicationUser>
    {        
        public EmpDbContext(DbContextOptions<EmpDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }


    }
}
