namespace SIA_FINALS_SAKILA_GROUP.Models.Repositories
{
    public class LanguageRepository: BaseRepository<Language>, ILanguageRepository
    {
        public LanguageRepository(sakila2021Context context) : base(context)
        {
        }
    }
}
