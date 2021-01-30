using NewTech.ProjectsNG.Editions.Dto;

namespace NewTech.ProjectsNG.MultiTenancy.Payments.Dto
{
    public class PaymentInfoDto
    {
        public EditionSelectDto Edition { get; set; }

        public decimal AdditionalPrice { get; set; }

        public bool IsLessThanMinimumUpgradePaymentAmount()
        {
            return AdditionalPrice < ProjectsNGConsts.MinimumUpgradePaymentAmount;
        }
    }
}
