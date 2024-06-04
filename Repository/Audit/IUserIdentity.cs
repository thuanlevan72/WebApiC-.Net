using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Audit
{
    public interface IUserIdentity<TUserKey> where TUserKey : struct
    {
        TUserKey UserId { get; }
        string UserName { get; }
        List<string> Privileges { get; }
        bool IsAdmin { get; }
    }
}
