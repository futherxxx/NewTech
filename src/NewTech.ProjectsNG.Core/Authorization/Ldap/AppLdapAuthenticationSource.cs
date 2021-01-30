using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using NewTech.ProjectsNG.Authorization.Users;
using NewTech.ProjectsNG.MultiTenancy;

namespace NewTech.ProjectsNG.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}