using System.Collections.Generic;

namespace NewTech.ProjectsNG.MultiTenancy.Payments
{
    public interface IPaymentGatewayStore
    {
        List<PaymentGatewayModel> GetActiveGateways();
    }
}
