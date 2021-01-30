using System.Collections.Generic;
using NewTech.ProjectsNG.Authorization.Permissions.Dto;

namespace NewTech.ProjectsNG.Authorization.Roles.Dto
{
    public class GetRoleForEditOutput
    {
        public RoleEditDto Role { get; set; }

        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}