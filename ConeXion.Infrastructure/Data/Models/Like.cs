using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static ConeXion.Infrastructure.Data.Constants.GlobalConstants;
using System.ComponentModel;

namespace ConeXion.Infrastructure.Data.Models
{
    /// <summary>
    /// Database model for likes.
    /// </summary>
    public class Like
    {
        [Required]
        [Description("Id of the post that was liked")]
        public int? PostID { get; set; }

        [ForeignKey(nameof(PostID))]

        public Post Post { get; set; } = null!;


        [Required]
        [Description("Id of the user that left the like.")]
        public string UserID { get; set; }

        [ForeignKey(nameof(UserID))]

        public User User { get; set; } = null!;



    }
}