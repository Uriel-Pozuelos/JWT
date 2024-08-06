using JWT.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JWT.Data
{
    public class AppDBContext : IdentityDbContext<AppUser>
    {
        
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }


        
    }
}
