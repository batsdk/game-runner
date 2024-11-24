using API.Abstractions.Interface;
using API.Entities;

namespace API.Repositories
{
    public class InMemGamesRepository : IGamesRepository
    {
        private readonly List<Game> games = new List<Game>
        {
            new Game
            {
                Id = 1,
                Name = "Elder Scrolls V: Skyrim",
                Genre = "RPG",
                Price = 39.99m,
                ReleaseDate = new DateTime(2011, 11, 11),
                ImageUri = "https://example.com/images/skyrim.jpg"
            },
            new Game
            {
                Id = 2,
                Name = "The Witcher 3: Wild Hunt",
                Genre = "RPG",
                Price = 29.99m,
                ReleaseDate = new DateTime(2015, 5, 19),
                ImageUri = "https://example.com/images/witcher3.jpg"
            },
            new Game
            {
                Id = 3,
                Name = "Cyberpunk 2077",
                Genre = "Action RPG",
                Price = 49.99m,
                ReleaseDate = new DateTime(2020, 12, 10),
                ImageUri = "https://example.com/images/cyberpunk2077.jpg"
            },
            new Game
            {
                Id = 4,
                Name = "Red Dead Redemption 2",
                Genre = "Action-Adventure",
                Price = 59.99m,
                ReleaseDate = new DateTime(2018, 10, 26),
                ImageUri = "https://example.com/images/rdr2.jpg"
            },
            new Game
            {
                Id = 5,
                Name = "Hades",
                Genre = "Roguelike",
                Price = 24.99m,
                ReleaseDate = new DateTime(2020, 9, 17),
                ImageUri = "https://example.com/images/hades.jpg"
            },
            new Game
            {
                Id = 6,
                Name = "Celeste",
                Genre = "Platformer",
                Price = 19.99m,
                ReleaseDate = new DateTime(2018, 1, 25),
                ImageUri = "https://example.com/images/celeste.jpg"
            },
            new Game
            {
                Id = 7,
                Name = "Dark Souls III",
                Genre = "Action RPG",
                Price = 39.99m,
                ReleaseDate = new DateTime(2016, 4, 12),
                ImageUri = "https://example.com/images/darksouls3.jpg"
            },
            new Game
            {
                Id = 8,
                Name = "Stardew Valley",
                Genre = "Simulation",
                Price = 14.99m,
                ReleaseDate = new DateTime(2016, 2, 26),
                ImageUri = "https://example.com/images/stardewvalley.jpg"
            },
            new Game
            {
                Id = 9,
                Name = "Among Us",
                Genre = "Party",
                Price = 4.99m,
                ReleaseDate = new DateTime(2018, 6, 15),
                ImageUri = "https://example.com/images/amongus.jpg"
            },
            new Game
            {
                Id = 10,
                Name = "Doom Eternal",
                Genre = "FPS",
                Price = 59.99m,
                ReleaseDate = new DateTime(2020, 3, 20),
                ImageUri = "https://example.com/images/doometernal.jpg"
            }
        };

        public IEnumerable<Game> GetAll()
        {
            return games;
        }

        public Game? Get(int Id)
        {
            return games.Find(game => game.Id == Id);
        }

        public void Create(Game game)
        {
            game.Id = games.Max(game => game.Id) + 1;
            games.Add(game);
        }

    }
}