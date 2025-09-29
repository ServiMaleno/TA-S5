namespace TA_S5.Presentaciones
{
    partial class frmConsulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbDNIJugador = new System.Windows.Forms.TextBox();
            this.btnMostrarVideojuegosDondeParticipaUnJugador = new System.Windows.Forms.Button();
            this.btnMostrarVideojuegosConMayorCantidadDeJugadores = new System.Windows.Forms.Button();
            this.dgvVideojuegos = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideojuegos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar DNI de un jugador:";
            // 
            // tbDNIJugador
            // 
            this.tbDNIJugador.Location = new System.Drawing.Point(232, 33);
            this.tbDNIJugador.Name = "tbDNIJugador";
            this.tbDNIJugador.Size = new System.Drawing.Size(100, 20);
            this.tbDNIJugador.TabIndex = 1;
            // 
            // btnMostrarVideojuegosDondeParticipaUnJugador
            // 
            this.btnMostrarVideojuegosDondeParticipaUnJugador.Location = new System.Drawing.Point(44, 89);
            this.btnMostrarVideojuegosDondeParticipaUnJugador.Name = "btnMostrarVideojuegosDondeParticipaUnJugador";
            this.btnMostrarVideojuegosDondeParticipaUnJugador.Size = new System.Drawing.Size(324, 23);
            this.btnMostrarVideojuegosDondeParticipaUnJugador.TabIndex = 2;
            this.btnMostrarVideojuegosDondeParticipaUnJugador.Text = " Mostrar los videojuegos donde participa un jugador";
            this.btnMostrarVideojuegosDondeParticipaUnJugador.UseVisualStyleBackColor = true;
            this.btnMostrarVideojuegosDondeParticipaUnJugador.Click += new System.EventHandler(this.btnMostrarVideojuegosDondeParticipaUnJugador_Click);
            // 
            // btnMostrarVideojuegosConMayorCantidadDeJugadores
            // 
            this.btnMostrarVideojuegosConMayorCantidadDeJugadores.Location = new System.Drawing.Point(44, 132);
            this.btnMostrarVideojuegosConMayorCantidadDeJugadores.Name = "btnMostrarVideojuegosConMayorCantidadDeJugadores";
            this.btnMostrarVideojuegosConMayorCantidadDeJugadores.Size = new System.Drawing.Size(324, 23);
            this.btnMostrarVideojuegosConMayorCantidadDeJugadores.TabIndex = 3;
            this.btnMostrarVideojuegosConMayorCantidadDeJugadores.Text = "Mostrar videojuegos con mayor cantidad de jugadores";
            this.btnMostrarVideojuegosConMayorCantidadDeJugadores.UseVisualStyleBackColor = true;
            this.btnMostrarVideojuegosConMayorCantidadDeJugadores.Click += new System.EventHandler(this.btnMostrarVideojuegosConMayorCantidadDeJugadores_Click);
            // 
            // dgvVideojuegos
            // 
            this.dgvVideojuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVideojuegos.Location = new System.Drawing.Point(12, 176);
            this.dgvVideojuegos.Name = "dgvVideojuegos";
            this.dgvVideojuegos.Size = new System.Drawing.Size(402, 150);
            this.dgvVideojuegos.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(109, 346);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(191, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(426, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvVideojuegos);
            this.Controls.Add(this.btnMostrarVideojuegosConMayorCantidadDeJugadores);
            this.Controls.Add(this.btnMostrarVideojuegosDondeParticipaUnJugador);
            this.Controls.Add(this.tbDNIJugador);
            this.Controls.Add(this.label1);
            this.Name = "frmConsulta";
            this.Text = "frmConsulta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideojuegos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDNIJugador;
        private System.Windows.Forms.Button btnMostrarVideojuegosDondeParticipaUnJugador;
        private System.Windows.Forms.Button btnMostrarVideojuegosConMayorCantidadDeJugadores;
        private System.Windows.Forms.DataGridView dgvVideojuegos;
        private System.Windows.Forms.Button btnSalir;
    }
}