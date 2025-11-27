using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIA_FINALS_SAKILA_GROUP.Models;
using SIA_FINALS_SAKILA_GROUP.Models.DTOS.FilmActor;
using SIA_FINALS_SAKILA_GROUP.Models.DTOS.FilmCategory;
using SIA_FINALS_SAKILA_GROUP.Models.Repositories;

namespace SIA_FINALS_SAKILA_GROUP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmCategoriesController : BaseController<FilmCategory, FilmCategoryCreateDTO, FilmCategoryReadDTO, FilmCategoryUpdateDTO>
    {
        private readonly IFilmCategoryRepository _filmCategoryRepo;

        public FilmCategoriesController(IFilmCategoryRepository repo, IMapper mapper) : base(repo, mapper)
        {
            _filmCategoryRepo = repo;
        }
    }
}
