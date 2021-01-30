using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using NewTech.ProjectsNG.Web.Controllers;

namespace NewTech.ProjectsNG.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize]
    public class WelcomeController : ProjectsNGControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}