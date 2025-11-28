using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIA_FINALS_SAKILA_GROUP.Models;
using SIA_FINALS_SAKILA_GROUP.Models.DTOS.Film;
using SIA_FINALS_SAKILA_GROUP.Models.Repositories;

namespace SIA_FINALS_SAKILA_GROUP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmsController : BaseController<Film, FilmReadDTO, FilmCreateDTO, FilmUpdateDTO>
    {
        private readonly IFilmRepository _filmRepo;

        public FilmsController(IFilmRepository filmRepository, IMapper mapper) : base(filmRepository, mapper)
        {
            _filmRepo = filmRepository;
        }
    }

}
