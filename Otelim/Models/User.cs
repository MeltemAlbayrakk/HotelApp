using System.ComponentModel.DataAnnotations;

namespace Otelim.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string? UserFname { get; set; }
        public string? UserLname { get; set; }
        public string? UserEmail { get; set; }
        public string? UserPhone { get; set; }
        public string? UserPassword { get; set; }
        public int UserGender { get; set; }


    
    }
}
