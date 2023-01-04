using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Otelim.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }


        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }


        public int? HotelId { get; set; }
        [ForeignKey("HotelId")]
        public virtual Hotel Hotel { get; set; }

        public int numOfAdult { get; set; }

        [DataType(DataType.Date)]
        public DateTime ArrivalDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime ExitDate { get; set; }


        public int? PaymentTypeId { get; set; }
        [ForeignKey("PaymentTypeId")]
        public virtual PaymentType PaymentType { get; set; }

        [Column(TypeName = "smallmoney")]
        public float Price { get; set; }









    }
}
