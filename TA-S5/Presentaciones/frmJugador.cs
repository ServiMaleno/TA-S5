using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TA_S5.Controllers;
using TA_S5.Entities;

namespace TA_S5.Presentaciones
{
    public partial class frmJugador: Form
    {
        Controlador objcontrolador = new Controlador();
        public frmJugador()
        {
            InitializeComponent();
        }
        public void MostrarJugadores(List<Jugador> jugadores)
        {
            dgvJugadores.DataSource = null;
            if (jugadores.Count == 0) return;
            else
                dgvJugadores.DataSource = jugadores;
        }
        private void frmJugador_Load(object sender, EventArgs e)
        {
            lboxVideojuegos.DisplayMember = "Nombre";
            lboxVideojuegos.ValueMember = "Codigo";  
            lboxVideojuegos.DataSource = Controlador.ListaDeVideojuegos;

            MostrarJugadores(objcontrolador.ListarTodosLosJugadores());
        }

        private void btnRegistrarJugador_Click(object sender, EventArgs e)
        {
            if (tbDNI.Text != "" && tbAlias.Text != "")
            {
                if(lboxVideojuegos.Text == "") { 
                    MessageBox.Show("Seleccione un videojuego", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Jugador jugador = new Jugador();
                jugador.DNI = tbDNI.Text;
                jugador.Alias = tbAlias.Text;

                foreach (Videojuego videojuego in lboxVideojuegos.SelectedItems)
                    objcontrolador.RegistrarJugadorEnUnVideojuego(videojuego.Codigo, jugador);
            }
            else
                MessageBox.Show("Ingresar todos los campos");

            MostrarJugadores(objcontrolador.ListarTodosLosJugadores());
            tbDNI.Clear();
            tbAlias.Clear();
            lboxVideojuegos.SelectedIndex = -1;
            tbDNI.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
