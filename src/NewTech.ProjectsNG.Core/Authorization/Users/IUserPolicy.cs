using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace NewTech.ProjectsNG.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
