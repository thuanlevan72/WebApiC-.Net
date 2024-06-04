using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models.BaseEntitys
{
    public class BaseEntity
    {
        [Column("CreateAt")]
        public DateTime CreateAt { get; set; }
        [Column("UpdateAt")]
        public DateTime? UpdateAt { get; set; }
    }
}
