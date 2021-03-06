using Terminator.Contracts.Api.Settings;

namespace Terminator.Api.Settings
{
    public class AppSettings : IAppSettings
    {
        public string JwtSecret { get; set; }
    }
}
