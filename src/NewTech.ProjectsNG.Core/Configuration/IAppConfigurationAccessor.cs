using Microsoft.Extensions.Configuration;

namespace NewTech.ProjectsNG.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
