using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIA_FINALS_SAKILA_GROUP.Models;
using SIA_FINALS_SAKILA_GROUP.Models.DTOS.Address;
using SIA_FINALS_SAKILA_GROUP.Models.Repositories;
using AutoMapper;

namespace SIA_FINALS_SAKILA_GROUP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : BaseController<Address, AddressReadDTO, AddressCreateDTO, AddressUpdateDTO>
    {
        private readonly IAddressRepository _addressrepo;
        public AddressesController(IAddressRepository repo, IMapper mapper) : base(repo, mapper)
        {
            _addressrepo = repo;
        }
    }
}
