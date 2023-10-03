using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using static ConeXion.Infrastructure.Data.Constants.GlobalConstants;

namespace ConeXion.Core.Models.User
{
    /// <summary>
    /// View model to pass data while registering a new user.
    /// </summary>
    public class RegisterViewModel
    {
        [Required]
        [StringLength(UserNameMaxLength, MinimumLength = UserNameMinLength)]
        [Description("User's Username.")]
        public string UserName { get; set; } = null!;

        [Required]
        [EmailAddress]
        [StringLength(EmailMaxLength, MinimumLength = EmailMinLength)]
        [Description("User's Email.")]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(PasswordMaxLength, MinimumLength = PasswordMinLength)]
        [DataType(DataType.Password)]
        [Description("User's Password.")]
        public string Password { get; set; } = null!;

        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        [Description("User's Password confirmation.")]
        public string ConfirmPassword { get; set; } = null!;
    }
}