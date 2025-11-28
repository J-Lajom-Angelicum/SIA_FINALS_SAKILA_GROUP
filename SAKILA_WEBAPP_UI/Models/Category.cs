using System.Text.Json.Serialization;

namespace SAKILA_WEBAPP_UI.Models
{
    public class Category
    {
        [JsonPropertyName("category_id")]
        public int CategoryId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("last_update")]
        public DateTime LastUpdate { get; set; }
    }
}
