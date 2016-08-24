using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCMS.Entities.Models.PageBuilder
{
    public class Page
    {
        [Key]
        public int PageId { get; set; }
        [Required]
        public string PageName { get;set; }
        public string PageArea { get; set; }
        [Required]
        public string PageController { get; set; }
        [Required]
        public string PageAction { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
        [Required]
        public DateTime DateUpdated { get; set; }
        public virtual ICollection<PageSection> PageSections { get; set; }
        public virtual ICollection<PageRole> PageRoles { get; set; }
    }
}
