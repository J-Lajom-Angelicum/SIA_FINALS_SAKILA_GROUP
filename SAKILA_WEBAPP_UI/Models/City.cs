namespace SAKILA_WEBAPP_UI.Models
{
    public class City
    {
        public int cityId { get; set; }

        public string city1 { get; set; }

        public short countryId { get; set; }

        public DateTime lastUpdate { get; set; }

        public Country Country { get; set; }
    }
}
