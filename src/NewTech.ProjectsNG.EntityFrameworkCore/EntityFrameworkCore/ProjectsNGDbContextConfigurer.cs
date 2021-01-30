using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace NewTech.ProjectsNG.EntityFrameworkCore
{
    public static class ProjectsNGDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ProjectsNGDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ProjectsNGDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}