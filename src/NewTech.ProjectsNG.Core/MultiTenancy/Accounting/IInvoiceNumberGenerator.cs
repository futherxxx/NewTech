using System.Threading.Tasks;
using Abp.Dependency;

namespace NewTech.ProjectsNG.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}