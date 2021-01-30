using System.Threading.Tasks;
using Abp.Application.Services;
using NewTech.ProjectsNG.Editions.Dto;
using NewTech.ProjectsNG.MultiTenancy.Dto;

namespace NewTech.ProjectsNG.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}