using Core.Services;
using DataLayer.Repositories;

namespace Reddit.Settings
{
    public static class Dependecies
    {
        public static void Inject(WebApplicationBuilder applicationBuilder)
        {
            applicationBuilder.Services.AddControllers();
            applicationBuilder.Services.AddSwaggerGen();

            AddRepositories(applicationBuilder.Services);
            AddServices(applicationBuilder.Services);
        }

        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<UserService>();
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<UserRepository>();
        }
    }
}
