using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using NewTech.ProjectsNG.Dto;

namespace NewTech.ProjectsNG.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
