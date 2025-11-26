namespace SIA_FINALS_SAKILA_GROUP.Models.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<bool> DeleteAsync(int id);
    }
}
