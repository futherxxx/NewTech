using Abp.Application.Services;
using NewTech.ProjectsNG.Dto;
using NewTech.ProjectsNG.Logging.Dto;

namespace NewTech.ProjectsNG.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
