using System.Text.Json.Serialization;

namespace SAKILA_WEBAPP_UI.Models
{
    public class FilmCategory
    {
        [JsonPropertyName("film_id")]
        public int FilmId { get; set; }

        [JsonPropertyName("category_id")]
        public int CategoryId { get; set; }

        [JsonPropertyName("last_update")]
        public DateTime LastUpdate { get; set; }
    }
}
