using System.Collections.Generic;
using NewTech.ProjectsNG.Authorization.Permissions.Dto;

namespace NewTech.ProjectsNG.Web.Areas.App.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}