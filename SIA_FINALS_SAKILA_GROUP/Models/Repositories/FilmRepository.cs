namespace SIA_FINALS_SAKILA_GROUP.Models.Repositories
{
    public class FilmRepository : BaseRepository<Film>, IFilmRepository
    {
        public FilmRepository(sakila2021Context context) : base(context)
        {
        }
    }
}
