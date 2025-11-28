namespace SAKILA_WEBAPP_UI.Models
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public int FilmId { get; set; }
        public string FilmTitle { get; set; }
        public int StoreId { get; set; }
        public string StoreAddress { get; set; }
        public bool IsAvailable { get; set; }
    }
}
