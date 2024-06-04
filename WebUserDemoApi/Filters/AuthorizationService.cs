using Infrastructure.Data;

namespace WebUserDemoApi.Filters
{
    public class AuthorizationService
    {
        private readonly DbAppContext _context;

        public AuthorizationService(DbAppContext context)
        {
            _context = context;
        }
        public bool HasPermission(int userId, string permissionName)
        {
            var userRoles = _context.UserRoles
                .Where(ur => ur.UserId == userId)
                .Select(ur => ur.RoleId)
                .ToList();

            var rolePermissions = _context.RolePermissions
                .Where(rp => userRoles.Contains(rp.RoleId))
                .Select(rp => rp.Permission)
                .ToList();

            return rolePermissions.Any(p => p.PermissionName == permissionName);
        }
    }
}
