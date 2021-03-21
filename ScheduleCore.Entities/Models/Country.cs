using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ScheduleCore.Entities.Models
{
    public class Country
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

        public ICollection<Province> Province { get; set; }
    }
}
