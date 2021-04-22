namespace StockSystem.Domain.Entities
{
    public class Establishment
    {
        public Establishment(string name, int idUser)
        {
            Name = name;
            IdUser = idUser;
        }

        public int Id { get; set; }
        public string Name { get; private set; }
        public int IdUser { get; private set; }
        public virtual User User { get; private set; }
        public virtual RawMaterial RawMaterial { get; private set; }
        public virtual SaleDay SaleDay { get; private set; }
        public virtual StatisticsDay StatisticsDay { get; private set; }
    }
}
