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
            MostrarVideojuegos(objControlador.MostrarVideojuegosDondeParticipaUnJugador(tbDNIJugador.Text));
            
        }

        private void btnMostrarVideojuegosConMayorCantidadDeJugadores_Click(object sender, EventArgs e)
        {
            MostrarVideojuegos(objControlador.MostrarVideojuegoConMasJugadores());
            tbDNIJugador.Clear();
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
