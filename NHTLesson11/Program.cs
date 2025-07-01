using Microsoft.EntityFrameworkCore;
using NHTLesson11.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("NHTDbConnect");
builder.Services.AddDbContext<NguyenHuongTra2310900106Context>(x => x.UseSqlServer(connectionString));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/NHTHome/NHTError");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=NHTHome}/{action=NHTIndex}/{NHTid?}");

app.Run();
