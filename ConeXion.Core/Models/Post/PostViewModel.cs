using System.ComponentModel;
using ConeXion.Infrastructure.Data.Models;

namespace ConeXion.Core.Models.Post
{
    public class PostViewModel
    {
        [Description("Id of the post.")]
        public int Id { get; set; }

        [Description("Text content of the post.")]
        public string TextContent { get; set; } = null!;

        [Description("Link to the image of the product.")]
        public string? ImageData { get; set; } = null!;


        [Description("Id of the user that posted the post.")]
        public string UserID { get; set; }

        [Description("List of likes of the users that liked the post")]
        public ICollection<ConeXion.Infrastructure.Data.Models.Like> UserLikes { get; set; } = new List<ConeXion.Infrastructure.Data.Models.Like>();
    }
}
