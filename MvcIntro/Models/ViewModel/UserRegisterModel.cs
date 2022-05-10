using MvcIntro.Validators;
using System.ComponentModel.DataAnnotations;

namespace MvcIntro.Models.ViewModel
{
    public class UserRegisterModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [StrongPassword]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string PasswordRepeat { get; set; }
    }
}