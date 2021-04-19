using System;

namespace StockSystem.Domain.Entities
{
    public class ValidationTestDay : EntityBase
    {
        public ValidationTestDay(DateTime dateDay, bool isHoliday, int growthRate)
        {
            DateDay = dateDay;
            IsHoliday = isHoliday;
            GrowthRate = growthRate;
        }

        public DateTime DateDay { get; private set; }
        public bool IsHoliday { get; private set; }
        public int GrowthRate { get; private set; }
    }
}
