using API.Abstractions.Interface;
using API.Data;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public class GameRepository : IGamesRepository
    {

        private readonly GameStoreContext db;

        public GameRepository(GameStoreContext db)
        {
            this.db = db;
        }

        public async Task CreateAsync(Game game)
        {
            db.Games.Add(game);
            await db.SaveChangesAsync();
        }

        public async Task Update(Game game)
        {
            db.Update(game);
            await db.SaveChangesAsync();
        }

        public async Task Delete(int Id)
        {
            await db.Games.Where(g => g.Id == Id)
                .ExecuteDeleteAsync();
        }

        public async Task<Game?> GetAsync(int Id)
        {
            return await db.Games.FindAsync(Id);
        }

        public async Task<IEnumerable<Game>> GetAllAsync()
        {
            return await db.Games.AsNoTracking().ToListAsync();
        }
    }
}