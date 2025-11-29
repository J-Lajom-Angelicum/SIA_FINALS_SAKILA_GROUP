namespace SAKILA_WEBAPP_UI.Models
{
    public class Address
    {
        public int addressId { get; set; }

        public string address1 { get; set; }

        public string address2 { get; set; }

        public string district { get; set; }

        public int cityId { get; set; }

        public string postalCode { get; set; }

        public string phone { get; set; }

        public DateTime lastUpdate { get; set; }

        public City City { get; set; }
    }
}
