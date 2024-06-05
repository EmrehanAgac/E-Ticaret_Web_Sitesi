using Divisima.DAL.Context;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using System.Net;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<SQLContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("CS1")));
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie
    (opt =>
    {
        opt.ExpireTimeSpan = TimeSpan.FromMinutes(60);
        opt.LoginPath = "/admin/login"; //yetkisi olmayan ki�i bu sayfaya y�nlenecek
        opt.LogoutPath = "/admin/logout"; //s�re dolarsa y�nlendirildi�i sayfa
    });
var app = builder.Build();
if (!app.Environment.IsDevelopment()) app.UseStatusCodePagesWithRedirects("/hata/{0}");
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication(); //kimlik do�rulama
app.UseAuthorization(); //kimlik yetkilendirme
app.MapControllerRoute(name: "areas", pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(name: "default", pattern: "{controller=home}/{action=index}/{id?}");
app.Run();
