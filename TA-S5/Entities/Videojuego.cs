using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA_S5.Entities
{
    public class Videojuego
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public List<Jugador> Jugadores { get; set; } 

        public Videojuego() 
        {
            Jugadores = new List<Jugador>();
        }
    }
}
