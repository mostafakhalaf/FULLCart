using System.Threading.Tasks;
using Abp.Application.Services;
using FullCart.Authorization.Accounts.Dto;

namespace FullCart.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
