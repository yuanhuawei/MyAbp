using System.Threading.Tasks;
using Abp.Application.Services;
using CardCloud.Authorization.Accounts.Dto;

namespace CardCloud.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
