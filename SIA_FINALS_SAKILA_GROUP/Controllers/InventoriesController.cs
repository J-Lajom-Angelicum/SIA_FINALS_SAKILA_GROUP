using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIA_FINALS_SAKILA_GROUP.Models;
using SIA_FINALS_SAKILA_GROUP.Models.DTOS.Inventory;
using SIA_FINALS_SAKILA_GROUP.Models.Repositories;

namespace SIA_FINALS_SAKILA_GROUP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoriesController : BaseController<Inventory, InventoryCreateDTO, InventoryReadDTO, InventoryUpdateDTO>
    {
        private readonly IInventoryRepository _inventoryRepo;

        public InventoriesController(IInventoryRepository repo, IMapper mapper) : base(repo, mapper)
        {
            _inventoryRepo = repo;
        }
    }
}
