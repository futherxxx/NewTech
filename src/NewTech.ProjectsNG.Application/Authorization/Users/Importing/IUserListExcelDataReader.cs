using System.Collections.Generic;
using NewTech.ProjectsNG.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace NewTech.ProjectsNG.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
