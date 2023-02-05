using Mentor_DB.DataAccesLayers;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var conString = builder.Configuration["ConnectionStrings:Default"];
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(conString));
var app = builder.Build();
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );

app.Run();
