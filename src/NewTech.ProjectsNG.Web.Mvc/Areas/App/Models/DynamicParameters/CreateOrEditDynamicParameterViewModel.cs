using System.Collections.Generic;
using NewTech.ProjectsNG.DynamicEntityParameters.Dto;

namespace NewTech.ProjectsNG.Web.Areas.App.Models.DynamicParameters
{
    public class CreateOrEditDynamicParameterViewModel
    {
        public DynamicParameterDto DynamicParameterDto { get; set; }

        public List<string> AllowedInputTypes { get; set; }
    }
}
