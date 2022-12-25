using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Otelim.Context;
using Otelim.DataProvider;
using Otelim.DataProvider.EFDataProvider;
using Otelim.Models;
using System.Text.RegularExpressions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<HotelContext>();
builder.Configuration.GetConnectionString("DataConneciton");
builder.Services.AddTransient<IGenericDataProvider<Hotel>, EFHotelDataProvider>();
builder.Services.AddTransient<IGenericDataProvider<PaymentType>, EFPaymentTypeDataProvider>();
builder.Services.AddTransient<IGenericDataProvider<Reservation>, EFReservationDataProvider>(); 
builder.Services.AddTransient<IGenericDataProvider<Theme>, EFThemeDataProvider>();
builder.Services.AddTransient<IGenericDataProvider<User>, EFUserDataProvider>();



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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
