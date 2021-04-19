namespace StockSystem.Domain.Entities
{
    public class DescriptionRawMaterial : EntityBase
    {
        public DescriptionRawMaterial(string description)
        {
            Description = description;
        }

        public string Description { get; private set; }
    }
}
