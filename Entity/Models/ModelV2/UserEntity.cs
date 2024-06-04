using Entity.Models.BaseEntitys;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;

namespace Entity.Models.ModelV2
{
    [Table("UserClient")]
    public class UserEntity: BaseEntity
    {
        [Key]
        [Column("UserId")]
        public int UserEntityId { get; set; }
        [Column("UserName")]
        public string UserName { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [Column("HashPassword")]
        public string HashPassword { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set;}
    }
}