using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NewTech.ProjectsNG.Authorization;

namespace NewTech.ProjectsNG
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(ProjectsNGApplicationSharedModule),
        typeof(ProjectsNGCoreModule)
        )]
    public class ProjectsNGApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProjectsNGApplicationModule).GetAssembly());
        }
    }
}