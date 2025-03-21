namespace Stock_Market_Dashboard.Models
{
    public class Watchlist
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Symbol { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
