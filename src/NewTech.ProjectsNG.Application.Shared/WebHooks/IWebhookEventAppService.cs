using System.Threading.Tasks;
using Abp.Webhooks;

namespace NewTech.ProjectsNG.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
