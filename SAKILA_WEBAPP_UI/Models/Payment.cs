namespace SAKILA_WEBAPP_UI.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public string CustomerName { get; set; }
        public string StaffName { get; set; }
        public string FilmTitle { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
