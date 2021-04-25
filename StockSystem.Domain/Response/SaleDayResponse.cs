using System;

namespace StockSystem.Domain.Response
{
    public class SaleDayResponse
    {
        public int Id { get; set; }
        public DateTime DateDay { get; set; }
        public decimal ResultDay { get; set; }
    }
}
