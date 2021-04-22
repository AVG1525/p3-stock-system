namespace StockSystem.Domain.Entities
{
    public class User
    {
        public User(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; private set; }
        public virtual Establishment Establishment { get; private set; }
    }
}
