using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIA_FINALS_SAKILA_GROUP.Models;
using SIA_FINALS_SAKILA_GROUP.Models.DTOS.City;
using SIA_FINALS_SAKILA_GROUP.Models.Repositories;

namespace SIA_FINALS_SAKILA_GROUP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : BaseController<City, CityReadDTO, CityCreateDTO, CityUpdateDTO>
    {
        private readonly ICityRepository _cityrepo;

        public CitiesController(ICityRepository repo, IMapper mapper) : base(repo, mapper)
        {
            _cityrepo = repo;
        }

        //Custom Search
        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<CityReadDTO>>> SearchByCountry(short countryId)
        {
            var cities = await _cityrepo.GetCitiesByCountryIdAsync(countryId);

            if (cities == null || !cities.Any())
                return NotFound();

            var result = _mapper.Map<IEnumerable<CityReadDTO>>(cities);

            return Ok(result);
        }
    }
}
