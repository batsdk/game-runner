using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Abstractions.Interface
{
    public interface IGamesRepository
    {
        Task<IEnumerable<Game>> GetAllAsync();
        Task<Game?> GetAsync(int Id);
        Task CreateAsync(Game game);
    }
}