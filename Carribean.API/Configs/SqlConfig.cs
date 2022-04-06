using Carribean.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Carribean.API.Configs
{
    public static class SqlConfig
    {
        public static IServiceCollection SettingSqlServerDbContext(this IServiceCollection services, string connection)
        {
            services.AddDbContext<Context>(options => options.UseSqlServer(connection));

            return services;
        }
    }
}
