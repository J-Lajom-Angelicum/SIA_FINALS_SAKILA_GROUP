using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using SIA_FINALS_SAKILA_GROUP.Models;
using SIA_FINALS_SAKILA_GROUP.Models.DTOS.Language;
using SIA_FINALS_SAKILA_GROUP.Models.Repositories;
using AutoMapper;

namespace SIA_FINALS_SAKILA_GROUP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : BaseController<Language, LanguageReadDTO, LanguageCreateDTO, LanguageUpdateDTO>
    {
        private readonly ILanguageRepository _languageRepo;
        public LanguagesController(ILanguageRepository repo, IMapper mapper) : base (repo, mapper)
        {
            _languageRepo = repo;
        }
    }
}
