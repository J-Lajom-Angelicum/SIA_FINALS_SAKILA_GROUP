using Microsoft.AspNetCore.Mvc;
using SAKILA_WEBAPP_UI.Models;
using SAKILA_WEBAPP_UI.Services;

namespace SAKILA_WEBAPP_UI.Controllers
{
    public class RentalsController : Controller
    {
        private readonly SakilaApiService _apiService;

        public async Task<IActionResult> Index(string searchTerm = "", string sortColumn = "rentalDate", string sortDirection = "asc")
        {
            // 1. Get all rentals
            var rentals = await _apiService.GetRentalsAsync();

            // 2. Populate film & names (using helpers or manual merge)
            var inventories = await _apiService.GetInventoriesAsync();
            var films = await _apiService.GetFilmsAsync();
            var customers = await _apiService.GetCustomersAsync();
            var staffMembers = await _apiService.GetStaffAsync();

            foreach (var rental in rentals)
            {
                var inventory = inventories.FirstOrDefault(i => i.inventoryId == rental.inventoryId);
                var film = inventory != null ? films.FirstOrDefault(f => f.filmId == inventory.filmId) : null;

                if (film != null)
                {
                    rental.filmTitle = film.Title;
                    rental.rentalDuration = film.RentalDuration;
                    rental.rentalRate = film.RentalRate;
                    rental.replacementCost = film.ReplacementCost;
                }

                var customer = customers.FirstOrDefault(c => c.customerId == rental.customerId);
                rental.customerName = customer != null ? $"{customer.firstName} {customer.lastName}" : "-";

                var staff = staffMembers.FirstOrDefault(s => s.staffId == rental.staffId);
                rental.staffName = staff != null ? $"{staff.firstName} {staff.lastName}" : "-";
            }

            // 3. Filter
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                searchTerm = searchTerm.ToLower();
                rentals = rentals.Where(r =>
                    (r.filmTitle != null && r.filmTitle.ToLower().Contains(searchTerm)) ||
                    (r.customerName != null && r.customerName.ToLower().Contains(searchTerm))
                ).ToList();
            }

            // 4. Sort
            rentals = sortColumn switch
            {
                "filmTitle" => sortDirection == "asc" ? rentals.OrderBy(r => r.filmTitle).ToList() : rentals.OrderByDescending(r => r.filmTitle).ToList(),
                "rentalRate" => sortDirection == "asc" ? rentals.OrderBy(r => r.rentalRate).ToList() : rentals.OrderByDescending(r => r.rentalRate).ToList(),
                "rentalDate" => sortDirection == "asc" ? rentals.OrderBy(r => r.rentalDate).ToList() : rentals.OrderByDescending(r => r.rentalDate).ToList(),
                _ => rentals
            };

            // Pass search and sort parameters to view via ViewData
            ViewData["CurrentFilter"] = searchTerm;
            ViewData["CurrentSortColumn"] = sortColumn;
            ViewData["CurrentSortDirection"] = sortDirection;

            return View(rentals);
        }

    }
}
