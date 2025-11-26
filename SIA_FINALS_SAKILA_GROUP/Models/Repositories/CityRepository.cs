using Microsoft.EntityFrameworkCore;

namespace SIA_FINALS_SAKILA_GROUP.Models.Repositories
{
    public class CityRepository : BaseRepository<City>, ICityRepository
    {
        public CityRepository(sakila2021Context context) : base(context)
        {
        }

        public async Task<IEnumerable<City>> GetCitiesByCountryIdAsync(short countryId)
        {
            return await _context.Cities
                .Where(c => c.CountryId == countryId)
                .ToListAsync();
        }
    }
}
