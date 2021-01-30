using Abp.Modules;
using Abp.Reflection.Extensions;

namespace NewTech.ProjectsNG
{
    public class ProjectsNGCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProjectsNGCoreSharedModule).GetAssembly());
        }
    }
}