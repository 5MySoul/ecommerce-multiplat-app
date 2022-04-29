using Ecommerce_multiplat_app.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//Inject DbContext
builder.Services.AddDbContext<wtopshoppingcoreContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddCors((setup) =>
{
    setup.AddPolicy("default", (options) =>
    {
        //Khi nào đặt hosting thì sửa lại phần domain
        //options.WithOrigins("https://localhost:7121/", "")
        //    .AllowAnyHeader()
        //    .AllowAnyMethod();

        options.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    
}

app.UseHttpsRedirection();

app.UseCors("default");

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
