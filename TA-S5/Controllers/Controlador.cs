using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
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




        public void RegistrarJugadorEnUnVideojuego(string codigoVideojuego, Jugador nuevoJugador)
        {
            Videojuego videojuegoEncontrado = ListaDeVideojuegos.Find(v => v.Codigo == codigoVideojuego);
            if (videojuegoEncontrado != null)
            {
                // Buscar si el jugador ya existe en la lista global
                Jugador jugadorExistente = ListaDeJugadores.Find(j => j.DNI == nuevoJugador.DNI);

                if (jugadorExistente == null)
                {
                    // Si no existe, lo agregamos a la lista global
                    ListaDeJugadores.Add(nuevoJugador);
                    jugadorExistente = nuevoJugador;
                }

                // Solo lo agregamos al videojuego si aún no estaba registrado allí
                if (!videojuegoEncontrado.Jugadores.Exists(j => j.DNI == jugadorExistente.DNI))
                {
                    videojuegoEncontrado.Jugadores.Add(jugadorExistente);
                }
            }
        }
        public List<Videojuego> MostrarVideojuegosDondeParticipaUnJugador( string dniJugador)
        {
            List<Videojuego> videojuegoEncontrado = new List<Videojuego>();

            foreach (Videojuego videojuego in ListaDeVideojuegos)
            {
                if(videojuego.Jugadores.Exists(delegate(Jugador jugador)
                {
                    return jugador.DNI == dniJugador;
                }))
                {
                    videojuegoEncontrado.Add(videojuego);
                }
            }
            return videojuegoEncontrado;
        }
        public List<Videojuego> MostrarVideojuegoConMasJugadores()
        {
            List<Videojuego> videojuegosTemp = new List<Videojuego>();
            int maxCantidad = 0;

            foreach(Videojuego videojuego in ListaDeVideojuegos)
            {
                if(videojuego.Jugadores.Count > maxCantidad)
                {
                    maxCantidad = videojuego.Jugadores.Count;
                    videojuegosTemp.Clear();
                    videojuegosTemp.Add(videojuego);
                }
                else if (videojuego.Jugadores.Count == maxCantidad)
                {
                    videojuegosTemp.Add(videojuego);
                }                        
            }
            return videojuegosTemp;
        }

        public string ObtenerAliasJugador(string dniJugador)
        {
            Jugador jugadorEncontrado = ListaDeJugadores.Find(j => j.DNI == dniJugador);
            return jugadorEncontrado != null ? jugadorEncontrado.Alias : null;
        }
    }
}
