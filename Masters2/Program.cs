using Microsoft.AspNetCore.Builder;
using System.Net;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.Cookies;

using Masters2.Models;


// إعداد الخيارات الخاصة بالشهادة
ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

var builder = WebApplication.CreateBuilder(args);

//***********************************
//to use MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<FormsContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    options.Password.RequiredLength = 8;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireUppercase = true;
    options.User.RequireUniqueEmail = true;
}).AddEntityFrameworkStores<FormsContext>();






//***********************************
//Configure the Http request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    //The default HSTS value is 30 day. You may want o change this for product

    app.UseHsts();
}
//***********************************
//Redirection in https if i have a ssl certificate
app.UseHttpsRedirection();

//*********************************
//for use Static files
app.UseStaticFiles();

//*********************************
// to Use routing
app.UseRouting();

app.UseAuthentication();
//********************************
//to use authorization
app.UseAuthorization();

//********************************
//to use Map Controller Route


app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
name: "admin",
pattern: "{area:exists}/{controller=Home}/{action=Index}");

    endpoints.MapControllerRoute(
    name: "LandingPages",
    pattern: "{area:exists}/{controller=Home}/{action=Index}");

    endpoints.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

    endpoints.MapControllerRoute(
    name: "ali",
    pattern: "ali/{controller=Home}/{action=Index}/{id?}");

    //endpoints.MapControllerRoute(
    //     name: "Question",
    //     pattern: "{controller=Forms}/{action=Question}");

    endpoints.MapControllerRoute(
    name: "Forms",
    pattern: "{controller=Forms}/{action=Forms}/{id?}");
}
);
app.Run();