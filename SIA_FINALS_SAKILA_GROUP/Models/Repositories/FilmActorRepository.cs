namespace SIA_FINALS_SAKILA_GROUP.Models.Repositories
{
    public class FilmActorRepository : BaseRepository<FilmActor>, IFilmActorRepository
    {
        public FilmActorRepository(sakila2021Context context) : base(context)
        {
        }    
    }
}
