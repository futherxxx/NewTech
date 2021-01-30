using System.Collections.Generic;
using NewTech.ProjectsNG.Authorization.Permissions.Dto;

namespace NewTech.ProjectsNG.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}