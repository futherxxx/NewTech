using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using NewTech.ProjectsNG.Editions.Dto;
using NewTech.ProjectsNG.Web.Areas.App.Models.Common;

namespace NewTech.ProjectsNG.Web.Areas.App.Models.Editions
{
    [AutoMapFrom(typeof(GetEditionEditOutput))]
    public class EditEditionModalViewModel : GetEditionEditOutput, IFeatureEditViewModel
    {
        public bool IsEditMode => Edition.Id.HasValue;

        public IReadOnlyList<ComboboxItemDto> EditionItems { get; set; }

        public IReadOnlyList<ComboboxItemDto> FreeEditionItems { get; set; }
    }
}