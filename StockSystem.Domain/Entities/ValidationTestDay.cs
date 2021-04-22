using System;

namespace StockSystem.Domain.Entities
{
    public class ValidationTestDay
    {
        public ValidationTestDay(DateTime dateDay, bool isHoliday, int growthRate)
        {
            DateDay = dateDay;
            IsHoliday = isHoliday;
            GrowthRate = growthRate;
        }

        public int Id { get; set; }
        public DateTime DateDay { get; private set; }
        public bool IsHoliday { get; private set; }
        public int GrowthRate { get; private set; }
    }
}
