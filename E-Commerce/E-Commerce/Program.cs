
using Domain.Contracts;
using Microsoft.EntityFrameworkCore;
using Persistance.Data;
using Persistance.Data.DataSeeding;
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
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddScoped<IDbIntializer, DbInitailizer>();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();
            await InitalizeDbAsync(app);
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
