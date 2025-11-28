using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIA_FINALS_SAKILA_GROUP.Models;
using SIA_FINALS_SAKILA_GROUP.Models.DTOS.Customer;
using SIA_FINALS_SAKILA_GROUP.Models.Repositories;

namespace SIA_FINALS_SAKILA_GROUP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : BaseController<Customer, CustomerReadDTO, CustomerCreateDTO, CustomerUpdateDTO>
    {
        private readonly ICustomerRepository _customerRepo;

        public CustomersController(ICustomerRepository repo, IMapper mapper) : base (repo, mapper)
        {
                _customerRepo = repo;
        }

        //Custom Endpoint
        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<CustomerReadDTO>>> SearchByLastName(string lastName)
        {
            var customers = await _customerRepo.FindByLastNameAsync(lastName);
            if (customers == null || !customers.Any())
            {
                return NotFound();
            }
            var customerReadDTOs = _mapper.Map<IEnumerable<CustomerReadDTO>>(customers);
            return Ok(customerReadDTOs);
        }
    }
}
