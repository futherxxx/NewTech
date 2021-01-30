using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace NewTech.ProjectsNG.Startup
{
    [DependsOn(typeof(ProjectsNGCoreModule))]
    public class ProjectsNGGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProjectsNGGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}