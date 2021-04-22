namespace StockSystem.Domain.Entities
{
    public class DescriptionRawMaterial
    {
        public DescriptionRawMaterial(string description)
        {
            Description = description;
        }

        public int Id { get; set; }
        public string Description { get; private set; }
        public virtual RawMaterial RawMaterial { get; private set; }
    }
}
