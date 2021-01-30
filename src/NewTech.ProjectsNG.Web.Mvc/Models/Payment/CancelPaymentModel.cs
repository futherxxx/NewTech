using NewTech.ProjectsNG.MultiTenancy.Payments;

namespace NewTech.ProjectsNG.Web.Models.Payment
{
    public class CancelPaymentModel
    {
        public string PaymentId { get; set; }

        public SubscriptionPaymentGatewayType Gateway { get; set; }
    }
}