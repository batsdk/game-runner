using API.Abstractions.Interface;
using API.DTO;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class Games : ControllerBase
    {

        private readonly IGamesRepository _repo ; 

        const string GetGameEndpoint = "GetName";

        public Games(IGamesRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<List<GameDto>> GetAllGames()
        {
            return (await _repo.GetAllAsync()).Select(game => game.AsDto()).ToList();
        }

        [HttpGet("{id}", Name = GetGameEndpoint)]
        public async Task<IActionResult> GetSingleGame(int id)
        {
            Game? game = await _repo.GetAsync(id);
            return game is not null ? Ok(game.AsDto( )) : NotFound();
        }

        [HttpPost("games")]
        public IActionResult AddGame(Game game)
        {
            _repo.CreateAsync(game);

            return CreatedAtRoute(GetGameEndpoint, new { id = game.Id }, game);
        }
    }
} 