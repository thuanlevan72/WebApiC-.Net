using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Audits
{
    [Table("AuditLog")]
    public class AuditLog
    {
        [Key]
        [Column("LogId")]
        public int Id { get; set; }
        /// <summary>
        /// id của người tác động
        /// </summary>
        [Column("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// hành động của nó 
        /// </summary>
        [Column("Action")]
        public string Action { get; set; }
        /// <summary>
        /// bảng bị thay đổi
        /// </summary>
        [Column("TableName")]
        public string TableName { get; set; }
        /// <summary>
        /// Id trường bị thay đổi
        /// </summary>
        [Column("RecordId")]
        public int RecordId { get; set; }
        /// <summary>
        /// thời gian thay đổi
        /// </summary>
        [Column("Timestamp")]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// giá trị cũ
        /// </summary>
        [Column("OldValues")]
        public string OldValues { get; set; }
        /// <summary>
        /// giá trị mới 
        /// </summary>
        [Column("NewValues")]
        public string NewValues { get; set; }
    }
}
