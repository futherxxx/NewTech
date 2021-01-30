using Abp.Modules;
using Abp.Reflection.Extensions;

namespace NewTech.ProjectsNG
{
    [DependsOn(typeof(ProjectsNGCoreSharedModule))]
    public class ProjectsNGApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProjectsNGApplicationSharedModule).GetAssembly());
        }
    }
}