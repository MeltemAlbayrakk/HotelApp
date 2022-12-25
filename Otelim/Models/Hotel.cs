using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Otelim.Models
{
    public class Hotel
    {
        [Key]
        public int HotelId { get; set; }

        [Required]
        [StringLength(30)]
        public string? HotelName { get; set;}
        
        public string? HotelDescription { get; set;}

        [Required]
        public string? HotelAddress { get; set;} 

        public float Point { get; set;}

        [Required]
        [Column(TypeName ="smallmoney")]
        public float Price { get; set;}

        [ForeignKey("ThemeId")]
        public int? ThemeId { get; set; }
        public virtual Theme Theme { get; set; } 


        
    }
}
