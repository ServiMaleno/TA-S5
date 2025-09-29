using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TA_S5.Presentaciones;

namespace TA_S5
{
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}
