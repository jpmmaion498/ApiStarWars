using System.Text.Json.Serialization;

namespace ApiStarWars.Models
{
    public class StarWarsCharactersFilter
    {       
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Homeworld { get; set; }
        public int? MinHeight { get; set; }
        public int? MaxHeight { get; set; }
        public int? MinMass { get; set; }
        public int? MaxMass { get; set; }
    }
}
