using System.Collections.Generic;
using NewTech.ProjectsNG.Editions;
using NewTech.ProjectsNG.Editions.Dto;
using NewTech.ProjectsNG.MultiTenancy.Payments;
using NewTech.ProjectsNG.MultiTenancy.Payments.Dto;

namespace NewTech.ProjectsNG.Web.Models.Payment
{
    public class BuyEditionViewModel
    {
        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}
