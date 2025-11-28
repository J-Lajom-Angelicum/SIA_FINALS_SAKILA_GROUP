using System.Text.Json.Serialization;

namespace SAKILA_WEBAPP_UI.Models
{
    public class FilmCategory
    {
        [JsonPropertyName("filmId")]
        public int filmId { get; set; }

        [JsonPropertyName("categoryId")]
        public int categoryId { get; set; }

    }
}
