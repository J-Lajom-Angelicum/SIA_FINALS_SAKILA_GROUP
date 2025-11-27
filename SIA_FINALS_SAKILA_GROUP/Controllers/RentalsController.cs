

using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIA_FINALS_SAKILA_GROUP.Models;
using SIA_FINALS_SAKILA_GROUP.Models.DTOS.Rental;
using SIA_FINALS_SAKILA_GROUP.Models.Repositories;

namespace SIA_FINALS_SAKILA_GROUP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : BaseController<Rental, RentalReadDTO, RentalCreateDTO, RentalUpdateDTO>
    {
        private readonly IRentalRepository _rentalRepo;

        public RentalsController(IRentalRepository repo, IMapper mapper) : base(repo, mapper)
        {
            _rentalRepo = repo;
        }
    }
}
