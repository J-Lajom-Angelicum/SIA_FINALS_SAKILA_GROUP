namespace SIA_FINALS_SAKILA_GROUP.Models.Repositories
{
    public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {
        public CountryRepository(sakila2021Context context) : base(context)
        {
        }
    }
}
