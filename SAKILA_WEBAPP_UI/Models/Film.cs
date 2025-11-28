using System.Text.Json.Serialization;

namespace SAKILA_WEBAPP_UI.Models
{
    public class Film
    {
        [JsonPropertyName("film_id")]
        public int FilmId { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("releaseYear")]
        public string ReleaseYear { get; set; } = "";

        [JsonPropertyName("language_id")]
        public byte LanguageId { get; set; }

        [JsonPropertyName("original_language_id")]
        public byte? OriginalLanguageId { get; set; }

        [JsonPropertyName("rental_duration")]
        public byte RentalDuration { get; set; }

        [JsonPropertyName("rental_rate")]
        public decimal RentalRate { get; set; }

        [JsonPropertyName("length")]
        public short? Length { get; set; }

        [JsonPropertyName("replacement_cost")]
        public decimal ReplacementCost { get; set; }

        [JsonPropertyName("rating")]
        public string Rating { get; set; }

        [JsonPropertyName("special_features")]
        public string SpecialFeatures { get; set; }

        [JsonPropertyName("last_update")]
        public DateTime LastUpdate { get; set; }

        // UI-only properties
        public List<string> Categories { get; set; } = new();
        public List<string> Actors { get; set; } = new();
        public int TotalCopies { get; set; }
        public int AvailableCopies { get; set; }
        public string LanguageName { get; set; } = "-";
    }
}
