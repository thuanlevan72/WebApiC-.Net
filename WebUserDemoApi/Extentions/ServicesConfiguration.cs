using Infrastructure.Repositories.InterfaceRepository;
using Infrastructure.Repositories;
using WebUserDemoApi.helpers;
using WebUserDemoApi.Services;
using WebUserDemoApi.Filters;

namespace WebUserDemoApi.Extentions
{
    public static class ServicesConfiguration
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserServicer, UserServicer>();
            services.AddScoped<IUserConnectionRepository, UserConnectionRepository>();
            services.AddScoped<AuthorizationService>();
            services.AddScoped<GenerateJwtToken>();
            // Thêm các dịch vụ khác ở đây
        }
    }
}
