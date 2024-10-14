using Microsoft.AspNetCore.Mvc;

namespace LigaPro_TallerClase.Models
{
    public class Jugador : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public int IdPlayer {  get; set; }

        public int Name { get; set; }

        public int position { get; set; }

        public int Age { get; set; }

        Equipo equipo { get; set; }



    }
}
