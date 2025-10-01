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
using TA_S5.Presentaciones;

namespace TA_S5
{
    public partial class frmInicio : Form
    {
        Controlador objcontrolador = new Controlador();
        public frmInicio()
        {
            InitializeComponent();
        }

        private void registroDeVideojuegosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tool Strip para abrir el formulario de registro de videojuegos - Oliver
            frmVideojuego frmvideojuego = new frmVideojuego();
            frmvideojuego.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void registroDeJugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Controlador.ListaDeVideojuegos.Count == 0)
            {
                MessageBox.Show("Debe registrar al menos un videojuego antes de agregar jugadores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmJugador frm = new frmJugador();
            frm.ShowDialog();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Controlador.ListaDeVideojuegos.Count == 0 && Controlador.ListaDeJugadores.Count == 0)
            {
                MessageBox.Show("Debe registrar al menos un videojuego o un jugador antes de realizar consultas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmConsulta frm = new frmConsulta();
            frm.ShowDialog();
        }
    }
}
