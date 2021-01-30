using System.Threading.Tasks;
using Abp.Application.Services;
using NewTech.ProjectsNG.Configuration.Host.Dto;

namespace NewTech.ProjectsNG.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
