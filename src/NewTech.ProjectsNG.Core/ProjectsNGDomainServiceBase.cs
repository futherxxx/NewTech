using Abp.Domain.Services;

namespace NewTech.ProjectsNG
{
    public abstract class ProjectsNGDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected ProjectsNGDomainServiceBase()
        {
            LocalizationSourceName = ProjectsNGConsts.LocalizationSourceName;
        }
    }
}
