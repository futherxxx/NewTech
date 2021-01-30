using System.Threading.Tasks;
using Abp.Application.Services;
using NewTech.ProjectsNG.Sessions.Dto;

namespace NewTech.ProjectsNG.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
