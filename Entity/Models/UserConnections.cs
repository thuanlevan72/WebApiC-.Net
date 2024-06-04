using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    [Table("UserConnections")]
    public class UserConnections
    {
        [Key]
        [Column("user_connection_id")] 
        public int UserConnectionId { get; set; }

        [Column("ConnectionId")]
        public string ConnectionId { get; set; }

        [Column("NickName")]
        public string NickName { get; set; }
    }
}
