using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Terminator.Database.Contexts;

namespace Terminator.Database.Extensions
{
    public static class InfrastructureDatabaseServiceExtensions
    {
        public static void AddInfrastructureDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TerminatorDbContext>(opt =>
                opt.UseSqlServer(configuration.GetConnectionString("TerminatorDbContextConnection")));

            services
                .AddIdentityCore<IdentityUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireDigit = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                })
                .AddEntityFrameworkStores<TerminatorDbContext>();
        }
    }
}
