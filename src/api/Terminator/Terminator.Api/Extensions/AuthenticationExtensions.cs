using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Terminator.Contracts.Api.Settings;
using Terminator.Contracts.Services;

namespace Terminator.Api.Extensions
{
    public static class AuthenticationExtensions
    {
        public static void AddAuthCustom(this IServiceCollection services)
        {
            services.AddAuthentication();

            services.AddOptions<JwtBearerOptions>(JwtBearerDefaults.AuthenticationScheme)
                .Configure<IAppSettingsProvider>((options, appSettingsProvider) =>
                {
                    options.RequireHttpsMetadata = false;
                    options.SaveToken = true;
                    options.TokenValidationParameters =
                        TokenOptionsProvider.GetValidationParameters(appSettingsProvider.AppSettings.JwtSecret);
                });
        }
    }
}
