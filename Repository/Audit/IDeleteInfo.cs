using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Audit
{
    public interface IDeleteInfo<TUser, TUserKey>
     where TUser : class
     where TUserKey : struct
    {
        DateTime? DeletedDate { get; set; }
        TUserKey? DeletedUserId { get; set; }
        TUser DeletedUser { get; set; }
    }
}
