namespace SIA_FINALS_SAKILA_GROUP.Models.DTOS.Store
{
    public class StoreReadDTO
    {
        public int StoreId { get; set; }

        public int ManagerStaffId { get; set; }

        public int AddressId { get; set; }

        public DateTime LastUpdate { get; set; }
    }
}
