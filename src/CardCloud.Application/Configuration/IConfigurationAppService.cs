using System.Threading.Tasks;
using Abp.Application.Services;
using CardCloud.Configuration.Dto;

namespace CardCloud.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}