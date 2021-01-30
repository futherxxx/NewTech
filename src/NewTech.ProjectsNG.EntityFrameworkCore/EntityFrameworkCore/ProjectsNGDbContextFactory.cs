using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using NewTech.ProjectsNG.Configuration;
using NewTech.ProjectsNG.Web;

namespace NewTech.ProjectsNG.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ProjectsNGDbContextFactory : IDesignTimeDbContextFactory<ProjectsNGDbContext>
    {
        public ProjectsNGDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ProjectsNGDbContext>();
            var configuration = AppConfigurations.Get(
                WebContentDirectoryFinder.CalculateContentRootFolder(),
                addUserSecrets: true
            );

            ProjectsNGDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ProjectsNGConsts.ConnectionStringName));

            return new ProjectsNGDbContext(builder.Options);
        }
    }
}