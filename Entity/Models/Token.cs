using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models
{
    [Table("token")]
    public class Token
    {
        [Key]
        [Column("tokenId")]
        public int TokenId { get; set; }
                    
        [Required]
        [Column("token_value")]
        [MaxLength(500)]
        public string TokenValue { get; set; }

        [Column("create_at")]
        [Required]
        public DateTime CreateAt { get; set; }

        [Column("accountId")]
        [Required]
        public int AccountId { get; set; }

        [ForeignKey("AccountId")]
        public virtual Acccount acccount { get; set; }
    }
}
