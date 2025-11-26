namespace SIA_FINALS_SAKILA_GROUP.Models.DTOS.Payment
{
    public class PaymentReadDTO
    {
        public int PaymentId { get; set; }

        public int CustomerId { get; set; }

        public int StaffId { get; set; }

        public int? RentalId { get; set; }

        public decimal Amount { get; set; }

        public DateTime PaymentDate { get; set; }
    }
}
