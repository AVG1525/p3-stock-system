namespace StockSystem.Domain.Entities
{
    public class RawMaterial
    {
        public RawMaterial(int idDescriptionRawMaterial, int idEstablishment)
        {
            IdDescriptionRawMaterial = idDescriptionRawMaterial;
            IdEstablishment = idEstablishment;
        }

        public int Id { get; set; }
        public int IdDescriptionRawMaterial { get; private set; }
        public int IdEstablishment { get; private set; }
        public virtual DescriptionRawMaterial DescriptionRawMaterial { get; private set; }
        public virtual Establishment Establishment { get; private set; }
        public virtual HistoryRawMaterial HistoryRawMaterial { get; private set; }
        public virtual StatisticsRawMaterial StatisticsRawMaterial { get; private set; }
    }
}
