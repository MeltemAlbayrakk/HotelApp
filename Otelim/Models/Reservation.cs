using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Otelim.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        [ForeignKey("UserId")]
        public string? UserId { get; set; }
        public virtual User User { get; set; }

        public int numOfAdult { get; set; }

        [DataType(DataType.Date)]
        public DateTime ArrivalDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime ExitDate { get; set;}

        [ForeignKey("PaymentTypeId")]
        public int? PaymentTypeId { get; set; }
        public virtual PaymentType PaymentType { get; set; }

        [Column(TypeName = "smallmoney")]
        public float Price { get; set; }






    }
}
