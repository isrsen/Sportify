using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Terminator.Api.Settings;
using Terminator.Contracts.Api.Settings;

namespace Terminator.Api.Extensions
{
    public static class ConfigurationExtensions
    {
        public static void AddConfigurationCustom(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<IAppSettings>(options
                => configuration.GetSection(nameof(AppSettings)).Bind(options));
        }
    }
}
