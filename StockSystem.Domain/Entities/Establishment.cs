using System;

namespace StockSystem.Domain.Entities
{
    public class Establishment : EntityBase
    {
        public Establishment(string name, Guid idUser)
        {
            Name = name;
            IdUser = idUser;
        }

        public string Name { get; private set; }
        public Guid IdUser { get; private set; }
        public virtual User User { get; private set; }
    }
}
