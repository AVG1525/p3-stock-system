using System;

namespace StockSystem.Domain.Entities
{
    public class HistoryRawMaterial : EntityBase
    {
        public HistoryRawMaterial(DateTime dateDay, DateTime dateValidity, int amount, decimal unitPrice, Guid idRawMaterial)
        {
            DateDay = dateDay;
            DateValidity = dateValidity;
            Amount = amount;
            UnitPrice = unitPrice;
            IdRawMaterial = idRawMaterial;
        }

        public DateTime DateDay { get; private set; }
        public DateTime DateValidity { get; private set; }
        public int Amount { get; private set; }
        public decimal UnitPrice { get; private set; }
        public Guid IdRawMaterial { get; private set; }
        public virtual RawMaterial RawMaterial { get; private set; }
    }
}
