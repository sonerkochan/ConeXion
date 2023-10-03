using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ConeXion.Core.Models.User
{
    /// <summary>
    /// View model to pass data while logging in.
    /// </summary>
    public class LoginViewModel
    {
        [Required]
        [Description("User's Username.")]
        public string UserName { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        [Description("User's Password.")]
        public string Password { get; set; } = null!;
    }
}