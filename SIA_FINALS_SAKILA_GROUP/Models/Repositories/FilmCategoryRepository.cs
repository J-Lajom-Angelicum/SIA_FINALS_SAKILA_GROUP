namespace SIA_FINALS_SAKILA_GROUP.Models.Repositories
{
    public class FilmCategoryRepository : BaseRepository<FilmCategory> , IFilmCategoryRepository
    {
        public FilmCategoryRepository(sakila2021Context context) : base(context)
        {
        }
    }
}
