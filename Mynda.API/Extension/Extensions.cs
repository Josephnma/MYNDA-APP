using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Mynda.Persistence.DbContext;
using Mynda.Persistence.Entities;
using Serilog;

namespace Mynda.API.Extension
{
    public static class Extensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
           services.AddCors(options =>
           {
               options.AddPolicy("CorsPolicy", builder =>
               builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader()
               .WithExposedHeaders("X-Pagination")
               );
           });

        public static void UseExtensions(this WebApplication app)
        {
            app.UseSerilogRequestLogging();
        }


        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddDefaultIdentity<User>(q => q.User.RequireUniqueEmail = true);

            builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole), services);
            builder.AddEntityFrameworkStores<MyndaDbContext>().AddDefaultTokenProviders();
        }
    }
}
