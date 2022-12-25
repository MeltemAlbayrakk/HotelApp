using System.ComponentModel.DataAnnotations;

namespace Otelim.Models
{
    public class Theme
    {
        [Key]
        public int ThemeId { get; set; }
        public string? ThemeName { get; set; }
    }
}
