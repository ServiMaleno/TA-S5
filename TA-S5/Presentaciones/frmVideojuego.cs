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
    public partial class frmVideojuego : Form
    {
        Controlador objcontrolador = new Controlador();
        public frmVideojuego()
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

        public void LimpiarCampos()
        {
            txtCodigoVideojuego.Clear();
            txtNombreVideojuego.Clear();
        }

        private void btnRegistrarVideojuego_Click(object sender, EventArgs e)
        {
            if (txtCodigoVideojuego.Text != "" && txtNombreVideojuego.Text != "")
            {
                if (objcontrolador.VideojuegoExiste(txtCodigoVideojuego.Text))
                    MessageBox.Show("El videojuego ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Videojuego videojuego = new Videojuego();
                    videojuego.Codigo = txtCodigoVideojuego.Text;
                    videojuego.Nombre = txtNombreVideojuego.Text;
                    objcontrolador.RegistrarVideojuego(videojuego);
                }
            }
            else
                MessageBox.Show("Debe completar todos los campos.");

            MostrarVideojuegos(objcontrolador.ListarTodosLosVideojuegos());
            LimpiarCampos();
            txtCodigoVideojuego.Focus();
        }

        private void frmVideojuego_Load(object sender, EventArgs e)
        {
            MostrarVideojuegos(objcontrolador.ListarTodosLosVideojuegos());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
