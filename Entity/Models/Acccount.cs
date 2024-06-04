using Entity.Models.enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models
{
    [Table("account")]
    public class Acccount
    {
        [Key]
        [Column("accountId")]
        public int accountId { get; set; }

        [Required]
        [StringLength(255)]
        [Column("userName")]
        public string userName { get; set; }

        [Required]
        [StringLength(255)]
        [Column("avatar")]
        public string avatar { get; set; }

        [Required]
        [StringLength(255)]
        [Column("password")]
        public string hashPassword { get; set; }

        [Required]
        [Column("status")]
        public EStatus status { get; set; }

        [Required]
        [Column("DecentralizationId")]
        public int DecentralizationId { get; set; }

        [Column("ResetPasswordToken")]
        public string ResetPasswordToken { get; set; }

        [Column("ResetPasswordTokenExpiry")]
        public DateTime? ResetPasswordTokenExpiry { get; set; }

        [Required]
        public DateTime createdAt { get; set; }

        [Required]
        public DateTime updateAt { get; set; }

        [ForeignKey("DecentralizationId")]
        public virtual Decentralization Decentralization { get; set; }
    }
}
