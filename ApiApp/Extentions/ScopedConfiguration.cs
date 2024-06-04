using Infrastructure.Repositories.InterfaceRepository;
using Infrastructure.Repositories;
using ApiApp.Helpers;
using ApiApp.Services;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using ApiApp.Services.AuthServices;
using ApiApp.OptionsPattern;

namespace ApiApp.Extentions
{
    public static class ScopedConfiguration
    {
        public static void AddCustomServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.DbContextConfiguration(configuration);
            services.RepositoryConfiguration();
            services.ServiceConfiguration();
            services.PrintSettingConfiguration(configuration);
        }
        /// <summary>
        /// Thêm cấu hình DbContext vào IServiceCollection đã chỉ định.
        /// </summary>
        /// <param name="services"></param>
        private static void DbContextConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            var settings = configuration.GetRequiredSection("ConnectionStrings");
            services.AddDbContext<DbAppContext>(options => options.UseLazyLoadingProxies()
            .UseSqlServer(settings["DefaultConnection"], o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery))
                .ConfigureWarnings(warnings => warnings.Ignore(CoreEventId.LazyLoadOnDisposedContextWarning)));
        }
        /// <summary>
        /// cấu hình lấy các thông tin của appsetting.json
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        private static void PrintSettingConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<AppSettings>(configuration.GetSection("AppSettings"));
            services.Configure<ConnectionStrings>(configuration.GetSection("ConnectionStrings"));
        }
        /// <summary>
        /// Chứa các cấu hình liên quan đến repository và unit of work.
        /// </summary>
        /// <param name="services"></param>
        private static void RepositoryConfiguration(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserConnectionRepository, UserConnectionRepository>();
            services.AddScoped<IUserEntityRepository, UserEntityRepository>();
            services.AddScoped<IUserRoleRepository, UserRoleRepository>();
        }
        /// <summary>
        /// Chứa các cấu hình liên quan đến các dịch vụ khác của hệ thống.
        /// </summary>
        /// <param name="services"></param>
        private static void ServiceConfiguration(this IServiceCollection services)
        {
            services.AddScoped<JwtTokenHelper>();
            services.AddScoped<PasswordService>();
            services.AddScoped<AuthorizationService>();
            services.AddSingleton<SessionHelper>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            
            // Đăng ký dịch vụ session
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            services.AddHttpContextAccessor();
            

        }


    }
}
