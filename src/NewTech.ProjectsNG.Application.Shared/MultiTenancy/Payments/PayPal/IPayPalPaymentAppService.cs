using System.Threading.Tasks;
using Abp.Application.Services;
using NewTech.ProjectsNG.MultiTenancy.Payments.PayPal.Dto;

namespace NewTech.ProjectsNG.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
