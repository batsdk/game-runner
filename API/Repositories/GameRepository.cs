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

        public void Create(Game game)
        {
            db.Games.Add(game);
            db.SaveChanges();
        }

        public void Update(Game game)
        {
            db.Update(game);
            db.SaveChanges();
        }

        public void Delete(int Id)
        {
            db.Games.Where(g => g.Id == Id)
                .ExecuteDelete();
        }

        public Game? Get(int Id)
        {
            return db.Games.Find(Id);
        }

        public IEnumerable<Game> GetAll()
        {
            return db.Games.AsNoTracking().ToList();
        }
    }
}