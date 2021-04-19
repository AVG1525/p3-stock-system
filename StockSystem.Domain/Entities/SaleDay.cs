using System;

namespace StockSystem.Domain.Entities
{
    public class SaleDay : EntityBase
    {
        public SaleDay(DateTime dateDay, decimal resultDay, Guid idEstablishment)
        {
            DateDay = dateDay;
            ResultDay = resultDay;
            IdEstablishment = idEstablishment;
        }

        public DateTime DateDay { get; private set; }
        public decimal ResultDay { get; private set; }
        public Guid IdEstablishment { get; private set; }
        public virtual Establishment Establishment { get; private set; }
    }
}
