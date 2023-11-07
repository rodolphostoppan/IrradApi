using IrradApi.Configs;
using IrradApi.Repositories;
using IrradApi.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var stringConnection = builder.Configuration.GetConnectionString("CityIrradiationConnection");

// Add services to the container.

builder.Services.AddDbContext<ContextConfig>(opts => opts.UseMySql(stringConnection, ServerVersion.AutoDetect(stringConnection)));

builder.Services.AddScoped<ICityIrradiationRepository, CityIrradiationRepository>();
builder.Services.AddScoped<CityIrradiationService>();

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

app.UsePathBase("/api");
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
