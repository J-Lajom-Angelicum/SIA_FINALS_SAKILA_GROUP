using Microsoft.AspNetCore.Mvc;
using SAKILA_WEBAPP_UI.Models;
using SAKILA_WEBAPP_UI.Services;

namespace SAKILA_WEBAPP_UI.Controllers
{
    public class RentalController : Controller
    {
        private readonly SakilaApiService _apiService;

        public RentalController(SakilaApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<IActionResult> Index(string searchTerm = "", string sortColumn = "rentalDate", string sortDirection = "asc")
        {
            // 1. Get all rentals
            var rentals = await _apiService.GetRentalsAsync();

            // 2. Get related data
            var inventories = await _apiService.GetInventoriesAsync();
            var films = await _apiService.GetFilmsAsync();
            var customers = await _apiService.GetCustomersAsync();
            var staffMembers = await _apiService.GetStaffAsync();

            // 3. Merge Film, Customer, Staff into Rental
            foreach (var rental in rentals)
            {
                // Film via Inventory
                var inventory = inventories.FirstOrDefault(i => i.inventoryId == rental.inventoryId);
                var film = inventory != null ? films.FirstOrDefault(f => f.filmId == inventory.filmId) : null;

                if (film != null)
                {
                    rental.Title = film.title;
                    rental.RentalDuration = film.rentalDuration;
                    rental.RentalRate = film.rentalRate;
                    rental.ReplacementCost = film.replacementCost;
                }

                // Customer Name
                var customer = customers.FirstOrDefault(c => c.customerId == rental.customerId);
                rental.customerName = customer != null ? $"{customer.firstName} {customer.lastName}" : "-";

                // Staff Name
                var staff = staffMembers.FirstOrDefault(s => s.staffId == rental.staffId);
                rental.staffName = staff != null ? $"{staff.firstName} {staff.lastName}" : "-";
            }

            // 4. Filter by search term
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                searchTerm = searchTerm.ToLower();
                rentals = rentals.Where(r =>
                    (!string.IsNullOrEmpty(r.Title) && r.Title.ToLower().Contains(searchTerm)) ||
                    (!string.IsNullOrEmpty(r.customerName) && r.customerName.ToLower().Contains(searchTerm))
                ).ToList();
            }

            // 5. Sort
            rentals = sortColumn switch
            {
                "filmTitle" => sortDirection == "asc" ? rentals.OrderBy(r => r.Title).ToList() : rentals.OrderByDescending(r => r.Title).ToList(),
                "rentalRate" => sortDirection == "asc" ? rentals.OrderBy(r => r.RentalRate).ToList() : rentals.OrderByDescending(r => r.RentalRate).ToList(),
                "rentalDate" => sortDirection == "asc" ? rentals.OrderBy(r => r.rentalDate).ToList() : rentals.OrderByDescending(r => r.rentalDate).ToList(),
                _ => rentals
            };

            // 6. Pass search and sort info to view
            ViewData["CurrentFilter"] = searchTerm;
            ViewData["CurrentSortColumn"] = sortColumn;
            ViewData["CurrentSortDirection"] = sortDirection;

            return View(rentals);
        }
    }
}
