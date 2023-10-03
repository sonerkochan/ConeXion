using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConeXion.Infrastructure.Data.Models
{
    /// <summary>
    /// Extended user model for the database.
    /// </summary>
    public class User : IdentityUser
    {
        [Description("Flag indicating whether the user profile is still active")]
        public bool IsActive { get; set; } = true;

        [Description("Bio of the user")]
        public string Bio { get; set; }


        [Description("List of the friends of the user.")]
        public ICollection<User> Friends { get; set; } = new List<User>();


        [Description("List of the posts of the user.")]
        public ICollection<Post> Posts { get; set; } = new List<Post>();


        [Description("List of the likes of the user.")]
        public ICollection<Like> Likes { get; set; } = new List<Like>();


        [Description("List of the comments of the user.")]
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}