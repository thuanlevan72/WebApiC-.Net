using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models.BaseEntitys
{
    public class SortDelete
    {
        [Column("SortDelete")]
        public bool IsDelete { get; set; }
    }
}
