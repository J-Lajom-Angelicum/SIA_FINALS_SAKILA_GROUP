using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIA_FINALS_SAKILA_GROUP.Models;
using SIA_FINALS_SAKILA_GROUP.Models.DTOS.FilmActor;
using SIA_FINALS_SAKILA_GROUP.Models.Repositories;

namespace SIA_FINALS_SAKILA_GROUP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmActorsRepository : BaseController<FilmActor, FilmActorReadDTO, FilmActorCreateDTO, FilmActorUpdateDTO>
    {
        private readonly IFilmActorRepository _filmActorRepo;

        public FilmActorsRepository(IFilmActorRepository repo, IMapper mapper ) : base (repo, mapper)
        {
            _filmActorRepo = repo;
        }
    }
}
