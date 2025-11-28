using System.Text.Json.Serialization;

namespace SAKILA_WEBAPP_UI.Models
{
    public class Film
    {
        [JsonPropertyName("filmId")]
        public int filmId { get; set; }

        [JsonPropertyName("title")]
        public string title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("releaseYear")]
        public string ReleaseYear { get; set; } = "";

        [JsonPropertyName("languageId")]
        public byte LanguageId { get; set; }

        [JsonPropertyName("original_language_id")]
        public byte? OriginalLanguageId { get; set; }

        [JsonPropertyName("rentalDuration")]
        public byte rentalDuration { get; set; }

        [JsonPropertyName("rentalRate")]
        public decimal rentalRate { get; set; }

        [JsonPropertyName("length")]
        public short? Length { get; set; }

        [JsonPropertyName("replacementCost")]
        public decimal replacementCost { get; set; }

        [JsonPropertyName("rating")]
        public string Rating { get; set; }

        [JsonPropertyName("specialFeatures")]
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
