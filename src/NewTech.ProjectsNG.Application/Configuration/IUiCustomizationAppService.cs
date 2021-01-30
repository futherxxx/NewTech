using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using NewTech.ProjectsNG.Configuration.Dto;

namespace NewTech.ProjectsNG.Configuration
{
    public interface IUiCustomizationSettingsAppService : IApplicationService
    {
        Task<List<ThemeSettingsDto>> GetUiManagementSettings();

        Task UpdateUiManagementSettings(ThemeSettingsDto settings);

        Task UpdateDefaultUiManagementSettings(ThemeSettingsDto settings);

        Task UseSystemDefaultSettings();
    }
}
