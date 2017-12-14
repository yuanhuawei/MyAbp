using System.Collections.Generic;
using CardCloud.Roles.Dto;
using CardCloud.Users.Dto;

namespace CardCloud.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}