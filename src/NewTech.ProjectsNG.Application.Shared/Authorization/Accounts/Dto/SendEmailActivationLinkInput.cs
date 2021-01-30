using System.ComponentModel.DataAnnotations;

namespace NewTech.ProjectsNG.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}