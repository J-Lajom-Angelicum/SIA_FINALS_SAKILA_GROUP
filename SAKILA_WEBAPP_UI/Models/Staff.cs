using System.Text.Json.Serialization;

namespace SAKILA_WEBAPP_UI.Models
{
    public class Staff
    {
        public int staffId { get; set; }
        public string firstName { get; set; }

        public string lastName { get; set; }
        public int addressId { get; set; }

        public byte[] picture { get; set; }

        public string email { get; set; }

        public int storeId { get; set; }

        public bool active { get; set; }

        public string username { get; set; }
    }
}
