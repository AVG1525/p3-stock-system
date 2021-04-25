namespace StockSystem.Domain.Request
{
    public class RawMaterialRequest
    {
        public string Description { get; set; }
        public string DateValidity { get; set; }
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
