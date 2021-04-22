using System;

namespace StockSystem.Domain.Entities
{
    public class SaleDay
    {
        public SaleDay(DateTime dateDay, decimal resultDay, int idEstablishment)
        {
            DateDay = dateDay;
            ResultDay = resultDay;
            IdEstablishment = idEstablishment;
        }

        public int Id { get; set; }
        public DateTime DateDay { get; private set; }
        public decimal ResultDay { get; private set; }
        public int IdEstablishment { get; private set; }
        public virtual Establishment Establishment { get; private set; }
    }
}
