using System.Globalization;

namespace NewTech.ProjectsNG.Localization
{
    public interface IApplicationCulturesProvider
    {
        CultureInfo[] GetAllCultures();
    }
}