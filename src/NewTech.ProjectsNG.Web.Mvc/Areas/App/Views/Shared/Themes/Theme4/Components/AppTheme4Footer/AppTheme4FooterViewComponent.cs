using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewTech.ProjectsNG.Web.Areas.App.Models.Layout;
using NewTech.ProjectsNG.Web.Session;
using NewTech.ProjectsNG.Web.Views;

namespace NewTech.ProjectsNG.Web.Areas.App.Views.Shared.Themes.Theme4.Components.AppTheme4Footer
{
    public class AppTheme4FooterViewComponent : ProjectsNGViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppTheme4FooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(footerModel);
        }
    }
}
