using NewTech.ProjectsNG.EntityFrameworkCore;

namespace NewTech.ProjectsNG.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly ProjectsNGDbContext _context;

        public InitialHostDbBuilder(ProjectsNGDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
