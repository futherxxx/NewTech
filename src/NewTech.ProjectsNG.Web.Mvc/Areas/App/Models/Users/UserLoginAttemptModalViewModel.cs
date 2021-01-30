using System.Collections.Generic;
using NewTech.ProjectsNG.Authorization.Users.Dto;

namespace NewTech.ProjectsNG.Web.Areas.App.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}