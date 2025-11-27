using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIA_FINALS_SAKILA_GROUP.Models;
using SIA_FINALS_SAKILA_GROUP.Models.DTOS.Category;
using SIA_FINALS_SAKILA_GROUP.Models.Repositories;

namespace SIA_FINALS_SAKILA_GROUP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : BaseController<Category, CategoryCreateDTO, CategoryReadDTO, CategoryUpdateDTO>
    {
        private readonly ICategoryRepository _categoryrepo;

        public CategoriesController(ICategoryRepository repo, IMapper mapper) : base(repo, mapper)
        {
            _categoryrepo = repo;
        }
    }
}
