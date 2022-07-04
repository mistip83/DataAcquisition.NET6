using DataAcquisition.API.Dependencies;
using DataAcquisition.CalibrationManager.Dependencies;
using DataAcquisition.DataAccessEF.DataAccess;
using DataAcquisition.ExperimentManager.Dependencies;
using DataAcquisition.Service.Dependencies;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

// Add services to the container.
services.AddControllers().AddNewtonsoftJson(options =>
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

// Register dependencies
services.RegisterCommonDependencies();
services.RegisterServiceDependencies();
services.RegisterCalibrationDependencies();
services.RegisterExperimentManagerDependencies();

services.AddDbContext<AppDbContext>();
services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder => builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
