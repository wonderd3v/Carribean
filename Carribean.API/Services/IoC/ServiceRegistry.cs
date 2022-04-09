using Carribean.API.Services;

namespace Carribean.API.IoC
{
    public static class ServiceRegistry
    {
        public static void AddServiceRegistry(this IServiceCollection services)
        {
            services.AddTransient<IMovieService, MovieService>();
            services.AddTransient<ISeatsService, SeatsService>();
            services.AddTransient<ITicketService, TicketServices>();
            services.AddTransient<IUserService, UserService>(); 
        }
    }
}
