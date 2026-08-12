namespace ABCRetailApp.Models
{
    public class Order
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string ProductName { get; set; } = string.Empty;

        public int Quantity { get; set; }

        public decimal TotalPrice { get; set; }

        public string Status { get; set; } = "Pending";

        public DateTime OrderDate { get; set; } = DateTime.Now;
    }
}