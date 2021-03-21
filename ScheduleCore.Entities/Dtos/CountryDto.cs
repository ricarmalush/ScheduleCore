using System.ComponentModel.DataAnnotations;

namespace ScheduleCore.Entities.Dtos
{
    public class CountryDto
    {
        [Key]
        public int IdCountry { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "País")]
        public string CountryName { get; set; }

        [Required]
        [Display(Name = "Estado")]
        public bool Down { get; set; }
    }
}
