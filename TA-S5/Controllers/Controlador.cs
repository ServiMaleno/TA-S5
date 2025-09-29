using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using TA_S5.Entities;

namespace TA_S5.Controllers
{
    public class Controlador
    {
        public static List<Videojuego> ListaDeVideojuegos { get; set; }
        public static List<Jugador> ListaDeJugadores { get; set; }

        public Controlador()
        {
            if(ListaDeVideojuegos == null) ListaDeVideojuegos = new List<Videojuego>();
            if(ListaDeJugadores == null) ListaDeJugadores = new List<Jugador>();
        }

        public List<Videojuego> ListarTodosLosVideojuegos()
        {
            return ListaDeVideojuegos;
        }

        public List<Jugador> ListarTodosLosJugadores()
        {
            return ListaDeJugadores;
        }

        public bool VideojuegoExiste(string codigoNuevoVideojuego)
        {
            return ListaDeVideojuegos.Exists(delegate (Videojuego videojuego)
            {
                return videojuego.Codigo == codigoNuevoVideojuego;
            });
        }

        public bool JugadorExiste(string dniNuevoJugador)
        {
            return ListaDeJugadores.Exists(delegate (Jugador jugador)
            {
                return jugador.DNI == dniNuevoJugador;
            });
        }

        public bool RegistrarVideojuego(Videojuego nuevoVideojuego)
        {
            if (!VideojuegoExiste(nuevoVideojuego.Codigo))
            {
                ListaDeVideojuegos.Add(nuevoVideojuego);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
