using System.Text.Json;
using System.Net.Http.Json;
using SAKILA_WEBAPP_UI.Models;

namespace SAKILA_WEBAPP_UI.Services
{
    public class SakilaApiService
    {
        private readonly HttpClient _client;

        public SakilaApiService(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("SakilaAPI");
        }

        #region Generic GET helpers
        private async Task<List<T>> GetListAsync<T>(string endpoint)
        {
            var response = await _client.GetAsync(endpoint);
            if (!response.IsSuccessStatusCode) return new List<T>();

            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<T>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString
            }) ?? new List<T>();
        }

        private async Task<T?> GetSingleAsync<T>(string endpoint)
        {
            var response = await _client.GetAsync(endpoint);
            if (!response.IsSuccessStatusCode) return default;

            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString
            });
        }
        #endregion

        #region CRUD operations
        public async Task<bool> PostAsync<T>(string endpoint, T data) => (await _client.PostAsJsonAsync(endpoint, data)).IsSuccessStatusCode;
        public async Task<bool> PutAsync<T>(string endpoint, T data) => (await _client.PutAsJsonAsync(endpoint, data)).IsSuccessStatusCode;
        public async Task<bool> DeleteAsync(string endpoint) => (await _client.DeleteAsync(endpoint)).IsSuccessStatusCode;
        #endregion

        #region Films
        public Task<List<Film>> GetFilmsAsync() => GetListAsync<Film>("api/Films");
        public Task<Film?> GetFilmAsync(int id) => GetSingleAsync<Film>($"api/Films/{id}");
        public Task<List<Inventory>> GetInventoriesAsync() => GetListAsync<Inventory>("api/Inventory");
        public Task<List<Rental>> GetRentalsAsync() => GetListAsync<Rental>("api/Rentals");
        public Task<List<Language>> GetLanguagesAsync() => GetListAsync<Language>("api/Languages");
        public Task<List<Actor>> GetActorsAsync() => GetListAsync<Actor>("api/Actors");
        public Task<List<FilmActor>> GetFilmActorsAsync() => GetListAsync<FilmActor>("api/FilmActors");
        public Task<List<Category>> GetCategoriesAsync() => GetListAsync<Category>("api/Categories");
        public Task<List<FilmCategory>> GetFilmCategoriesAsync() => GetListAsync<FilmCategory>("api/FilmCategories");
        // Compute TotalCopies and AvailableCopies for each film
        public async Task<List<Film>> GetFilmsWithAvailabilityAsync()
        {
            var films = await GetFilmsAsync();
            var inventories = await GetInventoriesAsync();
            var rentals = await GetRentalsAsync();

            foreach (var film in films)
            {
                var filmInventories = inventories.Where(i => i.filmId == film.filmId).ToList();
                film.TotalCopies = filmInventories.Count;
                film.AvailableCopies = filmInventories.Count(i =>
                    !rentals.Any(r => r.inventoryId == i.inventoryId && r.returnDate == null)
                );
            }

            return films;
        }

        public async Task<Film?> GetFilmByInventoryIdAsync(int inventoryId)
        {
            var inventories = await GetInventoriesAsync();
            var inventory = inventories.FirstOrDefault(i => i.inventoryId == inventoryId);
            if (inventory == null) return null;
            return await GetFilmAsync(inventory.filmId);
        }
        public async Task<List<Film>> GetFilmsWithDetailsAsync()
        {
            var films = await GetFilmsWithAvailabilityAsync();

            var languages = await GetLanguagesAsync();
            var actors = await GetActorsAsync();
            var filmActors = await GetFilmActorsAsync();
            var categories = await GetCategoriesAsync();
            var filmCategories = await GetFilmCategoriesAsync();

            foreach (var film in films)
            {
                // Language
                var language = languages.FirstOrDefault(l => l.LanguageId == film.LanguageId);
                film.LanguageName = language?.Name?.Trim() ?? "-";

                // Actors
                var actorIds = filmActors
                                .Where(fa => fa.filmId == film.filmId)
                                .Select(fa => fa.actorId)
                                .ToHashSet();

                film.Actors = actors
                                .Where(a => actorIds.Contains(a.actorId))
                                .Select(a => $"{a.firstName} {a.lastName}")
                                .ToList();

                // Categories
                var categoryIds = filmCategories
                                    .Where(fc => fc.filmId == film.filmId)
                                    .Select(fc => fc.categoryId)
                                    .ToHashSet();

                film.Categories = categories
                                    .Where(c => categoryIds.Contains(c.categoryId))
                                    .Select(c => c.name.Trim())
                                    .ToList();
            }

            return films;
        }
        #endregion

        #region Rentals
        public Task<Rental?> GetRentalByIdAsync(int rentalId) => GetSingleAsync<Rental>($"api/Rentals/{rentalId}");
        // Basic list of customers
        public Task<List<Customer>> GetCustomersAsync() => GetListAsync<Customer>("api/Customers");

        public async Task<List<Rental>> GetRentalsWithFilmDetailsAsync()
        {
            var rentals = await GetRentalsAsync();
            var inventories = await GetInventoriesAsync();
            var films = await GetFilmsAsync();
            var customers = await GetCustomersAsync();
            var staffMembers = await GetStaffAsync();

            foreach (var rental in rentals)
            {
                var inventory = inventories.FirstOrDefault(i => i.inventoryId == rental.inventoryId);
                if (inventory != null)
                {
                    var film = films.FirstOrDefault(f => f.filmId == inventory.filmId);
                    if (film != null)
                    {
                        rental.Title = film.title;
                        rental.RentalDuration = film.rentalDuration;
                        rental.RentalRate = film.rentalRate;
                        rental.ReplacementCost = film.replacementCost;
                    }
                }

                var customer = customers.FirstOrDefault(c => c.customerId == rental.customerId);
                rental.customerName = customer != null ? $"{customer.firstName} {customer.lastName}" : "-";

                var staff = staffMembers.FirstOrDefault(s => s.staffId == rental.staffId);
                rental.staffName = staff != null ? $"{staff.firstName} {staff.lastName}" : "-";
            }

            return rentals;
        }
        #endregion

        #region Customers + Addresses + Cities + Countries

        // Bulk-load customers with full address info
        public async Task<List<Customer>> GetCustomersWithFullAddressAsync()
        {
            var customers = await GetListAsync<Customer>("api/Customers");
            var addresses = await GetListAsync<Address>("api/Addresses");
            var cities = await GetListAsync<City>("api/Cities");
            var countries = await GetListAsync<Country>("api/Countries");

            foreach (var c in customers)
            {
                c.Address = addresses.FirstOrDefault(a => a.addressId == c.addressId);
                if (c.Address != null)
                {
                    c.Address.City = cities.FirstOrDefault(ci => ci.cityId == c.Address.cityId);
                    if (c.Address.City != null)
                    {
                        c.Address.City.Country = countries.FirstOrDefault(co => co.countryId == c.Address.City.countryId);
                    }
                }
            }

            return customers;
        }

        #endregion

        #region Staff
        public Task<List<Staff>> GetStaffAsync() => GetListAsync<Staff>("api/Staff");
        #endregion
    }
}
