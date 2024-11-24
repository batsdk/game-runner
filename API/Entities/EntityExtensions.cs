using API.DTO;

namespace API.Entities
{
    public static class EntityExtensions
    {
        // Use AutoMapper
        public static GameDto AsDto(this Game game)
        {
            return new GameDto(
                game.Id,
                game.Name,
                game.Genre,
                game.Price,
                game.ReleaseDate,
                game.ImageUri
            );
        }
    }
}