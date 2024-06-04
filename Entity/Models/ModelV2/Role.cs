using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models.ModelV2
{
    [Table("Role")]
    public class Role
    {
        [Key,Column("RoleId")]
        public int RoleId { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set;}
        public virtual ICollection<RolePermission> RolePermissions { get; set;}
    }
}
