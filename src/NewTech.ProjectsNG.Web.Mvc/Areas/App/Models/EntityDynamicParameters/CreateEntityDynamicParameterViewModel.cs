using System.Collections.Generic;
using NewTech.ProjectsNG.DynamicEntityParameters.Dto;

namespace NewTech.ProjectsNG.Web.Areas.App.Models.EntityDynamicParameters
{
    public class CreateEntityDynamicParameterViewModel
    {
        public string EntityFullName { get; set; }

        public List<string> AllEntities { get; set; }

        public List<DynamicParameterDto> DynamicParameters { get; set; }
    }
}
