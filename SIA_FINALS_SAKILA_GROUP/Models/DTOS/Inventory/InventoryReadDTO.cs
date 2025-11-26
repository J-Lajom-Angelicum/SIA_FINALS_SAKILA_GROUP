namespace SIA_FINALS_SAKILA_GROUP.Models.DTOS.Inventory
{
    public class InventoryReadDTO
    {
        public int InventoryId { get; set; }

        public int FilmId { get; set; }

        public int StoreId { get; set; }

        public DateTime LastUpdate { get; set; }
    }
}
