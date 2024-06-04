using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Audit
{
    public interface IUpdateInfo<TUser, TUserKey>
       where TUser : class
       where TUserKey : struct
    {
        DateTime? LastUpdatedDate { get; set; }
        TUserKey? LastUpdatedUserId { get; set; }
        TUser LastUpdatedUser { get; set; }
    }
}
