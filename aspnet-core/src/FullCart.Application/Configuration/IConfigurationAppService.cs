using System.Threading.Tasks;
using FullCart.Configuration.Dto;

namespace FullCart.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
