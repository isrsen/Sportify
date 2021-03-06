using Microsoft.Extensions.Options;
using Terminator.Api.Settings;
using Terminator.Contracts.Api.Settings;

namespace Terminator.Api.Providers.Settings
{
    public class AppSettingsProvider : IAppSettingsProvider
    {
        public IAppSettings AppSettings { get; set; }

        public AppSettingsProvider(IOptions<AppSettings> appSettingsOptions)
        {
            this.AppSettings = appSettingsOptions.Value;
        }
    }
}
