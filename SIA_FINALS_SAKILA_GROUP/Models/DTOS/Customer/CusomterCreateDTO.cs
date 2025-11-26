namespace SIA_FINALS_SAKILA_GROUP.Models.DTOS.Customer
{
    public class CusomterCreateDTO
    {
        public int StoreId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int AddressId { get; set; }

        public string Active { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastUpdate { get; set; }
    }
}
