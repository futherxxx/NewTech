using System.Threading.Tasks;

namespace NewTech.ProjectsNG.Security
{
    public interface IPasswordComplexitySettingStore
    {
        Task<PasswordComplexitySetting> GetSettingsAsync();
    }
}
