using Abp.AutoMapper;
using NewTech.ProjectsNG.Authorization.Users;
using NewTech.ProjectsNG.Authorization.Users.Dto;
using NewTech.ProjectsNG.Web.Areas.App.Models.Common;

namespace NewTech.ProjectsNG.Web.Areas.App.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; set; }
    }
}