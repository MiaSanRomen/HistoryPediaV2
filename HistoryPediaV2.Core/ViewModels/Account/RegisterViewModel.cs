using System.ComponentModel.DataAnnotations;

namespace HistoryPediaV2.Core.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Email required")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Login required")]
        [Display(Name = "Login")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password confirm required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Wrong password")]
        [Display(Name = "Confirm password")]
        public string PasswordConfirm { get; set; }
    }
}
