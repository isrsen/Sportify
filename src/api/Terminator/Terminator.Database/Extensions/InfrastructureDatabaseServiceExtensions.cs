using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Terminator.Contracts.Database.Repositories;
using Terminator.Database.Contexts;
using Terminator.Database.Repositories;

namespace Terminator.Database.Extensions
{
    public static class InfrastructureDatabaseServiceExtensions
    {
        public static void AddInfrastructureDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            AddDbContext(services, configuration);
            AddServices(services);
            AddIdentity(services);
        }

        private static void AddServices(IServiceCollection services)
        {
            services.AddTransient<UserManager<IdentityUser>>();
            services.AddTransient<IUsersRepository, UsersRepository>();
        }

        private static void AddIdentity(IServiceCollection services)
        {
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

        private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TerminatorDbContext>(opt =>
                opt.UseSqlServer(configuration.GetConnectionString("TerminatorDbContextConnection")));
        }
    }
}
