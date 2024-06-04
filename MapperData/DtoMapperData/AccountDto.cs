using Entity.Models.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperData.DtoMapperData
{
    public class AccountDto
    {
        public int AccountId { get; set; }
        public string UserName { get; set; }
        public string Avatar { get; set; }
        public EStatus Status { get; set; }
        public string AuthorityName { get; set; } // từ Decentralization 
    }
}
