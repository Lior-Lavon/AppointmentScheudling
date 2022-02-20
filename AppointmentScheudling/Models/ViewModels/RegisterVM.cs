using System.ComponentModel.DataAnnotations;

namespace AppointmentScheudling.Models.ViewModels
{
    public class RegisterVM
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage ="The {0} must be al least {1} characters long", MinimumLength = 6)]
        public string Password { get; set; }
        
        [Required]
        [Display(Name ="Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        
        [Required]
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }
    }
}
