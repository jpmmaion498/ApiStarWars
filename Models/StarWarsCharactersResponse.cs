using System.Text.Json.Serialization;

namespace ApiStarWars.Models
{
    public class StarWarsCharactersResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("height")]
        public object? Height { get; set; }

        [JsonPropertyName("mass")]
        public object? Mass { get; set; }

        [JsonPropertyName("gender")]
        public string? Gender { get; set; }

        [JsonPropertyName("homeworld")]
        public object? Homeworld { get; set; }

        [JsonPropertyName("wiki")]
        public string? Wiki { get; set; }

        [JsonPropertyName("image")]
        public string? Image { get; set; }

        [JsonPropertyName("born")]
        public object? Born { get; set; }

        [JsonPropertyName("bornLocation")]
        public string? BornLocation { get; set; }

        [JsonPropertyName("died")]
        public object? Died { get; set; }

        [JsonPropertyName("diedLocation")]
        public string? DiedLocation { get; set; }

        [JsonPropertyName("species")]
        public string? Species { get; set; }

        [JsonPropertyName("hairColor")]
        public string? HairColor { get; set; }

        [JsonPropertyName("eyeColor")]
        public string? EyeColor { get; set; }

        [JsonPropertyName("skinColor")]
        public string? SkinColor { get; set; }

        [JsonPropertyName("cybernetics")]
        public object? Cybernetics { get; set; }

        [JsonPropertyName("affiliations")]
        public List<string> Affiliations { get; set; } = new();

        [JsonPropertyName("masters")]
        public object? Masters { get; set; }

        [JsonPropertyName("apprentices")]
        public object? Apprentices { get; set; }

        [JsonPropertyName("formerAffiliations")]
        public List<object> FormerAffiliations { get; set; } = new();

        [JsonPropertyName("dateCreated")]
        public object? DateCreated { get; set; }

        [JsonPropertyName("dateDestroyed")]
        public object? DateDestroyed { get; set; }

        [JsonPropertyName("destroyedLocation")]
        public object? DestroyedLocation { get; set; }

        [JsonPropertyName("creator")]
        public string? Creator { get; set; }

        [JsonPropertyName("manufacturer")]
        public string? Manufacturer { get; set; }

        [JsonPropertyName("model")]
        public object? Model { get; set; }

        [JsonPropertyName("class")]
        public string? Class { get; set; }

        [JsonPropertyName("sensorColor")]
        public string? SensorColor { get; set; }

        [JsonPropertyName("platingColor")]
        public object? PlatingColor { get; set; }

        [JsonPropertyName("equipment")]
        public object? Equipment { get; set; }

        [JsonPropertyName("kajidic")]
        public string? Kajidic { get; set; }

        [JsonPropertyName("era")]
        public object? Era { get; set; }

        [JsonPropertyName("degree")]
        public string? Degree { get; set; }

        [JsonPropertyName("armament")]
        public object? Armament { get; set; }
    }
}
