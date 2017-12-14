using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CardCloud.MultiTenancy.Dto;

namespace CardCloud.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
