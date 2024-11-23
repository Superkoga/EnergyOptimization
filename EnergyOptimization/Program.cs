using EnergyOptimization.Entities;
using EnergyOptimization.ExternalServices;
using EnergyOptimization.Factories;
using EnergyOptimization.Interfaces;
using EnergyOptimization.Repositories;
using EnergyOptimization.Services;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container here.

builder.Services.AddScoped<IOpenAIService, OpenAIService>();
builder.Services.AddScoped<IReportFactory, ReportFactory>();
builder.Services.AddScoped<IEnergyService, EnergyService>();
builder.Services.AddScoped<IRepository<EnergyConsumption>, EnergyRepository>();

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

app.UseAuthorization();

app.MapControllers();

app.Run();
