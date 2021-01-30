using System.Collections.Generic;
using NewTech.ProjectsNG.Authorization.Users.Dto;
using NewTech.ProjectsNG.Dto;

namespace NewTech.ProjectsNG.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}