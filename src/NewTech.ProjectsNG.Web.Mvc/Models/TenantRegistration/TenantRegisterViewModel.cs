using NewTech.ProjectsNG.Editions;
using NewTech.ProjectsNG.Editions.Dto;
using NewTech.ProjectsNG.MultiTenancy.Payments;
using NewTech.ProjectsNG.Security;
using NewTech.ProjectsNG.MultiTenancy.Payments.Dto;

namespace NewTech.ProjectsNG.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }
    }
}
