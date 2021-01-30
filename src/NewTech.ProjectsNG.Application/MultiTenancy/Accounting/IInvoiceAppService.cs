using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using NewTech.ProjectsNG.MultiTenancy.Accounting.Dto;

namespace NewTech.ProjectsNG.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
