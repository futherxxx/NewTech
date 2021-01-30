using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace NewTech.ProjectsNG.Localization
{
    public static class ProjectsNGLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(
                    ProjectsNGConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ProjectsNGLocalizationConfigurer).GetAssembly(),
                        "NewTech.ProjectsNG.Localization.ProjectsNG"
                    )
                )
            );
        }
    }
}