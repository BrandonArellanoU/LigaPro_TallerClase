using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LigaPro_TallerClase.Models
{   
    public class Jugador {
        [Key]
        [Required]
        public int IdPlayer {  get; set; }
        [Required]
        [MaxLength (50)]
        public int Name { get; set; }
        [Required]
        [MaxLength(50)]
        public int position { get; set; }
        [Required]
        [Range (0, 100)]
        public int Age { get; set; }

        [ForeignKey(nameof(Equipo))]
        Equipo equipo { get; set; }



    }
}
