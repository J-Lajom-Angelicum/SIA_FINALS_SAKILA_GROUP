namespace SIA_FINALS_SAKILA_GROUP.Models.DTOS.Rental
{
    public class RentalReadDTO
    {
        public int RentalId { get; set; }

        public DateTime RentalDate { get; set; }

        public int InventoryId { get; set; }

        public int CustomerId { get; set; }

        public DateTime? ReturnDate { get; set; }

        public int StaffId { get; set; }

        public DateTime LastUpdate { get; set; }
    }
}
