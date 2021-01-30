using System.Collections.Generic;
using Abp.Localization;
using NewTech.ProjectsNG.Install.Dto;

namespace NewTech.ProjectsNG.Web.Models.Install
{
    public class InstallViewModel
    {
        public List<ApplicationLanguage> Languages { get; set; }

        public AppSettingsJsonDto AppSettingsJson { get; set; }
    }
}
