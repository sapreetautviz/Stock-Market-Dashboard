namespace Stock_Market_Dashboard.DTOs
{
    public class StockPriceDto
    {
        public string stockname { get; set; }
        public decimal Open { get; set; }
        public decimal DayHigh { get; set; }
        public decimal DayLow { get; set; }
        public decimal PreviousClose { get; set; }
        public decimal LastTradingPrice { get; set; }
        public decimal LowPriceRange { get; set; }
        public decimal HighPriceRange { get; set; }
        public long Volume { get; set; }
        public decimal DayChange { get; set; }
        public decimal DayChangePercent { get; set; }
        public long TotalBuyQty { get; set; }
        public long TotalSellQty { get; set; }
    }
}
