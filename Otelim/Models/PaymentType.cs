using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Otelim.Models
{
    public class PaymentType
    {
        [Key]
        public int PaymentTypeId { get; set; }
       
        [StringLength(20)]
        public string? PaymentTypeName { get; set; }
        [ForeignKey("PaymentTypeId")]
        public ICollection<Reservation> reservations { get; set; }
    }
}
