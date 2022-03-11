using FourWheels.Repository.Domain;
using FourWheels.Repository.Interfaces;
using FourWheels.Repository.Repository;
using FourWheels.Service.Interfaces;
using FourWheels.Service.Services;
using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
#if DEBUG

builder.Services.AddSingleton<IArbejdsOrdrerService, ArbejdsOrdrerService>();
builder.Services.AddSingleton<IBilService, BilService>();
builder.Services.AddSingleton<IKundeService, KundeService>();
builder.Services.AddSingleton<IServiceTypeService, ServiceTypeService>();

builder.Services.AddSingleton<IArbejdsOrdrerRepository, ArbejdsOrdrerRepository>();
builder.Services.AddSingleton<IBilRepository, BilRepository>();
builder.Services.AddSingleton<IKundeRepository, KundeRepository>();
builder.Services.AddSingleton<IServiceTypeRepository, ServiceTypeRepository>();
builder.Services.AddSingleton<IArbejdsOrdrerRepository, ArbejdsOrdrerRepository>();

#else

builder.Services.AddScoped<IArbejdsOrdrerService, ArbejdsOrdrerService>();
builder.Services.AddScoped<IBilService, BilService>();
builder.Services.AddScoped<IKundeService, KundeService>();
builder.Services.AddScoped<IServiceTypeService, ServiceTypeService>();

builder.Services.AddScoped<IArbejdsOrdrerRepository, ArbejdsOrdrerRepository>();
builder.Services.AddScoped<IBilRepository, BilRepository>();
builder.Services.AddScoped<IKundeRepository, KundeRepository>();
builder.Services.AddScoped<IServiceTypeRepository, ServiceTypeRepository>();
builder.Services.AddScoped<IArbejdsOrdrerRepository, ArbejdsOrdrerRepository>();

#endif

builder.Services.AddDbContext<FourWheelsContext>(option =>
{
    option.UseInMemoryDatabase("Test");
}, ServiceLifetime.Singleton);

WebApplication app = builder.Build();

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