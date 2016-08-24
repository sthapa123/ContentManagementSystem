using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCMS.Entities.Models.Copy
{
    public class Copy
    {
        [Key]
        public int CopyId { get; set; }
        [Required]
        public string CopyName { get; set; }
        public string CopyBody { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
        [Required]
        public DateTime DateUpdate { get; set; }
    }
}
