using ScheduleCore.Entities.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScheduleCore.Entities.Dtos
{
    public class ProvinceDto
    {
        [Key]
        public int IdProvince { get; set; }

        [ForeignKey("FK_IdCountry")]
        public int IdCountry { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Provincia")]
        public string ProvinceName { get; set; }

        [Required]
        [Display(Name = "Estado")]
        public bool Down { get; set; }

        public List<Country> Country { get; set; }
    }
}
