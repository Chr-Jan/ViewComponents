using System.ComponentModel.DataAnnotations;

namespace ViewComponents.Models
{
    public class Human
    {
        [Required(ErrorMessage = "Everybody have a name")]
        [StringLength(30, MinimumLength = 2, ErrorMessage ="Impossible")]
        public string Name { get; set; }
        [Range(0, 120, ErrorMessage = "You have to be between 0 and 120 years old")]
        public int Age { get; set; }
    }
}
