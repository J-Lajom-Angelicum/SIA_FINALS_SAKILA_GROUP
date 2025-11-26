namespace SIA_FINALS_SAKILA_GROUP.Models.Repositories
{
    public class InventoryRepository : BaseRepository<Inventory>, IInventoryRepository
    {
        public InventoryRepository(sakila2021Context context) : base(context)
        {
        }
    }
}
