using Abp.Authorization;
using FullCart.Authorization.Roles;
using FullCart.Authorization.Users;

namespace FullCart.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
