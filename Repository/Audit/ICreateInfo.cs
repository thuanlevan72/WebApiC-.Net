using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Audit
{
    public interface ICreateInfo<TUser, TUserKey>
       where TUser : class
       where TUserKey : struct
    {
        //DateTime? CreatedDate { get; set; }
        //TUserKey? CreatedUserId { get; set; }
        //TUser CreatedUser { get; set; }

        DateTime CreatedAt { get; set; }
        TUserKey? CreatedUserId { get; set; }
        TUser CreatedUser { get; set; }
    }
}
