using Company.Application.Mappings;
using Company.Application.Services;
using Company.Application.Services.Interfaces;
using Company.Infrastructure.Data;
using Company.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Diagnostics;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddFluentValidation(options => options.RegisterValidatorsFromAssemblyContaining<Program>());
builder.Services.AddDbContext<ApplicationDbContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<VillaService>();
builder.Services.AddAutoMapper(typeof(MappingProfile));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseExceptionHandler(errorApp =>
{
    errorApp.Run(async context =>
    {
        context.Response.StatusCode = 400;
        context.Response.ContentType = "application/json";

        var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();

        if (exceptionHandlerPathFeature?.Error is ValidationException validationException)
        {
            var errors = validationException.Errors.Select(e => new { e.PropertyName, e.ErrorMessage });
            await context.Response.WriteAsJsonAsync(errors);
        }
        else
        {
            await context.Response.WriteAsync("An unexpected error occurred.");
        }
    });
});

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
public partial class Program { }