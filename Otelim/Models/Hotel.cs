namespace Otelim.Models
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public string? HotelName { get; set;}
        public string? HotelDescription { get; set;}
        public string? HotelAddress { get; set;} 
        public float Point { get; set;}
        public float Price { get; set;}
        public Theme? ThemeId { get; set;}

        
    }
}
