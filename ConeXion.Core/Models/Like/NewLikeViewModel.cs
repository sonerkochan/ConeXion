using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConeXion.Core.Models.Like
{
    public class NewLikeViewModel
    {

        [Description("Id of the post that was liked")]
        public int? PostID { get; set; }


        [Required]
        [Description("Id of the user that left the like.")]
        public string UserID { get; set; }
    }
}
