using System.Threading.Tasks;
using Abp.Application.Services;
using NewTech.ProjectsNG.Install.Dto;

namespace NewTech.ProjectsNG.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}