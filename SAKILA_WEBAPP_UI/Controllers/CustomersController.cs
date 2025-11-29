using Microsoft.AspNetCore.Mvc;
using SAKILA_WEBAPP_UI.Models;
using SAKILA_WEBAPP_UI.Services;

namespace SAKILA_WEBAPP_UI.Controllers
{
    public class CustomerController : Controller
    {
        private readonly SakilaApiService _apiService;

        public CustomerController(SakilaApiService apiService)
        {
            _apiService = apiService;
        }

        // GET: Customers
        public async Task<IActionResult> Index(string searchTerm = "", string sortColumn = "firstName", string sortDirection = "asc")
        {
            // Bulk-load customers with full address, city, country
            var customers = await _apiService.GetCustomersWithFullAddressAsync();

            // Filter
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                var lowerTerm = searchTerm.ToLower();

                customers = sortColumn switch
                {
                    "firstName" => customers.Where(c => c.firstName?.ToLower().Contains(lowerTerm) ?? false).ToList(),
                    "lastName" => customers.Where(c => c.lastName?.ToLower().Contains(lowerTerm) ?? false).ToList(),
                    "email" => customers.Where(c => c.email?.ToLower().Contains(lowerTerm) ?? false).ToList(),
                    "address" => customers.Where(c => c.Address?.address1?.ToLower().Contains(lowerTerm) ?? false).ToList(),
                    "city" => customers.Where(c => c.Address?.City?.city1?.ToLower().Contains(lowerTerm) ?? false).ToList(),
                    "country" => customers.Where(c => c.Address?.City?.Country?.country1?.ToLower().Contains(lowerTerm) ?? false).ToList(),
                    _ => customers.Where(c =>
                        (c.firstName?.ToLower().Contains(lowerTerm) ?? false) ||
                        (c.lastName?.ToLower().Contains(lowerTerm) ?? false) ||
                        (c.email?.ToLower().Contains(lowerTerm) ?? false) ||
                        (c.Address?.address1?.ToLower().Contains(lowerTerm) ?? false) ||
                        (c.Address?.City?.city1?.ToLower().Contains(lowerTerm) ?? false) ||
                        (c.Address?.City?.Country?.country1?.ToLower().Contains(lowerTerm) ?? false)
                    ).ToList()
                };
            }


            // Store filter & sort info for UI
            ViewData["CurrentFilter"] = searchTerm;
            ViewData["CurrentSortColumn"] = sortColumn;
            ViewData["CurrentSortDirection"] = sortDirection;
            return View(customers);
        }

    }
}
