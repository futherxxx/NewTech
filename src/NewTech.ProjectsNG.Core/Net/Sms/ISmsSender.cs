using System.Threading.Tasks;

namespace NewTech.ProjectsNG.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}