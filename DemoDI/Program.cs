using DemoDI.Models;
using DemoDI.Services;
using DemoDI.Services.BonjourServices;
using System.Configuration;


var builder = WebApplication.CreateBuilder(args);
//New

builder.Services.AddScoped<IBonjourService, BonjourService>();

//string connectionString = builder.Configuration["ConnectionString"]
//    ?? throw new InvalidDataException("Connection string was null");

builder.Services.Configure<ConnectionStringConfig>(builder.Configuration.GetSection("ConnectionStrings"));



// Old
builder.Services.AddSingleton<SingletonService>();
builder.Services.AddScoped<IScopedService, ScopedService>();
builder.Services.AddTransient<ITransientService, TransientService>();
builder.Services.AddTransient<IBusinessService, BusinessService>();

builder.Services.AddSingleton<ICacheBigService, BigCache>();
builder.Services.AddSingleton<ICacheSmallService, SmallCache>();

// Methode de configuration nrecommandé
ApisConfiguration apiConfig = new ApisConfiguration();
builder.Services.Configure<ApisConfiguration>(builder.Configuration.GetSection("Apis"));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
