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
        opt.LoginPath = "/admin/login"; //yetkisi olmayan kiþi bu sayfaya yönlenecek
        opt.LogoutPath = "/admin/logout"; //süre dolarsa yönlendirildiði sayfa
    });
var app = builder.Build();
if (!app.Environment.IsDevelopment()) app.UseStatusCodePagesWithRedirects("/hata/{0}");
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication(); //kimlik doðrulama
app.UseAuthorization(); //kimlik yetkilendirme
app.MapControllerRoute(name: "areas", pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(name: "default", pattern: "{controller=home}/{action=index}/{id?}");
app.Run();
