using Abp.AspNetCore.Mvc.ViewComponents;

namespace NewTech.ProjectsNG.Web.Views
{
    public abstract class ProjectsNGViewComponent : AbpViewComponent
    {
        protected ProjectsNGViewComponent()
        {
            LocalizationSourceName = ProjectsNGConsts.LocalizationSourceName;
        }
    }
}