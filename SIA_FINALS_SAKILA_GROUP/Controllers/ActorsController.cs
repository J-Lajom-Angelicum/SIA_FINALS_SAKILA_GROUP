using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using SIA_FINALS_SAKILA_GROUP.Models.DTOS.Actor;
using SIA_FINALS_SAKILA_GROUP.Models.Repositories;
using SIA_FINALS_SAKILA_GROUP.Models;

namespace SIA_FINALS_SAKILA_GROUP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : BaseController<Actor, ActorReadDTO, ActorCreateDTO, ActorUpdateDTO>
    {
        private readonly IActorRepository _actorsrepo;

        public ActorsController(IActorRepository repo, IMapper mapper) : base(repo, mapper)
        {
            _actorsrepo = repo;
        }

        // Custom domain-specific endpoint
        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<ActorReadDTO>>> SearchByLastName(string lastName)
        {
            var actors = await _actorsrepo.FindByLastNameAsync(lastName);
            return Ok(_mapper.Map<IEnumerable<ActorReadDTO>>(actors));
        }
    }
}
