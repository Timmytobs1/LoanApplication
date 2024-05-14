using System.ComponentModel.DataAnnotations;

namespace LoanApplication.Models
{
    public class LoginViewModel
    {

        [Required]
        public string Email { get; set; }
        [Required]
        public string password { get; set; }

    }
}
