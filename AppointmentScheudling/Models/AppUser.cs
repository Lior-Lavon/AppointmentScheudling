using Microsoft.AspNetCore.Identity;

namespace AppointmentScheudling.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }

    }
}
