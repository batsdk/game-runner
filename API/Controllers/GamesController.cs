using API.Abstractions.Interface;
using API.DTO;
using API.Entities;
using API.Repositories;
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
        public List<GameDto> GetAllGames()
        {
            return _repo.GetAll().Select(game => game.AsDto()).ToList();
        }

        [HttpGet("{id}", Name = GetGameEndpoint)]
        public IActionResult GetSingleGame(int id)
        {
            Game? game = _repo.Get(id);
            return game is not null ? Ok(game.AsDto( )) : NotFound();
        }

        [HttpPost("games")]
        public IActionResult AddGame(Game game)
        {
            _repo.Create(game);

            return CreatedAtRoute(GetGameEndpoint, new { id = game.Id }, game);
        }
    }
} 