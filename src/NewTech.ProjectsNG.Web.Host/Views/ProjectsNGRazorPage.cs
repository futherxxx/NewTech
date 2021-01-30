using Abp.AspNetCore.Mvc.Views;

namespace NewTech.ProjectsNG.Web.Views
{
    public abstract class ProjectsNGRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected ProjectsNGRazorPage()
        {
            LocalizationSourceName = ProjectsNGConsts.LocalizationSourceName;
        }
    }
}
