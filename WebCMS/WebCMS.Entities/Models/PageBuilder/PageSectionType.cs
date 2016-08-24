using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCMS.Entities.Models.PageBuilder
{
    public class PageSectionType
    {
        [Key]
        public int PageSectionTypeId { get; set; }

        [Required]
        public string PageSectionTypeName { get; set; }

        [Required]
        public string PageSectionTypeBody { get; set; }

        public PageSectionTypeCategory PageSectionTypeCategory { get; set; }

        public int PageSectionTypeOrder { get; set; }
    }
}
