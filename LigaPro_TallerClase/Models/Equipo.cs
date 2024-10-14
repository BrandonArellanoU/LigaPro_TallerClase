using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LigaPro_TallerClase.Models
{
    public class Equipo
    {
        [Key]
        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        public int IdEquipo { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        public string City { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        public string Titles { get; set; }
        [Required]
        public Boolean AceptarExtranjeros { get; set; }
        [ForeignKey(nameof(Estadio))]
        public int IdEstadio { get; set; }
        Estadio estadio {  get; set; }

    }
}
