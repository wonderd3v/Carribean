using Carribean.API.Configs;
using Carribean.API.IoC;

namespace Carribean.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("MainPolicy",
                      builder =>
                      {
                          builder
                                 .AllowAnyHeader()
                                 .AllowAnyMethod()
                                 .AllowCredentials();

                          builder.SetIsOriginAllowed(x => true);
                      });
            });

            services.AddServiceRegistry();
            services.SettingSwagger();
            services.SettingSqlServerDbContext(Configuration.GetConnectionString("DefaultConnection"));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("MainPolicy");

            app.UseAuthorization();
        }
    }
}

