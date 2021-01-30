using Abp.AutoMapper;
using NewTech.ProjectsNG.Localization.Dto;

namespace NewTech.ProjectsNG.Web.Areas.App.Models.Languages
{
    [AutoMapFrom(typeof(GetLanguageForEditOutput))]
    public class CreateOrEditLanguageModalViewModel : GetLanguageForEditOutput
    {
        public bool IsEditMode => Language.Id.HasValue;
    }
}