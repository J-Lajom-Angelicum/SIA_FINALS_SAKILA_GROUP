using System.Text.Json.Serialization;

namespace SAKILA_WEBAPP_UI.Models
{
    public class FilmActor
    {
        [JsonPropertyName("film_id")]
        public int FilmId { get; set; }

        [JsonPropertyName("actor_id")]
        public int ActorId { get; set; }

        [JsonPropertyName("last_update")]
        public DateTime LastUpdate { get; set; }
    }
}
