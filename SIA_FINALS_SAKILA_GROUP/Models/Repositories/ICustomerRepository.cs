namespace SIA_FINALS_SAKILA_GROUP.Models.Repositories
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Task<IEnumerable<Customer>> FindByLastNameAsync(string lastName);
    }
}
