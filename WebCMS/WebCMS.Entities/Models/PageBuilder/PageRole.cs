using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCMS.Entities.Models.Authentication;

namespace WebCMS.Entities.Models.PageBuilder
{
    public class PageRole
    {
        [Key]
        public int PageRoleId { get; set; }

        [ForeignKey("Page")]
        public int PageId { get; set; }

        public virtual Page Page { get; set; }

        [ForeignKey("Role")]
        public int RoleId { get; set; }

        public virtual Role Role { get; set; }
    }
}
