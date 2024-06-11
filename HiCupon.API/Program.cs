using HiCupon.BW.CU;
using HiCupon.BW.Interfaces.BW;
using HiCupon.BW.Interfaces.DA;
using HiCupon.DA.Actions;
using HiCupon.DA.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IManageBillBW, ManageBillBW>();
builder.Services.AddTransient<IManageBillDA, ManageBillDA>();
builder.Services.AddTransient<IManageBillCouponBW, ManageBillCouponBW>();
builder.Services.AddTransient<IManageBillCouponDA, ManageBillCouponDA>();
builder.Services.AddTransient<IManageUserBW, ManageUserBW>();
builder.Services.AddTransient<IManageUserDA, ManageUserDA>();

builder.Services.AddDbContext<HiCouponContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DB")));

var app = builder.Build();

app.UseCors("AllowOrigin");

app.UseCors(options =>
{
    options.AllowAnyOrigin();
    options.AllowAnyMethod();
    options.AllowAnyHeader();
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
