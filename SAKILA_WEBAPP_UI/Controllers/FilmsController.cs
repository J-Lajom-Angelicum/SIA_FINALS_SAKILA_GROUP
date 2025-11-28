using Microsoft.AspNetCore.Mvc;
using SAKILA_WEBAPP_UI.Models;
using SAKILA_WEBAPP_UI.Services;

namespace SAKILA_WEBAPP_UI.Controllers
{
    public class FilmController : Controller
    {
        private readonly SakilaApiService _api;

        public FilmController(SakilaApiService api)
        {
            _api = api;
        }

        // GET: /Film
        public async Task<IActionResult> Index(string? searchTerm, string? sortOrder)
        {
            var films = await _api.GetFilmsWithDetailsAsync();

            // -------------------------
            //  FILTER (same as before)
            // -------------------------
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                string s = searchTerm.ToLower();

                films = films.Where(f =>
                    (f.Title?.ToLower().Contains(s) ?? false) ||
                    (f.Description?.ToLower().Contains(s) ?? false) ||
                    (f.ReleaseYear?.ToLower().Contains(s) ?? false) ||
                    (f.Rating?.ToLower().Contains(s) ?? false) ||
                    (f.LanguageName?.ToLower().Contains(s) ?? false) ||
                    (f.Actors.Any(a => a.ToLower().Contains(s))) ||
                    (f.Categories.Any(c => c.ToLower().Contains(s)))
                ).ToList();
            }

            // -------------------------
            //  SORTING
            // -------------------------
            switch (sortOrder)
            {
                case "title_asc":
                    films = films.OrderBy(f => f.Title).ToList();
                    break;

                case "title_desc":
                    films = films.OrderByDescending(f => f.Title).ToList();
                    break;

                case "year_asc":
                    films = films.OrderBy(f => f.ReleaseYear).ToList();
                    break;

                case "year_desc":
                    films = films.OrderByDescending(f => f.ReleaseYear).ToList();
                    break;

                case "rating_asc":
                    films = films.OrderBy(f => f.Rating).ToList();
                    break;

                case "rating_desc":
                    films = films.OrderByDescending(f => f.Rating).ToList();
                    break;

                default:
                    break;
            }

            ViewData["CurrentFilter"] = searchTerm;
            ViewData["SortOrder"] = sortOrder;

            return View(films);
        }



        // GET: /Film/Create
        public IActionResult Create() => View();

        // POST: /Film/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Film film)
        {
            if (!ModelState.IsValid) return View(film);

            await _api.PostAsync("api/Films", film);
            return RedirectToAction(nameof(Index));
        }

        // GET: /Film/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var film = await _api.GetFilmAsync(id);
            if (film == null) return NotFound();
            return View(film);
        }

        // POST: /Film/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Film film)
        {
            if (!ModelState.IsValid) return View(film);

            await _api.PutAsync($"api/Films/{film.filmId}", film);
            return RedirectToAction(nameof(Index));
        }

        // GET: /Film/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            await _api.DeleteAsync($"api/Films/{id}");
            return RedirectToAction(nameof(Index));
        }
    }
}
