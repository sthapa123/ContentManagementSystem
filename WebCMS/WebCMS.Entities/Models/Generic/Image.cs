using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCMS.Entities.Models.Generic
{
    public class Image
    {
        [Key]
        public int ImageId { get; set; }
        [Required]
        public ImageCategory ImageCategory { get; set; }
        public string ImagePath { get; set; }
    }
}
