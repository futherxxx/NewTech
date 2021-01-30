using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using NewTech.ProjectsNG.EntityFrameworkCore;

namespace NewTech.ProjectsNG.HealthChecks
{
    public class ProjectsNGDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public ProjectsNGDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("ProjectsNGDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("ProjectsNGDbContext could not connect to database"));
        }
    }
}
