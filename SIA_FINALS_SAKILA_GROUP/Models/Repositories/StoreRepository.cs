namespace SIA_FINALS_SAKILA_GROUP.Models.Repositories
{
    public class StoreRepository: BaseRepository<Store>, IStoreRepository
    {
        public StoreRepository(sakila2021Context context) : base(context)
        {
        }
    }
}
