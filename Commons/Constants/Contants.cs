using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.Constants
{
    public class Contants
    {
        public static class RoleContants
        {
            public const string USER = "User";
            public const string MANAGER = "Manager";
            public const string ADMIN = "Admin";
            public const string USER_MANAGER = $"{MANAGER},{USER}";
            public const string ADMIN_MANAGER = $"{MANAGER},{ADMIN}";
        }
        public static class PermissionContants
        {
            public const string DEVELOPMENT = "DEVELOPMENT";
            public const string DELETE = "DELETE";
            public const string UPDATE = "UPDATE";
            public const string READ = "READ";
            public const string CREATE = "CREATE";
        }
    }
}
