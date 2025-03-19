using ApiStarWars.Models;
using ApiStarWars.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiStarWars.Routes
{
    public static class StarWarsRoute
    {
        public static void StarWarsRoutes(this WebApplication app)
        {
            var route = app.MapGroup("starwars");

            route.MapGet("/characters", async (
            [FromServices] StarWarsService starWarsService,
            [FromQuery] string? name,
            [FromQuery] string? gender,
            [FromQuery] string? homeworld,
            [FromQuery] int? minHeight,
            [FromQuery] int? maxHeight,
            [FromQuery] int? minMass,
            [FromQuery] int? maxMass
        ) =>
            {
                var filter = new StarWarsCharactersFilter
                {
                    Name = name,
                    Gender = gender,
                    Homeworld = homeworld,
                    MinHeight = minHeight,
                    MaxHeight = maxHeight,
                    MinMass = minMass,
                    MaxMass = maxMass
                };

                var characters = await starWarsService.GetFilteredCharactersAsync(filter);
                return characters is not null && characters.Any() ? Results.Ok(characters) : Results.NotFound(new { Message = "Nenhum personagem encontrado com os filtros fornecidos." });
            });
        }
    }
}
