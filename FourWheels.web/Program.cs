using FourWheels.Repository.Domain;
using FourWheels.Repository.Interfaces;
using FourWheels.Repository.Repository;
using FourWheels.Service.Interfaces;
using FourWheels.Service.Services;
using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<FourWheelsContext>(option =>
{
    option.UseInMemoryDatabase("Test");
});


builder.Services.AddScoped<IBilService, BilService>();
builder.Services.AddScoped<IBilRepository, BilRepository>();

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