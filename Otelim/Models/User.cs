using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Otelim.Models
{
    public class User
    {
        [Key]
        [ForeignKey("UserId")]
        public int UserId { get; set; }
 

        [StringLength(20)]
        [Required]
        public string? UserFname { get; set; }

        [StringLength(20)]
        [Required]
        public string? UserLname { get; set; }

        [Required(ErrorMessage ="E-posta Gerekli!!")]
        [StringLength(50)]
        public string? UserEmail { get; set; }

        public string? UserPhone { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
        [StringLength(18, ErrorMessage = "Şifre en az 8 karakter uzunlukta olmalı!!")]
        public string? UserPassword { get; set; }

        [Required]
        public int UserGender { get; set; }


    
    }
}
