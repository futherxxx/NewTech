using Abp;

namespace NewTech.ProjectsNG
{
    /// <summary>
    /// This class can be used as a base class for services in this application.
    /// It has some useful objects property-injected and has some basic methods most of services may need to.
    /// It's suitable for non domain nor application service classes.
    /// For domain services inherit <see cref="ProjectsNGDomainServiceBase"/>.
    /// For application services inherit ProjectsNGAppServiceBase.
    /// </summary>
    public abstract class ProjectsNGServiceBase : AbpServiceBase
    {
        protected ProjectsNGServiceBase()
        {
            LocalizationSourceName = ProjectsNGConsts.LocalizationSourceName;
        }
    }
}