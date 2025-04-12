using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using MVC_App_SPD311;
using MVC_App_SPD311.Data;
using MVC_App_SPD311.Extensions;
using MVC_App_SPD311.Interfaces;
using MVC_App_SPD311.Models;

var builder = WebApplication.CreateBuilder(args);
string connStr = builder.Configuration.GetConnectionString("SomeeDb");

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddIdentity<User, IdentityRole>(options => 
        options.SignIn.RequireConfirmedAccount = false)
    .AddDefaultTokenProviders()
    .AddDefaultUI()
    .AddEntityFrameworkStores<FootballDbContext>();

builder.Services.AddDbContext<FootballDbContext>(opts => 
    opts.UseSqlServer(connStr));

builder.Services.AddScoped<FavouritesServiceLocal>();
builder.Services.AddScoped<FavouritesServiceDb>();
builder.Services.AddScoped<IEmailSender, EmailService>();

builder.Services.AddScoped<IFavoriteService>(provider =>
{
    var httpContextAccessor = provider.GetRequiredService<IHttpContextAccessor>();
    var user = httpContextAccessor.HttpContext?.User;

    var isAuthenticated = user?.Identity?.IsAuthenticated ?? false;

    if (isAuthenticated)
        return provider.GetRequiredService<FavouritesServiceDb>();
    else
        return provider.GetRequiredService<FavouritesServiceLocal>();
});


builder.Services.AddHttpContextAccessor();
builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromDays(7);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
builder.Services.AddRazorPages();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    scope.ServiceProvider.SeedRoles().Wait();
    scope.ServiceProvider.SeedAdmin().Wait();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseSession();

app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();