using System.ComponentModel.DataAnnotations;

namespace NewTech.ProjectsNG.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}