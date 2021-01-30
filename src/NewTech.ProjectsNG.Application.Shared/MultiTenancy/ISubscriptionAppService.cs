using System.Threading.Tasks;
using Abp.Application.Services;

namespace NewTech.ProjectsNG.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
