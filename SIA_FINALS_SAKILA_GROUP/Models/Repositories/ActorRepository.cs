using Microsoft.EntityFrameworkCore;

namespace SIA_FINALS_SAKILA_GROUP.Models.Repositories
{
    public class ActorRepository : BaseRepository<Actor>, IActorRepository
    {
        public ActorRepository(sakila2021Context context) : base(context)
        {
        }

        public async Task<IEnumerable<Actor>> FindByLastNameAsync(string lastName)
        {
            return await _context.Actors
                .Where(a => a.LastName.Contains(lastName))
                .ToListAsync();
        }
    }
}
