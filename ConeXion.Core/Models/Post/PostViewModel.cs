using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
