namespace SIA_FINALS_SAKILA_GROUP.Models.Repositories
{
    public class AddressRepository : BaseRepository<Address>, IAddressRepository
    {
        public AddressRepository(sakila2021Context context) : base(context)
        {
        }
    }
}
