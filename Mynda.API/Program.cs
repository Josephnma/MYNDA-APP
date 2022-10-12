using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Mynda.API.CustomMiddleware;
using Mynda.API.Extension;
using Mynda.Domain.Mappings;
using Mynda.Domain.Services;
using Mynda.Persistence.DbContext;
using Mynda.Persistence.UnitOfWork;
using Serilog;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
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


builder.Host.UseSerilog();

builder.Services.AddDbContext<MyndaDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});


builder.Services.AddAuthentication();

builder.Services.ConfigureIdentity();

builder.Services.ConfigureJWT(configuration);

builder.Services.ConfigureCors();

builder.Services.AddAutoMapper(typeof(Mapping));

builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped<IAuthManager, AuthManager>();

builder.Services.AddControllers().AddNewtonsoftJson(op => 
    op.SerializerSettings.ReferenceLoopHandling = 
        Newtonsoft.Json.ReferenceLoopHandling.Ignore);


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @" JWT Authorization header using bearer scheme, 
                   Enter 'Bearer' follow by Space and enter your token in the text input below. 
                    Example: 'Bearer 12345abcdef'",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
        {
            {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference(){
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    },
                    Scheme = "0auth2",
                    Name = "Bearer",
                    In = ParameterLocation.Header
                },
                new List<string>()
            }
        });
    c.SwaggerDoc("v1", new OpenApiInfo{Title = "Mynda", Version = "v1"});
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
    app.UseHsts();


app.UseSwagger();

app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mynda v1"));

app.ConfigureExceptionHandler();

app.UseSerilogRequestLogging();

app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
