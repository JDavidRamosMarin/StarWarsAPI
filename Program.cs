using Microsoft.EntityFrameworkCore;
using STAR_WARS_API;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDbContext>(options => 
    options.UseSqlServer("name=DefaultConnection"));

var app = builder.Build();

// Add Middlewares

//app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();
