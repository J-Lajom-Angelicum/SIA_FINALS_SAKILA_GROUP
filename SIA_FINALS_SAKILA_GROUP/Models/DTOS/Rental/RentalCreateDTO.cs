namespace SIA_FINALS_SAKILA_GROUP.Models.DTOS.Rental
{
    public class RentalCreateDTO
    {
        public DateTime RentalDate { get; set; }

        public int InventoryId { get; set; }

        public int CustomerId { get; set; }

        public DateTime? ReturnDate { get; set; }

        public int StaffId { get; set; }
    }
}
