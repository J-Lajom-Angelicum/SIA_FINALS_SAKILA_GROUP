namespace SIA_FINALS_SAKILA_GROUP.Models.Repositories
{
    public interface IActorRepository : IRepository<Actor>
    {
        Task<IEnumerable<Actor>> FindByLastNameAsync(string lastName);
    }
}
