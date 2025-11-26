namespace SIA_FINALS_SAKILA_GROUP.Models.Repositories
{
    public interface ICityRepository : IRepository<City>
    {
        Task<IEnumerable<City>> GetCitiesByCountryIdAsync(short countryId);
    }
}
