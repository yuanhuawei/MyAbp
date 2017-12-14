using Abp.Authorization;
using CardCloud.Authorization.Roles;
using CardCloud.Authorization.Users;

namespace CardCloud.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
