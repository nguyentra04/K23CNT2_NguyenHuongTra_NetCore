using Microsoft.EntityFrameworkCore;
using NHTLesson10.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("NHTDbConnect");
builder.Services.AddDbContext<Nhtlesson10K23cnt2Context>(x => x.UseSqlServer(connectionString));
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
    pattern: "{controller=NHTHome}/{action=NHTIndex}/{id?}");

app.Run();
