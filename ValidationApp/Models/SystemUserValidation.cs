using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ValidationApp.Models.Validation;

namespace ValidationApp.Models
{
    public class SystemUserValidation
    {
        [Required(ErrorMessage = "Username cannot be empty!")]
        [StringLength(10, ErrorMessage = "Username should be between 3-10 characters...", MinimumLength = 3)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Identification number cannot be empty!")]
        [IdentificationNumberValidation(ErrorMessage = "Invalid identification number!")] // Custom
        public string IdentificationNumber { get; set; }

        [Required(ErrorMessage = "Score cannot be empty!")]
        [Range(0, 100, ErrorMessage = "Score should be between 0-100...")]
        public int Score { get; set; }

        [Required(ErrorMessage = "Email address cannot be empty!")]
        [EmailValidation(ErrorMessage = "Email address should end with @contoso.com, and cannot contain spaces!")] // Custom
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Password address cannot be empty!")]
        [StringLength(20, ErrorMessage = "Password should be between 8-20 characters...", MinimumLength = 8)]
        public string Password { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Password confirmation cannot be empty!")]
        [Compare("Password", ErrorMessage = "Password confirmation is not successfull!")]
        public string PasswordConfirmation { get; set; }
    }
}
