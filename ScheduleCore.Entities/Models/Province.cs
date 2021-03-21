using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScheduleCore.Entities.Models
{
    public class Province
    {
        [Key]
        public int IdProvince { get; set; }

        // Definición de la Relación
        [ForeignKey("IdCountry")]
        public int IdCountry { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Provincia")]
        public string ProvinceName { get; set; }

        [Required]
        [Display(Name = "Estado")]
        public bool Down { get; set; }
    }
}
