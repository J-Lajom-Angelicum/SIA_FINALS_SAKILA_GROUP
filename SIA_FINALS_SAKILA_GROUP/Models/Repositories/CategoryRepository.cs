namespace SIA_FINALS_SAKILA_GROUP.Models.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(sakila2021Context context) : base(context)
        {
        }
    }
}
