using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Otelim.Models
{
    public class Theme
    {
        [Key]
        [ForeignKey("ThemeId")]
        public int ThemeId { get; set; }
        public ICollection<Hotel> Hotels { get; set; }

        [StringLength(50)]
        public string? ThemeName { get; set; }
      
    }
}
