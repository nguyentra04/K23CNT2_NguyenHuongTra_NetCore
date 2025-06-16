using Microsoft.EntityFrameworkCore;
using NHTLesson09.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("NHTBookStore");
builder.Services.AddDbContext<NhtbookStoreContext>(x => x.UseSqlServer(connectionString)); var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/NHTHome/NHTError");
}
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=NHTHome}/{action=NHTIndex}/{NHTId?}")
    .WithStaticAssets();


app.Run();
