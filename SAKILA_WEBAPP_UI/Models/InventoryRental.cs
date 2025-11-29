namespace SAKILA_WEBAPP_UI.Models
{
    public class InventoryRental
    {
        public int inventoryId { get; set; }
        public string title { get; set; }
        public string rentalDate { get; set; }
        public string returnDate { get; set; }
        public string customerName { get; set; }
        public string staffName { get; set; }
        public bool IsRented { get; set; }
        public int storeId { get; set; }
    }
}
