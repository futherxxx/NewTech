using System.Threading.Tasks;
using Abp.Application.Services;
using NewTech.ProjectsNG.Configuration.Tenants.Dto;

namespace NewTech.ProjectsNG.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
