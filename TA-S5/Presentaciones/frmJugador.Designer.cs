namespace TA_S5.Presentaciones
{
    partial class frmJugador
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lboxVideojuegos = new System.Windows.Forms.ListBox();
            this.btnRegistrarJugador = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvJugadores = new System.Windows.Forms.DataGridView();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.tbAlias = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI del jugador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alias del jugador:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Videojuegos:";
            // 
            // lboxVideojuegos
            // 
            this.lboxVideojuegos.FormattingEnabled = true;
            this.lboxVideojuegos.Location = new System.Drawing.Point(288, 32);
            this.lboxVideojuegos.Name = "lboxVideojuegos";
            this.lboxVideojuegos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lboxVideojuegos.Size = new System.Drawing.Size(120, 95);
            this.lboxVideojuegos.TabIndex = 3;
            // 
            // btnRegistrarJugador
            // 
            this.btnRegistrarJugador.Location = new System.Drawing.Point(28, 156);
            this.btnRegistrarJugador.Name = "btnRegistrarJugador";
            this.btnRegistrarJugador.Size = new System.Drawing.Size(91, 29);
            this.btnRegistrarJugador.TabIndex = 4;
            this.btnRegistrarJugador.Text = "Registrar";
            this.btnRegistrarJugador.UseVisualStyleBackColor = true;
            this.btnRegistrarJugador.Click += new System.EventHandler(this.btnRegistrarJugador_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(245, 156);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 29);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvJugadores
            // 
            this.dgvJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugadores.Location = new System.Drawing.Point(12, 196);
            this.dgvJugadores.Name = "dgvJugadores";
            this.dgvJugadores.Size = new System.Drawing.Size(396, 150);
            this.dgvJugadores.TabIndex = 6;
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(152, 32);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(100, 20);
            this.tbDNI.TabIndex = 7;
            // 
            // tbAlias
            // 
            this.tbAlias.Location = new System.Drawing.Point(152, 86);
            this.tbAlias.Name = "tbAlias";
            this.tbAlias.Size = new System.Drawing.Size(100, 20);
            this.tbAlias.TabIndex = 8;
            // 
            // frmJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(423, 358);
            this.Controls.Add(this.tbAlias);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.dgvJugadores);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrarJugador);
            this.Controls.Add(this.lboxVideojuegos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmJugador";
            this.Text = "Registro de Jugador";
            this.Load += new System.EventHandler(this.frmJugador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lboxVideojuegos;
        private System.Windows.Forms.Button btnRegistrarJugador;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvJugadores;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.TextBox tbAlias;
    }
}