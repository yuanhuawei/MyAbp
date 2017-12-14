using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using CardCloud.Configuration.Dto;

namespace CardCloud.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CardCloudAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
