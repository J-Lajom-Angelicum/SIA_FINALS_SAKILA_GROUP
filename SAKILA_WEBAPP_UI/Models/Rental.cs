namespace SAKILA_WEBAPP_UI.Models
{
    public class Rental
    {
        public int RentalId { get; set; }
        public int InventoryId { get; set; }
        public int CustomerId { get; set; }
        public int StaffId { get; set; }
        public string FilmTitle { get; set; }
        public string CustomerName { get; set; }
        public string StaffName { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
