using System.Collections.Generic;

namespace NewTech.ProjectsNG.DynamicEntityParameters
{
    public interface IDynamicEntityParameterDefinitionAppService
    {
        List<string> GetAllAllowedInputTypeNames();

        List<string> GetAllEntities();
    }
}
