using Nortwhind.Entities;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using Core6Mvc.AutoMapper;
using Northwind.DAL.Abstract;
using Northwind.DAL.Concrete;
using Northwind.BL.Abstract;
using Northwind.BL.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<NorthwindContext>(options => options.UseSqlServer("Server=.;Database=Northwind;Trusted_Connection=True"));
builder.Services.AddAutoMapper(typeof(NorthwindProfile));
builder.Services.AddScoped<ICategoryManager, CategoryManager>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
