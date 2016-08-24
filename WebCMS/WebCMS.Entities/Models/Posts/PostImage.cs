using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCMS.Entities.Models.Generic;

namespace WebCMS.Entities.Models.Posts
{
    public class PostImage
    {
        [Key]
        public int PostImageId { get; set; }
        public PostImageType PostImageType { get; set; }
        [ForeignKey("Post")]
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
        [ForeignKey("Image")]
        public int ImageId { get; set; }
        public virtual Image Image { get; set; }
    }
}
