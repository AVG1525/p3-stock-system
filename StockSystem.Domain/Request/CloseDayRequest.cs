using System.Collections.Generic;

namespace StockSystem.Domain.Request
{
    public class CloseDayRequest
    {
        public string IdUser { get; set; }
        public string IdEstablishment { get; set; }
        public SaleDayRequest SaleDay { get; set; }
        public List<RawMaterialRequest> RawMaterials { get; set; }
    }
}
