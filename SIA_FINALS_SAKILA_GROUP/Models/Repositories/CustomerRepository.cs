using Microsoft.EntityFrameworkCore;

namespace SIA_FINALS_SAKILA_GROUP.Models.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(sakila2021Context context) : base(context)
        {
        }

        public async Task<IEnumerable<Customer>> FindByLastNameAsync(string lastName)
        {
            return await _context.Customers
                .Where(c => c.LastName.Contains(lastName))
                .ToListAsync();
        }
    }
}
