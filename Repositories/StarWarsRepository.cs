using ApiStarWars.Models;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace ApiStarWars.Repositories
{
    public class StarWarsRepository
    {
        private readonly HttpClient _httpClient;
        private const string ApiUrl = "https://akabab.github.io/starwars-api/api/all.json";

        //private static readonly JsonSerializerOptions JsonOptions = new()
        //{
        //    PropertyNameCaseInsensitive = true,
        //    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        //    Converters = { new JsonStringEnumConverter() }
        //};
        public StarWarsRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<StarWarsCharactersResponse>?> GetAllCharactersAsync()
        {            
            try
            {
                return await _httpClient.GetFromJsonAsync<List<StarWarsCharactersResponse>>(ApiUrl);
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Erro ao desserializar JSON: {ex.Message}");
                return null;
            }
        }
    }
}
