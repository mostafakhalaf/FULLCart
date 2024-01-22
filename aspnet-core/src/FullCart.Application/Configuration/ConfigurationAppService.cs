using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using FullCart.Configuration.Dto;

namespace FullCart.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : FullCartAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
