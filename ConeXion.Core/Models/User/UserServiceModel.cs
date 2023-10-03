using System.ComponentModel;

namespace ConeXion.Core.Models.User
{
    /// <summary>
    /// View model for visualizing a user's information.
    /// </summary>
    public class UserServiceModel
    {
        [Description("User's Id.")]
        public string UserId { get; init; } = null!;

        [Description("User's Email.")]
        public string Email { get; init; } = null!;

        [Description("User's Username.")]
        public string UserName { get; init; } = null!;
    }
}