using Abp.Authorization;
using NewTech.ProjectsNG.Authorization.Roles;
using NewTech.ProjectsNG.Authorization.Users;

namespace NewTech.ProjectsNG.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
