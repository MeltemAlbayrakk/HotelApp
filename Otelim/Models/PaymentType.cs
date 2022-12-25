using System.ComponentModel.DataAnnotations;

namespace Otelim.Models
{
    public class PaymentType
    {
        [Key]
        public int PaymentTypeId { get; set; }
        public string? PaymentTypeName { get; set; }

    }
}
