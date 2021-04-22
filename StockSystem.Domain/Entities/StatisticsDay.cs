using System;

namespace StockSystem.Domain.Entities
{
    public class StatisticsDay
    {
        public StatisticsDay(DateTime dateDay, decimal rawMaterialExpenditure, int growthRate, int idEstablishment)
        {
            DateDay = dateDay;
            RawMaterialExpenditure = rawMaterialExpenditure;
            GrowthRate = growthRate;
            IdEstablishment = idEstablishment;
        }

        public int Id { get; set; }
        public DateTime DateDay { get; private set; }
        public decimal RawMaterialExpenditure { get; private set; }
        public int GrowthRate { get; private set; }
        public int IdEstablishment { get; private set; }
        public virtual Establishment Establishment { get; private set; }
    }
}
