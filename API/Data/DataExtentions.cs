using API.Abstractions.Interface;
using API.Repositories;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public static class DataExntentions
    {
        public async static Task InitializeDbAsync(this IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<GameStoreContext>();
            await dbContext.Database.MigrateAsync();
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration config)
        {

            services.AddScoped<IGamesRepository, GameRepository>();


            var connectionString = config.GetConnectionString("GameStoreContext");
            services.AddDbContext<GameStoreContext>(opt => {
                opt.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            });

            return services;
        }

    }
}