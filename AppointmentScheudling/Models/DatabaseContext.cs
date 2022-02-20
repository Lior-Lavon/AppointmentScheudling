using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace AppointmentScheudling.Models
{
    public class DatabaseContext : IdentityDbContext<AppUser>
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // added to support IdentityDbContext
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new RoleConfiguration());
        }


    }
}
