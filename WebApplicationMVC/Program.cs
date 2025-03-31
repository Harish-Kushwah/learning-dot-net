using Microsoft.EntityFrameworkCore;
using WebApplicationMVC.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<HarishTestDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("connection")));

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Users}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "subjects",
    pattern: "{controller=Subjects}/{action=Index}/{id?}");
//app.MapControllerRoute(
//    name: "login",
//    pattern: "{controller=Login}/{action=Login}");

//app.MapControllerRoute(
//    name: "about",
//    pattern: "{controller=About}/{action=About}");

//app.MapControllerRoute(
//    name: "tech-skills",
//    pattern: "{controller=TechSkills}/{action=TechSkills}");

app.Run();
