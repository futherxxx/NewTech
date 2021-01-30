using Abp.AutoMapper;
using NewTech.ProjectsNG.MultiTenancy.Dto;

namespace NewTech.ProjectsNG.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(EditionsSelectOutput))]
    public class EditionsSelectViewModel : EditionsSelectOutput
    {
    }
}
