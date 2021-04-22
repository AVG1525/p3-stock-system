using System.ComponentModel.DataAnnotations.Schema;

namespace StockSystem.Domain.Entities
{
    public class EntityBase
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}
