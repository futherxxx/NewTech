using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewTech.ProjectsNG.Web.Areas.App.Models.Layout;
using NewTech.ProjectsNG.Web.Session;
using NewTech.ProjectsNG.Web.Views;

namespace NewTech.ProjectsNG.Web.Areas.App.Views.Shared.Themes.Theme6.Components.AppTheme6Brand
{
    public class AppTheme6BrandViewComponent : ProjectsNGViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppTheme6BrandViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(headerModel);
        }
    }
}
