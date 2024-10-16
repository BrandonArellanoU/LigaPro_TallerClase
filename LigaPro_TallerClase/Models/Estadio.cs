using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace LigaPro_TallerClase.Models
{
    public class Estadio 
    {
        [Key]
        [Required]
        public int IdEstadio { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(3)]
        public string Name { get; set; }
        [MaxLength(100)]
        [MinLength(3)]
        public string City { get; set; }
        [Range(1, 100000)]
        public int Capacity { get; set; }

    }
}
