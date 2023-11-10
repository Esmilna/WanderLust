using Facturacion_web_api.Data;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;

var builder = WebApplication.CreateBuilder(args);

// Configuración de servicios
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowMyApp",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});


//MySQL Connection 
var connectionString = builder.Configuration.GetConnectionString("MySQLConnection");
var serverVersion = new MySqlServerVersion(new Version(10, 4, 27));
builder.Services.AddDbContext<ApplicationDbContext>(options => 
{
    //options.UseMySql(builder.Configuration.GetConnectionString["MySQLConnection"]);
    options.UseMySql(connectionString, serverVersion);
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowMyApp");

app.UseAuthorization();

app.MapControllers();

app.Run();
