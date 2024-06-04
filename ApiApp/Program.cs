using ApiApp.Extentions;
using ApiApp.Filters;
using Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Add services to the container.
var settings = builder.Configuration;

// cấu hình fix json vô hạn không cài thư viện ngoài 
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});

//builder.Services.AddIdentity<IdentityUser, IdentityRole>()
//       .AddEntityFrameworkStores<DbAppContext>()
//       .AddDefaultTokenProviders();

// đăng ký các services được định nghĩa ở đây
builder.Services.AddCustomServices(settings);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddJwtAuthentication(builder.Configuration);
builder.Services.AddSwaggerDocumentation();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Sử dụng session
app.UseSession();

app.UseHttpsRedirection();
app.UseMiddleware<JwtMiddleware>();
app.UseMiddleware<JwtAuthenticationMiddleware>();
app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();

app.Run();
