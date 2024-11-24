using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public static class DataExntentions
    {
        public static void InitilizeDb(this IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<GameStoreContext>();
            dbContext.Database.Migrate();
        }
    }
}