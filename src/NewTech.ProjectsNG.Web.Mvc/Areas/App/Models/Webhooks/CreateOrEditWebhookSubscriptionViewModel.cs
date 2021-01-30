using Abp.Application.Services.Dto;
using Abp.Webhooks;
using NewTech.ProjectsNG.WebHooks.Dto;

namespace NewTech.ProjectsNG.Web.Areas.App.Models.Webhooks
{
    public class CreateOrEditWebhookSubscriptionViewModel
    {
        public WebhookSubscription WebhookSubscription { get; set; }

        public ListResultDto<GetAllAvailableWebhooksOutput> AvailableWebhookEvents { get; set; }
    }
}
