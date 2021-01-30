using Abp.Events.Bus;

namespace NewTech.ProjectsNG.MultiTenancy
{
    public class RecurringPaymentsEnabledEventData : EventData
    {
        public int TenantId { get; set; }
    }
}