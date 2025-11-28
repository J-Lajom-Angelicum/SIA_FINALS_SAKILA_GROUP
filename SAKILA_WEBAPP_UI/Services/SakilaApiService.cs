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

        // Generic GET list
        private async Task<List<T>> GetListAsync<T>(string endpoint)
        {
            var response = await _client.GetAsync(endpoint);
            if (!response.IsSuccessStatusCode) return new List<T>();

            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
        }

        // Generic GET single item
        private async Task<T?> GetSingleAsync<T>(string endpoint)
        {
            var response = await _client.GetAsync(endpoint);
            if (!response.IsSuccessStatusCode) return default;

            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(json);
        }

        // --- CRUD Operations ---
        public async Task<bool> PostAsync<T>(string endpoint, T data) => (await _client.PostAsJsonAsync(endpoint, data)).IsSuccessStatusCode;
        public async Task<bool> PutAsync<T>(string endpoint, T data) => (await _client.PutAsJsonAsync(endpoint, data)).IsSuccessStatusCode;
        public async Task<bool> DeleteAsync(string endpoint) => (await _client.DeleteAsync(endpoint)).IsSuccessStatusCode;

        // --- Film + Related data ---
        public Task<List<Film>> GetFilmsAsync() => GetListAsync<Film>("api/Films");
        public Task<Film?> GetFilmAsync(int id) => GetSingleAsync<Film>($"api/Films/{id}");
        public Task<List<Inventory>> GetInventoriesAsync() => GetListAsync<Inventory>("api/Inventory");
        public Task<List<Rental>> GetRentalsAsync() => GetListAsync<Rental>("api/Rentals");
        public Task<List<Language>> GetLanguagesAsync() => GetListAsync<Language>("api/Languages");
        public Task<List<Actor>> GetActorsAsync() => GetListAsync<Actor>("api/Actors");
        public Task<List<FilmActor>> GetFilmActorsAsync() => GetListAsync<FilmActor>("api/FilmActors");
        public Task<List<Category>> GetCategoriesAsync() => GetListAsync<Category>("api/Categories");
        public Task<List<FilmCategory>> GetFilmCategoriesAsync() => GetListAsync<FilmCategory>("api/FilmCategories");

        // --- Compute TotalCopies and AvailableCopies ---
        public async Task<List<Film>> GetFilmsWithAvailabilityAsync()
        {
            var films = await GetFilmsAsync();
            var inventories = await GetInventoriesAsync();
            var rentals = await GetRentalsAsync();

            foreach (var film in films)
            {
                var filmInventories = inventories.Where(i => i.FilmId == film.FilmId).ToList();
                film.TotalCopies = filmInventories.Count;
                film.AvailableCopies = filmInventories.Count(i => !rentals.Any(r => r.InventoryId == i.InventoryId && r.ReturnDate == null));
            }

            return films;
        }

        // --- Full helper: Merge Language, Actors, Categories, Availability ---
        public async Task<List<Film>> GetFilmsWithDetailsAsync()
        {
            var films = await GetFilmsWithAvailabilityAsync();

            // fetch related data
            var languages = await GetLanguagesAsync();
            var actors = await GetActorsAsync();
            var filmActors = await GetFilmActorsAsync();
            var categories = await GetCategoriesAsync();
            var filmCategories = await GetFilmCategoriesAsync();

            foreach (var film in films)
            {
                // --- Language ---
                var language = languages.FirstOrDefault(l => l.LanguageId == film.LanguageId);
                film.LanguageName = language != null ? language.Name : "-";

                // --- Actors ---
                var actorIds = filmActors
                                .Where(fa => fa.FilmId == film.FilmId)
                                .Select(fa => fa.ActorId)
                                .ToHashSet(); // safer Contains
                film.Actors = actors
                                .Where(a => actorIds.Contains(a.ActorId))
                                .Select(a => $"{a.FirstName} {a.LastName}")
                                .ToList();

                // --- Categories ---
                var categoryIds = filmCategories
                                    .Where(fc => fc.FilmId == film.FilmId)
                                    .Select(fc => fc.CategoryId)
                                    .ToHashSet();
                film.Categories = categories
                                    .Where(c => categoryIds.Contains(c.CategoryId))
                                    .Select(c => c.Name)
                                    .ToList();
            }

            return films;
        }
    }
}
