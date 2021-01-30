using System.Collections.Generic;
using Abp.Application.Services.Dto;
using NewTech.ProjectsNG.Authorization.Permissions.Dto;
using NewTech.ProjectsNG.Web.Areas.App.Models.Common;

namespace NewTech.ProjectsNG.Web.Areas.App.Models.Roles
{
    public class RoleListViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}