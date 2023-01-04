using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Otelim.Models
{
    public class PaymentType
    {
        [Key]
        [ForeignKey("PaymentTypeId")]
        public int PaymentTypeId { get; set; }
        public ICollection<Reservation> reservations { get; set; }


        [StringLength(20)]
        public string? PaymentTypeName { get; set; }
        
    }
}
