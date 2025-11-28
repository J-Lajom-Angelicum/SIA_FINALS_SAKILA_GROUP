using System.Text.Json.Serialization;

namespace SAKILA_WEBAPP_UI.Models
{
    public class Category
    {
        [JsonPropertyName("categoryId")]
        public int categoryId { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; } = "";

    }
}
