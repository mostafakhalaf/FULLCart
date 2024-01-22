using Abp.Application.Services;
using FullCart.MultiTenancy.Dto;

namespace FullCart.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

