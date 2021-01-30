using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using NewTech.ProjectsNG.Common.Dto;
using NewTech.ProjectsNG.Editions.Dto;

namespace NewTech.ProjectsNG.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}