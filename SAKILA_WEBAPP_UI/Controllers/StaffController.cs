using Microsoft.AspNetCore.Mvc;
using SAKILA_WEBAPP_UI.Models;
using SAKILA_WEBAPP_UI.Services;

namespace SAKILA_WEBAPP_UI.Controllers
{
    public class StaffController : Controller
    {
        private readonly SakilaApiService _apiService;

        public StaffController(SakilaApiService apiService)
        {
            _apiService = apiService;
        }

        // GET: Staff
        public async Task<IActionResult> Index(
        string searchTerm = "",
        string searchColumn = "", // can be removed if you want to force sortColumn
        string sortColumn = "firstName",
        string sortDirection = "asc")
        {
            var staffList = await _apiService.GetStaffWithFullAddressAsync();

            // If you want search to follow sortColumn
            string searchInColumn = string.IsNullOrEmpty(sortColumn) ? "firstName" : sortColumn;

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                var lowerTerm = searchTerm.ToLower();
                staffList = staffList.Where(s => searchInColumn switch
                {
                    "firstName" => s.firstName?.ToLower().Contains(lowerTerm) ?? false,
                    "lastName" => s.lastName?.ToLower().Contains(lowerTerm) ?? false,
                    "email" => s.email?.ToLower().Contains(lowerTerm) ?? false,
                    "address" => s.Address?.address1?.ToLower().Contains(lowerTerm) ?? false,
                    "city" => s.Address?.City?.city1?.ToLower().Contains(lowerTerm) ?? false,
                    "country" => s.Address?.City?.Country?.country1?.ToLower().Contains(lowerTerm) ?? false,
                    "storeId" => s.storeId.ToString().Contains(lowerTerm),
                    _ => false
                }).ToList();
            }

            // Sort
            staffList = sortColumn switch
            {
                "firstName" => sortDirection == "asc"
                    ? staffList.OrderBy(s => s.firstName).ToList()
                    : staffList.OrderByDescending(s => s.firstName).ToList(),
                "lastName" => sortDirection == "asc"
                    ? staffList.OrderBy(s => s.lastName).ToList()
                    : staffList.OrderByDescending(s => s.lastName).ToList(),
                "email" => sortDirection == "asc"
                    ? staffList.OrderBy(s => s.email).ToList()
                    : staffList.OrderByDescending(s => s.email).ToList(),
                "address" => sortDirection == "asc"
                    ? staffList.OrderBy(s => s.Address?.address1).ToList()
                    : staffList.OrderByDescending(s => s.Address?.address1).ToList(),
                "city" => sortDirection == "asc"
                    ? staffList.OrderBy(s => s.Address?.City?.city1).ToList()
                    : staffList.OrderByDescending(s => s.Address?.City?.city1).ToList(),
                "country" => sortDirection == "asc"
                    ? staffList.OrderBy(s => s.Address?.City?.Country?.country1).ToList()
                    : staffList.OrderByDescending(s => s.Address?.City?.Country?.country1).ToList(),
                "storeId" => sortDirection == "asc"
                    ? staffList.OrderBy(s => s.storeId).ToList()
                    : staffList.OrderByDescending(s => s.storeId).ToList(),
                _ => staffList
            };

            // Pass info to view
            ViewData["CurrentFilter"] = searchTerm;
            ViewData["CurrentSortColumn"] = sortColumn;
            ViewData["CurrentSortDirection"] = sortDirection;

            return View(staffList);
        }

    }
}
