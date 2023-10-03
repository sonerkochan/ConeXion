using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static ConeXion.Infrastructure.Data.Constants.GlobalConstants;
using System.ComponentModel;

namespace ConeXion.Infrastructure.Data.Models
{
    /// <summary>
    /// Database model for posts.
    /// </summary>
    public class Post
    {
        [Key]
        [Description("Id of the post.")]
        public int Id { get; set; }

        [Required]
        [Description("Text content of the post.")]
        public string TextContent { get; set; } = null!;

        [Required]
        [Description("Link to the image of the product.")]
        public string ImageData { get; set; } = null!;


        [Description("Id of the user that posted the post.")]
        public string UserID { get; set; }

        [ForeignKey(nameof(UserID))]

        public User User { get; set; } = null!;

    }
}