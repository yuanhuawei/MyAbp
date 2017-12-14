using System.Threading.Tasks;
using Abp.Application.Services;
using CardCloud.Sessions.Dto;

namespace CardCloud.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
