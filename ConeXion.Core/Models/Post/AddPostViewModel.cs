using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConeXion.Core.Models.Post
{
    public class AddPostViewModel
    {

        [Required]
        [Description("Text content of the post.")]
        public string TextContent { get; set; } = null!;

        [Description("Link to the image of the product.")]
        public string? ImageData { get; set; } = null!;

        [Description("Id of the user that posted the post.")]
        public string? UserID { get; set; }
    }
}
