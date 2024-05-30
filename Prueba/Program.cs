using Microsoft.EntityFrameworkCore;
using Prueba.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors();
builder.Services.AddControllers();
builder.Services.AddDbContext<VueDbContext>(options =>
        options.UseMySql(builder.Configuration.GetConnectionString("CadenaMySql"), Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.30-mysql"))
        .EnableSensitiveDataLogging() // <-- These two calls are optional but help
        .EnableDetailedErrors()
        );
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

app.UseAuthorization();

app.MapControllers();

app.Run();
