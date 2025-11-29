namespace SAKILA_WEBAPP_UI.Models
{
    public class Inventory
    {
        public int inventoryId { get; set; }
        public int filmId { get; set; }

        // Film info
        public string title { get; set; } = "-";
        public int rentalDuration { get; set; }
        public decimal rentalRate { get; set; }
        public decimal replacementCost { get; set; }

        public int storeId { get; set; }
        public string storeAddress { get; set; } = "-";

        // Rental info
        public DateTime? rentalDate { get; set; }
        public DateTime? returnDate { get; set; }
        public bool isRented { get; set; }

        // Customer/Staff names
        public string customerName { get; set; } = "-";
        public string staffName { get; set; } = "-";

        // Optional convenience property
        public bool isAvailable => !isRented;
    }
}
