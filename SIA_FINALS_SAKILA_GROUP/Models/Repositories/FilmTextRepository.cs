namespace SIA_FINALS_SAKILA_GROUP.Models.Repositories
{
    public class FilmTextRepository : BaseRepository<FilmText>, IFilmTextRepository
    {
        public FilmTextRepository(sakila2021Context context) : base(context)
        {
        }
    }
}
