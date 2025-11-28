namespace SAKILA_WEBAPP_UI.Models
{
    public class Inventory
    {
        public int inventoryId { get; set; }
        public int filmId { get; set; }
        public string filmTitle { get; set; }
        public int storeId { get; set; }
        public string storeAddress { get; set; }
        public bool IsAvailable { get; set; }
    }
}
