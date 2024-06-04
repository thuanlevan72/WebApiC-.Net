
using Infrastructure.Data;
using Infrastructure.Repositories;
using Infrastructure.Repositories.InterfaceRepository;
using MapperData.MapperConfig;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using System.Text.Json.Serialization;
using WebUserDemoApi.Extentions;
using WebUserDemoApi.helpers;
using WebUserDemoApi.Hubs;
using WebUserDemoApi.Services;

namespace WebUserDemoApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var settings = builder.Configuration.GetRequiredSection("ConnectionStrings");
            builder.Services.AddDbContext<DbAppContext>(options => options.UseLazyLoadingProxies()
           .UseSqlServer(settings["DefaultConnection"], o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery))
           .ConfigureWarnings(warnings => warnings.Ignore(CoreEventId.LazyLoadOnDisposedContextWarning)));

            // đăng ký các services được định nghĩa ở đây
            builder.Services.AddCustomServices();

            builder.Services.AddControllers();
            // cấu hình fix json vô hạn không cài thư viện ngoài 
            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                options.JsonSerializerOptions.WriteIndented = true;
            });

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddMemoryCache();
            //định nghĩa giới hạn về kích thước tối đa của một form gửi lên
            builder.Services.Configure<FormOptions>(options =>
            {
                // Giới hạn về kích thước tối đa cho toàn bộ nội dung của form
                options.MultipartBodyLengthLimit = 1048576000;
                //Độ dài tối đa của boundary trong form multipart
                options.MultipartBoundaryLengthLimit = 99;
                // Kích thước tối đa của buffer dùng để đọc dữ liệu
                options.BufferBodyLengthLimit = 1048576000;
            }); // 1024MB (1GB)
            builder.Services.AddRouting();
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                {
                    builder.WithOrigins("http://localhost:3000")
                           .AllowAnyHeader()
                           .AllowAnyMethod()
                           .AllowCredentials();
                });
            });
            // add swagger
            builder.Services.AddSwaggerDocumentation();

            // đăng ký Thêm phần mềm trung gian xác thực JWT - Mã này sẽ chặn yêu cầu HTTP và xác thực JWT.
            builder.Services.AddJwtAuthentication(builder.Configuration);

            // xác thực tài khoảng có phải tài khoảng chính chủ được lưu trong phiên đăng nhập của hệ thống hay không
            builder.Services.AddCurrentAccountPolicy();
            builder.Services.AddSignalR();
            builder.Services.AddHttpContextAccessor(); // Thêm dòng này
            builder.Services.AddAutoMapper(typeof(MapperData.MapperConfig.CommonConfig).Assembly);
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseMiddleware<CustomStatusCodeHandlingMiddleware>();
            app.UseMiddleware<JwtMiddleware>();

            app.UseAuthentication();
            app.UseAuthorization();
            //app.UseMiddleware<WebSocketTokenMiddleware>();


            app.MapControllers();
            // sử dụng web socket8
            var webSocketOptions = new WebSocketOptions
            {
                KeepAliveInterval = TimeSpan.FromMinutes(2)
            };
            webSocketOptions.AllowedOrigins.Add("*"); //app.UseMiddleware<WebSocketMiddleware>();
            app.UseWebSockets(webSocketOptions);
            app.UseCors("CorsPolicy");
            app.MapHub<ChatHub>("/hub");
            app.Run();
        }
    }
}