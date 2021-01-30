using System.Threading.Tasks;

namespace NewTech.ProjectsNG.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}