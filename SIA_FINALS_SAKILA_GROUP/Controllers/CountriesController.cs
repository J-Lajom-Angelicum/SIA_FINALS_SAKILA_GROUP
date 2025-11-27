using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIA_FINALS_SAKILA_GROUP.Models;
using SIA_FINALS_SAKILA_GROUP.Models.DTOS.Country;
using SIA_FINALS_SAKILA_GROUP.Models.Repositories;

namespace SIA_FINALS_SAKILA_GROUP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : BaseController<Country, CountryCreateDTO, CountryReadDTO, CountryUpdateDTO>
    {
        private readonly ICountryRepository _countryrepo;

        public CountriesController(ICountryRepository repo, IMapper mapper) : base(repo, mapper)
        {
            _countryrepo = repo;
        }


    }
}
