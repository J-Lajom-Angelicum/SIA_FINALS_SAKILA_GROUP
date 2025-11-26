namespace SIA_FINALS_SAKILA_GROUP.Models.DTOS.Address
{
    public class AddressUpdateDTO
    {
        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string District { get; set; }

        public int CityId { get; set; }

        public string PostalCode { get; set; }

        public string Phone { get; set; }

        public DateTime LastUpdate { get; set; }
    }
}
