namespace StockSystem.Domain.Response
{
    public class RawMaterialResponse
    {
        public string Description { get; set; }
        public string DateValidity { get; set; }
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
