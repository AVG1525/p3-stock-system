using System;

namespace StockSystem.Domain.Entities
{
    public class RawMaterial : EntityBase
    {
        public RawMaterial(Guid idDescriptionRawMaterial, Guid idEstablishment)
        {
            IdDescriptionRawMaterial = idDescriptionRawMaterial;
            IdEstablishment = idEstablishment;
        }

        public Guid IdDescriptionRawMaterial { get; private set; }
        public Guid IdEstablishment { get; private set; }
        public virtual DescriptionRawMaterial DescriptionRawMaterial { get; private set; }
        public virtual Establishment Establishment { get; private set; }
    }
}
