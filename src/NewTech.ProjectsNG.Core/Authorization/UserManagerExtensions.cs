using System.Threading.Tasks;
using Abp.Authorization.Users;
using NewTech.ProjectsNG.Authorization.Users;

namespace NewTech.ProjectsNG.Authorization
{
    public static class UserManagerExtensions
    {
        public static async Task<User> GetAdminAsync(this UserManager userManager)
        {
            return await userManager.FindByNameAsync(AbpUserBase.AdminUserName);
        }
    }
}
