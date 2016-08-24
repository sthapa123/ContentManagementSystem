using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCMS.Entities.Models.Settings
{
    public class Setting
    {
        [Key]
        public int SettingId { get; set; }
        [Required]
        public string SettingName { get; set; }
        public string SettingValue { get; set; }
    }
}
