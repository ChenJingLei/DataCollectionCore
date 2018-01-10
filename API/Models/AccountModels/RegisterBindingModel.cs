using System.ComponentModel.DataAnnotations;

namespace API.Models.AccountModels
{
    public class RegisterBindingModel
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        [Required]
        [StringLength(11)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string WeChatAccountInfoEncryptedData { get; set; }
    }
}