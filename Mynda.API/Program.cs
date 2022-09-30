using Mynda.API.Extension;
using Mynda.API.GlobalException;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

var services = new ServiceCollection();

Log.Logger = new LoggerConfiguration()
       .ReadFrom.Configuration(configuration)
       .CreateLogger();

try
{
    Log.Information("Hello, {Name}!", Environment.UserName);
}
catch (Exception ex)
{
    Log.Fatal(ex, "The application failed to start correctly.");

}
finally
{
    Log.CloseAndFlush();
}


builder.Services.AddAuthentication();

builder.Services.ConfigureIdentity();

builder.Services.ConfigureCors();

builder.Host.UseSerilog();

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
    app.ConfigureExceptionHandler();
    app.UseSerilogRequestLogging();
}
else
    app.UseHsts();

app.UseMynda();

app.UseSerilogRequestLogging();

app.UseHttpsRedirection();


app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
