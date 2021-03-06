using Serilog;
using Serilog.Events;

namespace Terminator.Api.Providers.Logger
{
    public static class LoggerConfigurationProvider
    {
        public static ILogger GetLoggerConfiguration()
        {
            return new LoggerConfiguration()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .WriteTo.File("Logs/log-.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
        }
    }
}
