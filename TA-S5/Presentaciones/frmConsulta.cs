using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TA_S5.Controllers;
using TA_S5.Entities;

namespace TA_S5.Presentaciones
{
    public partial class frmConsulta: Form
    {
        Controlador objControlador = new Controlador();
        public frmConsulta()
        {
            InitializeComponent();
        }
        public void MostrarVideojuegos(List<Videojuego> videojuegos)
        {
            dgvVideojuegos.DataSource = null;
            if (videojuegos.Count == 0) return;
            else
                dgvVideojuegos.DataSource = videojuegos;
        }

        private void btnMostrarVideojuegosDondeParticipaUnJugador_Click(object sender, EventArgs e)
        {
            if(tbDNIJugador.Text == ""){
                MessageBox.Show("Ingrese un DNI");
                return;
            }
            if(!objControlador.JugadorExiste(tbDNIJugador.Text)){
                MessageBox.Show("El jugador no existe");
                tbDNIJugador.Clear();
                tbDNIJugador.Focus();
                return;
            }
            lblJugador.Text = objControlador.ObtenerAliasJugador(tbDNIJugador.Text);
            MostrarVideojuegos(objControlador.MostrarVideojuegosDondeParticipaUnJugador(tbDNIJugador.Text));
            
        }

        private void btnMostrarVideojuegosConMayorCantidadDeJugadores_Click(object sender, EventArgs e)
        {
            MostrarVideojuegos(objControlador.MostrarVideojuegoConMasJugadores());
            tbDNIJugador.Clear();
            lblJugador.Text = "-";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbDNIJugador.Clear();
            lblJugador.Text = "-";
            dgvVideojuegos.DataSource = null;
        }
    }
}
