using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models.ModelV2
{
    [Table("UserRole")]
    public class UserRole
    {
        [Column("UserId")]
        public int UserId { get; set; }
        [Column("RoleId")]
        public int RoleId { get; set; }
        [ForeignKey("UserId")]
        public virtual UserEntity userEntity { get; set; }
        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }
        
    }
}
