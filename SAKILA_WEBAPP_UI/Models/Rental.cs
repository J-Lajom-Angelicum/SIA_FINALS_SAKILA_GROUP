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
        public string Title { get; set; }
        public byte RentalDuration { get; set; }
        public decimal RentalRate { get; set; }
        public decimal ReplacementCost { get; set; }

        public string customerName { get; set; }
        public string staffName { get; set; }
        public DateTime rentalDate { get; set; }
        public DateTime? returnDate { get; set; }
    }
}
