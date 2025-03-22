using Microsoft.EntityFrameworkCore;
using MVC_App_SPD311;
using MVC_App_SPD311.Data;

var builder = WebApplication.CreateBuilder(args);
string connStr = builder.Configuration.GetConnectionString("SomeeDb");

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<FootballDbContext>(opts => 
    opts.UseSqlServer(connStr));

builder.Services.AddScoped<FavouritesService>();
builder.Services.AddHttpContextAccessor();

builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromDays(7);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();