using Microsoft.AspNetCore.Antiforgery;

namespace NewTech.ProjectsNG.Web.Controllers
{
    public class AntiForgeryController : ProjectsNGControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
