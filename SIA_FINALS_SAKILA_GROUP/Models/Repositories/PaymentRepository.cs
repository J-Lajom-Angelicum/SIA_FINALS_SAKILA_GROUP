namespace SIA_FINALS_SAKILA_GROUP.Models.Repositories
{
    public class PaymentRepository : BaseRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(sakila2021Context context) : base(context)
        {
        }
    }
}
