namespace Stock_Market_Dashboard.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Symbol { get; set; }
        public decimal CurrentPrice { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
