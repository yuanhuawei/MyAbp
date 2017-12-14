using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CardCloud.Roles.Dto;
using CardCloud.Users.Dto;

namespace CardCloud.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}