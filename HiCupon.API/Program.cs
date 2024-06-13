using HiCupon.BW.CU;
using HiCupon.BW.Interfaces.BW;
using HiCupon.BW.Interfaces.DA;
using HiCupon.BW.Interfaces.SG;
using HiCupon.DA.Actions;
using HiCupon.DA.Context;
using HiCupon.SG.Actions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();

builder.Services.AddTransient<IManageUserBW, ManageUserBW>();
builder.Services.AddTransient<IManageUserDA, ManageUserDA>();
builder.Services.AddTransient<IManageCouponBW, ManageCouponBW>();
builder.Services.AddTransient<IManageCouponSG, ManageCouponSG>();
builder.Services.AddTransient<IManageCategoryBW, ManageCategoryBW>();
builder.Services.AddTransient<IManageCategorySG, ManageCategorySG>();
builder.Services.AddTransient<IManageBillBW, ManageBillBW>();
builder.Services.AddTransient<IManageBillDA, ManageBillDA>();

builder.Services.AddDbContext<HiCouponContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DB")));

var app = builder.Build();

app.UseCors("AllowOrigin");

app.UseCors(options =>
{
    options.AllowAnyOrigin();
    options.AllowAnyMethod();
    options.AllowAnyHeader();
});

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
