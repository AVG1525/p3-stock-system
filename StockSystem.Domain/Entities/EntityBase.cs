using System;

namespace StockSystem.Domain.Entities
{
    public class EntityBase
    {
        public EntityBase()
        {
            Id = new Guid();
        }

        public Guid Id { get; private set; }
    }
}
