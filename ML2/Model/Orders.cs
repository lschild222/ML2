using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ML2.Model
{
    public class Orders
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateTime { get; set; } = DateTime.MinValue;
        [StringLength(50)]
        public string Description { get; set; } = string.Empty;
        [StringLength(30)]
        public string Status {  get; set; } = string.Empty;
        [Column(TypeName = "decimal(9,2)")]
        public decimal Total { get; set; }

        public Customer? Customer { get; set; }
    }
}
