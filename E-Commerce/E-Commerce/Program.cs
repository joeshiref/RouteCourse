
using Domain.Contracts;
using Microsoft.EntityFrameworkCore;
using Persistance.Data;
using Persistance.Data.DataSeeding;
using Persistance.Repositories;
using Services;
using Services.Abstraction;
using Services.MappingProfile;
using System.Threading.Tasks;

namespace E_Commerce
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddScoped<IDbIntializer, DbInitailizer>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddAutoMapper(typeof(ProductProfile).Assembly);
            builder.Services.AddScoped<IServiceManager, ServiceManager>();


            var app = builder.Build();
            await InitalizeDbAsync(app);
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseStaticFiles();
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
            async Task InitalizeDbAsync(WebApplication app)
            {
                using var scope = app.Services.CreateScope();
                var services = scope.ServiceProvider;
                try
                {
                    var dbInitializer = services.GetRequiredService<IDbIntializer>();
                    await dbInitializer.InitalizeAsync();
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred during database initialization");
                }
            }
        }
    }
}
