using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models.ModelV2
{
    [Table("Permission")]
    public class Permission
    {
        [Key, Column("permission_id")]
        public int PermissionId { get; set; }
        [Column("name")]
        public string PermissionName { get; set; }  
        public virtual ICollection<RolePermission> RolePermissions { get; set; }
    }
}
