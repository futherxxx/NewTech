using Abp.AutoMapper;
using NewTech.ProjectsNG.MultiTenancy.Dto;

namespace NewTech.ProjectsNG.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(RegisterTenantOutput))]
    public class TenantRegisterResultViewModel : RegisterTenantOutput
    {
        public string TenantLoginAddress { get; set; }
    }
}