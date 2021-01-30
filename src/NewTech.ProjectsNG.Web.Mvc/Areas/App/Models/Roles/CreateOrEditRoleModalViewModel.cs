using Abp.AutoMapper;
using NewTech.ProjectsNG.Authorization.Roles.Dto;
using NewTech.ProjectsNG.Web.Areas.App.Models.Common;

namespace NewTech.ProjectsNG.Web.Areas.App.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class CreateOrEditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool IsEditMode => Role.Id.HasValue;
    }
}