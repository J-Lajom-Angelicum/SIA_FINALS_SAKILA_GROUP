using System.Text.Json.Serialization;

namespace SAKILA_WEBAPP_UI.Models
{
    public class Customer
    {
        public int customerId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string active { get; set; }
        public int addressId { get; set; }
        public int storeId { get; set; }

        public Address Address { get; set; }
    }
}
