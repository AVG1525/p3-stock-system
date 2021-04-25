using System.Collections.Generic;

namespace StockSystem.Domain.Response
{
    public class CloseDayResponse
    {
        public string IdEstablishment { get; set; }
        public SaleDayResponse SaleDay { get; set; }
        public List<RawMaterialResponse> RawMaterials { get; set; }
    }
}
