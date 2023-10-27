using System.ComponentModel.DataAnnotations;

namespace HistoryPediaV2.Core.ViewModels.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Login required")]
        [Display(Name = "Login")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password required")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}
