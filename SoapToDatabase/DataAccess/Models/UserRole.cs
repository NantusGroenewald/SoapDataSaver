using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class UserRole
    {
        [Key]
        public int UserRoleId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public string RoleName { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
