using Abp.Configuration;
using Abp.Net.Mail;
using Abp.Net.Mail.Smtp;
using Abp.Runtime.Security;

namespace NewTech.ProjectsNG.Net.Emailing
{
    public class ProjectsNGSmtpEmailSenderConfiguration : SmtpEmailSenderConfiguration
    {
        public ProjectsNGSmtpEmailSenderConfiguration(ISettingManager settingManager) : base(settingManager)
        {

        }

        public override string Password => SimpleStringCipher.Instance.Decrypt(GetNotEmptySettingValue(EmailSettingNames.Smtp.Password));
    }
}