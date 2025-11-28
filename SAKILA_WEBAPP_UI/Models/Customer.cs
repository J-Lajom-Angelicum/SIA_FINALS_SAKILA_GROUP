namespace SAKILA_WEBAPP_UI.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public string Address { get; set; }
        public string Store { get; set; }
    }
}
