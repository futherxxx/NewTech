using Abp.Auditing;
using NewTech.ProjectsNG.Configuration.Dto;

namespace NewTech.ProjectsNG.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}