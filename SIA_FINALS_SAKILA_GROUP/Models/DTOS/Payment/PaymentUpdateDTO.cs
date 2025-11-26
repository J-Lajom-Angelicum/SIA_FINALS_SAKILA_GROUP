namespace SIA_FINALS_SAKILA_GROUP.Models.DTOS.Payment
{
    public class PaymentUpdateDTO
    {
        public int CustomerId { get; set; }

        public int StaffId { get; set; }

        public int? RentalId { get; set; }

        public decimal Amount { get; set; }

        public DateTime PaymentDate { get; set; }
    }
}
