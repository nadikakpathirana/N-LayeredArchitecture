using Layerd.DAL;
using Layerd.Domain.Interfaces;
using Layerd.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// adding wether forecast service
builder.Services.AddScoped<IWeatherForecastService, WeatherForecastService>();

// adding wether forecast repository
builder.Services.AddScoped<IWeatherForecastRepository, WeatherForecastRepository>();

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
