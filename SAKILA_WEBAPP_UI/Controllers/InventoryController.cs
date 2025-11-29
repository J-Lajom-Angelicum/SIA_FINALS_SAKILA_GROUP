using Microsoft.AspNetCore.Mvc;
using SAKILA_WEBAPP_UI.Services;
using SAKILA_WEBAPP_UI.Models;

namespace SAKILA_WEBAPP_UI.Controllers
{
    public class InventoryController : Controller
    {
        private readonly SakilaApiService _apiService;

        public InventoryController(SakilaApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<IActionResult> Index()
        {
            var inventoryList = await _apiService.GetInventoriesWithFilmAndRentalAsync();
            return View(inventoryList);
        }

    }
}
