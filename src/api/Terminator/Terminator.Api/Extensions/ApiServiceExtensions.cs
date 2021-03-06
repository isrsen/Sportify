using Microsoft.Extensions.DependencyInjection;
using Terminator.Api.Providers.Settings;
using Terminator.Contracts.Api.Settings;

namespace Terminator.Api.Extensions
{
    public static class ApiServiceExtensions
    {
        public static void AddApiServices(this IServiceCollection services)
        {
            services.AddTransient<IAppSettingsProvider, AppSettingsProvider>();
        }
    }
}
