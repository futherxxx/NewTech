using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using NewTech.ProjectsNG.Authorization;
using NewTech.ProjectsNG.DashboardCustomization;
using NewTech.ProjectsNG.Web.DashboardCustomization;
using System.Threading.Tasks;

namespace NewTech.ProjectsNG.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize(AppPermissions.Pages_Tenant_Dashboard)]
    public class TenantDashboardController : CustomizableDashboardControllerBase
    {
        public TenantDashboardController(DashboardViewConfiguration dashboardViewConfiguration, 
            IDashboardCustomizationAppService dashboardCustomizationAppService) 
            : base(dashboardViewConfiguration, dashboardCustomizationAppService)
        {

        }

        public async Task<ActionResult> Index()
        {
            return await GetView(ProjectsNGDashboardCustomizationConsts.DashboardNames.DefaultTenantDashboard);
        }
    }
}