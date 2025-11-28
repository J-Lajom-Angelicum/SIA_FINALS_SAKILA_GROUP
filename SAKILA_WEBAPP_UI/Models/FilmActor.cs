using System.Text.Json.Serialization;

namespace SAKILA_WEBAPP_UI.Models
{
    public class FilmActor
    {
        
        [JsonPropertyName("actorId")]
        public int actorId { get; set; }

        [JsonPropertyName("filmId")]
        public int filmId { get; set; }

        [JsonPropertyName("lastUpdate")]
        public DateTime LastUpdate { get; set; }
    }
}
