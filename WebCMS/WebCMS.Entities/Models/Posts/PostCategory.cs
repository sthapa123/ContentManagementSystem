using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCMS.Entities.Models.Posts
{
    public class PostCategory
    {
        [Key]
        public int PostCategoryId { get; set; }
        [Required]
        public string PostCategoryName { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
