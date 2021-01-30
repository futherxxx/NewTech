using System.Threading.Tasks;
using NewTech.ProjectsNG.Authorization.Users;

namespace NewTech.ProjectsNG.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
