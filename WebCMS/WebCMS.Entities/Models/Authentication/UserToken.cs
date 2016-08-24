using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCMS.Entities.Models.Authentication
{
    public class UserToken
    {
        [Key]
        public int UserTokenId { get; set; }
        [Required]
        public UserTokenType UserTokenType { get; set; }
        [Required]
        public string Token { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
        public DateTime? DateRedeemed { get; set; }
    }
}
