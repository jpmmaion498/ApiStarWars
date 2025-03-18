using ApiStarWars.Models;
using ApiStarWars.Repositories;

namespace ApiStarWars.Services
{
    public class StarWarsService
    {
        private readonly StarWarsRepository _starWarsRepository;

        public StarWarsService(StarWarsRepository starWarsRepository)
        {
            _starWarsRepository = starWarsRepository;
        }

        public async Task<List<StarWarsCharactersResponse>?> GetFilteredCharactersAsync(StarWarsCharactersFilter filter)
        {
            var characters = await _starWarsRepository.GetAllCharactersAsync();

            if (characters == null) return null;

            return characters
                .Where(c =>
                    // Filtro por Nome (case insensitive)
                    (string.IsNullOrWhiteSpace(filter.Name) ||
                     (c.Name?.Contains(filter.Name, StringComparison.OrdinalIgnoreCase) ?? false))

                    // Filtro por Gênero (case insensitive)
                    && (string.IsNullOrWhiteSpace(filter.Gender) ||
                        (c.Gender?.Equals(filter.Gender, StringComparison.OrdinalIgnoreCase) ?? false))

                    // Filtro por Homeworld (tratar caso seja string ou lista de strings)
                    && (string.IsNullOrWhiteSpace(filter.Homeworld) ||
                        (c.Homeworld != null && c.Homeworld.ToString()?.Equals(filter.Homeworld, StringComparison.OrdinalIgnoreCase) == true))

                    // Filtro por Altura Mínima (tratando conversão segura)
                    && (!filter.MinHeight.HasValue ||
                        (c.Height != null && double.TryParse(c.Height.ToString(), out double h) && h >= filter.MinHeight.Value))

                    // Filtro por Altura Máxima (tratando conversão segura)
                    && (!filter.MaxHeight.HasValue ||
                        (c.Height != null && double.TryParse(c.Height.ToString(), out double hx) && hx <= filter.MaxHeight.Value))

                    // Filtro por Peso Mínimo (tratando conversão segura)
                    && (!filter.MinMass.HasValue ||
                        (c.Mass != null && double.TryParse(c.Mass.ToString(), out double m) && m >= filter.MinMass.Value))

                    // Filtro por Peso Máximo (tratando conversão segura)
                    && (!filter.MaxMass.HasValue ||
                        (c.Mass != null && double.TryParse(c.Mass.ToString(), out double mx) && mx <= filter.MaxMass.Value))
                )
                .ToList();
        }
    }
}
