using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCMS.Entities.Models.PageBuilder
{
    public class PageComponentType
    {
        [Key]
        public int PageComponentTypeId { get; set; }

        [Required]
        public string PageComponentTypeName { get; set; }

        [Required]
        public PageComponentTypeCategory PageComponentTypeCategory { get; set; }

        [Required]
        public string PageComponentTypeDescription { get; set; }

        [Required]
        public string PageComponentBody { get; set; }
    }
}
