using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models
{
    [Table("Decentralization")]
    public class Decentralization
    {
        [Key]
        [Column("DecentralizationId")]
        public int DecentralizationId { get; set; }

        [Required]
        [Column("AuthorityName")]
        public string AuthorityName { get; set; }

        [Required]
        public DateTime createdAt { get; set; }

        [Required]
        public DateTime updateAt { get; set; }


        public virtual Acccount acccount { get; set; }
    }
}
