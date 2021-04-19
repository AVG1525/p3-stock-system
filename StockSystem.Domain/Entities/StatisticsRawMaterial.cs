using System;

namespace StockSystem.Domain.Entities
{
    public class StatisticsRawMaterial : EntityBase
    {
        public StatisticsRawMaterial(DateTime dateDay, DateTime estimatedStockDateEmpty, Guid idRawMaterial)
        {
            DateDay = dateDay;
            EstimatedStockDateEmpty = estimatedStockDateEmpty;
            IdRawMaterial = idRawMaterial;
        }

        public DateTime DateDay { get; private set; }
        public DateTime EstimatedStockDateEmpty { get; private set; }
        public Guid IdRawMaterial { get; private set; }
        public virtual RawMaterial RawMaterial { get; private set; }
    }
}
