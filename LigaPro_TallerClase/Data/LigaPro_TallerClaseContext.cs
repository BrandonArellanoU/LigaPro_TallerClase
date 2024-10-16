using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LigaPro_TallerClase.Models;

namespace LigaPro_TallerClase.Data
{
    public class LigaPro_TallerClaseContext : DbContext
    {
        public LigaPro_TallerClaseContext (DbContextOptions<LigaPro_TallerClaseContext> options)
            : base(options)
        {
        }

        public DbSet<LigaPro_TallerClase.Models.Estadio> Estadio { get; set; } = default!;
        public DbSet<LigaPro_TallerClase.Models.Jugador> Jugador { get; set; } = default!;
        public DbSet<LigaPro_TallerClase.Models.Equipo> Equipo { get; set; } = default!;
    }
}
