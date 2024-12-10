using System.ComponentModel.DataAnnotations;

namespace Uniqlo.ViewModels.Account
{
    public class ForgetPasswordVm
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
