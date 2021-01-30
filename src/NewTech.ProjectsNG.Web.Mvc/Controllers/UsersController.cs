using Abp.AspNetCore.Mvc.Authorization;
using NewTech.ProjectsNG.Authorization;
using NewTech.ProjectsNG.Storage;
using Abp.BackgroundJobs;
using Abp.Authorization;

namespace NewTech.ProjectsNG.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}