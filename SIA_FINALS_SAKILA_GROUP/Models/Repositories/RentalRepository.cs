namespace SIA_FINALS_SAKILA_GROUP.Models.Repositories
{
    public class RentalRepository : BaseRepository<Rental>, IRentalRepository
    {
        public RentalRepository(sakila2021Context context) : base(context)
        {
        }
    }
}
