using Abp.Application.Services;
using Abp.Application.Services.Dto;
using NewTech.ProjectsNG.Authorization.Permissions.Dto;

namespace NewTech.ProjectsNG.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
