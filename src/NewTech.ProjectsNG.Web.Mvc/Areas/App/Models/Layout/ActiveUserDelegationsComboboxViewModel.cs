using System.Collections.Generic;
using NewTech.ProjectsNG.Authorization.Delegation;
using NewTech.ProjectsNG.Authorization.Users.Delegation.Dto;

namespace NewTech.ProjectsNG.Web.Areas.App.Models.Layout
{
    public class ActiveUserDelegationsComboboxViewModel
    {
        public IUserDelegationConfiguration UserDelegationConfiguration { get; set; }
        
        public List<UserDelegationDto> UserDelegations { get; set; }
    }
}
