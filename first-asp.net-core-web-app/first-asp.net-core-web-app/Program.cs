using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using first_asp.net_core_web_app.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<first_aspnet_core_web_appContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("first_aspnet_core_web_appContext") ?? throw new InvalidOperationException("Connection string 'first_aspnet_core_web_appContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
