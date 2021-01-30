using System.Collections.Generic;
using NewTech.ProjectsNG.Authorization.Users.Importing.Dto;
using NewTech.ProjectsNG.Dto;

namespace NewTech.ProjectsNG.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
