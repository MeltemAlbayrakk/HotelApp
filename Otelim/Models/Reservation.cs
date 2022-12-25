using System.ComponentModel.DataAnnotations;

namespace Otelim.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        public User? UserId { get; set; }
        public User? UserFname { get; set; }
        public User? UserLname { get; set; }
        public int numOfAdult { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime ExitDate { get; set;}
        public PaymentType? PaymentTypeId { get; set; }


    }
}
