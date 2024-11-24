using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Abstractions.Interface
{
    public interface IGamesRepository
    {
        public IEnumerable<Game> GetAll();
        public Game? Get(int Id);
        public void Create(Game game);
    }
}