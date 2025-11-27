using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIA_FINALS_SAKILA_GROUP.Models;
using SIA_FINALS_SAKILA_GROUP.Models.DTOS.Store;
using SIA_FINALS_SAKILA_GROUP.Models.Repositories;

namespace SIA_FINALS_SAKILA_GROUP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoresController : BaseController<Store, StoreReadDTO, StoreCreateDTO, StoreUpdateDTO>
    {
        private readonly IStoreRepository _storeRepo;

        public StoresController(IStoreRepository repo, IMapper mapper) : base(repo, mapper)
        {
            _storeRepo = repo;
        }
    }
}
