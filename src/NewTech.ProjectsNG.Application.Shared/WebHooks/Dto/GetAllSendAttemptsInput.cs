using NewTech.ProjectsNG.Dto;

namespace NewTech.ProjectsNG.WebHooks.Dto
{
    public class GetAllSendAttemptsInput : PagedInputDto
    {
        public string SubscriptionId { get; set; }
    }
}
