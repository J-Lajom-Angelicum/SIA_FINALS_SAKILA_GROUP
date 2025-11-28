using System.Text.Json.Serialization;

namespace SAKILA_WEBAPP_UI.Models
{
    public class Rental
    {
        public int rentalId { get; set; }
        public int inventoryId { get; set; }
        public int customerId { get; set; }
        public int staffId { get; set; }

        [JsonPropertyName("title")]
        public string title { get; set; }
        public byte rentalDuration { get; set; }
        public decimal rentalRate { get; set; }
        public decimal replacementCost { get; set; }

        public string customerName { get; set; }
        public string staffName { get; set; }
        public DateTime rentalDate { get; set; }
        public DateTime? returnDate { get; set; }
    }
}
