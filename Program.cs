using IrradApi.Configs;
using IrradApi.Repositories;
using IrradApi.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var stringConnection = builder.Configuration.GetConnectionString("CityIrradiationConnection");

builder.Services.AddDbContext<ContextConfig>(opts => opts.UseMySql(stringConnection, ServerVersion.AutoDetect(stringConnection)));

builder.Services.AddScoped<ICityIrradiationRepository, CityIrradiationRepository>();
builder.Services.AddScoped<CityIrradiationService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors(builder =>
{
    builder.AllowAnyHeader();
    builder.AllowAnyMethod();
    builder.AllowAnyOrigin();
});

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
