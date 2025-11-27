using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIA_FINALS_SAKILA_GROUP.Models;
using SIA_FINALS_SAKILA_GROUP.Models.DTOS.FilmText;
using SIA_FINALS_SAKILA_GROUP.Models.Repositories;

namespace SIA_FINALS_SAKILA_GROUP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmTextsController : BaseController<FilmText, FilmTextCreateDTO, FilmTextReadDTO, FilmTextUpdateDTO>
    {
        private readonly IFilmTextRepository _filmTextRepository;

        public FilmTextsController(IFilmTextRepository repo, IMapper mapper) : base(repo, mapper)
        {
            _filmTextRepository = repo;
        }
    }
}
