using System.Text.Json.Serialization;

namespace SAKILA_WEBAPP_UI.Models
{
    public class Actor
    {
        [JsonPropertyName("actorId")]
        public int actorId { get; set; }

        [JsonPropertyName("firstName")]
        public string firstName { get; set; }

        [JsonPropertyName("lastName")]
        public string lastName { get; set; }

        [JsonPropertyName("lastUpdate")]
        public DateTime LastUpdate { get; set; }
    }
}
