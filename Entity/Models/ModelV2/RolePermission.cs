using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models.ModelV2
{
    [Table("RolePermission")]
    public class RolePermission
    {
        [Column("RoleId")]
        public int RoleId { get; set; }
        [Column("PermissionId")]
        public int PermissionId { get; set; }
        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }
        [ForeignKey("PermissionId")]
        public virtual Permission Permission { get; set; }

    }
}
