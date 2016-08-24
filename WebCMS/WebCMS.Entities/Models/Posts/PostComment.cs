using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCMS.Entities.Models.Authentication;

namespace WebCMS.Entities.Models.Posts
{
    public class PostComment
    {
        [Key]
        public int PostCommentId { get; set; }
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }

        public virtual User User { get; set; }
        [Required]
        [ForeignKey("Post")]
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
        [Required]
        public string CommentBody { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
    }
}
