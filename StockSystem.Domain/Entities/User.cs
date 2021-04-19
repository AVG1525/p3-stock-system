namespace StockSystem.Domain.Entities
{
    public class User : EntityBase
    {
        public User(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
        public virtual Establishment Establishment { get; private set; }
    }
}
