using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppointmentScheudling.Models
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole() { Name = "Admin", NormalizedName = "Admin" },
                new IdentityRole() { Name = "Doctor", NormalizedName = "Doctor"},
                new IdentityRole() { Name = "Patient", NormalizedName = "Patient" }
            );
        }
    }
}
