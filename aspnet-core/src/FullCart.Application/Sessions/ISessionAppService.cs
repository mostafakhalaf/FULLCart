using System.Threading.Tasks;
using Abp.Application.Services;
using FullCart.Sessions.Dto;

namespace FullCart.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
