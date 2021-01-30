using System.Threading.Tasks;
using NewTech.ProjectsNG.Sessions.Dto;

namespace NewTech.ProjectsNG.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
