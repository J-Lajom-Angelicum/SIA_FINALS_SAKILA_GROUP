using System.Text.Json.Serialization;

namespace SAKILA_WEBAPP_UI.Models
{
    public class Actor
    {
        [JsonPropertyName("actor_id")]
        public int ActorId { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("last_update")]
        public DateTime LastUpdate { get; set; }
    }
}
