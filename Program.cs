using Teleperformance._2.StockManagement;
using Teleperformance._2.EntityDB;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services.AddDbContext<EntityDBContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("Default"))
);

// Add services to the container.
builder.Services.AddRazorPages();

//Since I want to have a different product every time I create a product we have to use AddTransient
builder.Services.AddTransient<IProducts, Smartphones>();

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

app.MapRazorPages();

app.Run();
