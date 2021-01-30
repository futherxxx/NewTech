using Abp.AutoMapper;
using NewTech.ProjectsNG.Sessions.Dto;

namespace NewTech.ProjectsNG.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}