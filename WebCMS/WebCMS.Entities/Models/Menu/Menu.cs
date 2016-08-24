using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCMS.Entities.Models.Menu
{
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }
        [Required]
        public string MenuName { get; set; }
        public virtual ICollection<MenuItem> MenuItems { get; set; }
    }
}
