namespace TA_S5.Presentaciones
{
    partial class frmVideojuego
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
            this.tbCodigoVideojuego = new System.Windows.Forms.TextBox();
            this.tbNombreVideojuego = new System.Windows.Forms.TextBox();
            this.btnRegistrarVideojuego = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvVideojuegos = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideojuegos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código del Videojuego:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Videojuego:";
            // 
            // tbCodigoVideojuego
            // 
            this.tbCodigoVideojuego.Location = new System.Drawing.Point(187, 31);
            this.tbCodigoVideojuego.Margin = new System.Windows.Forms.Padding(2);
            this.tbCodigoVideojuego.Name = "tbCodigoVideojuego";
            this.tbCodigoVideojuego.Size = new System.Drawing.Size(138, 20);
            this.tbCodigoVideojuego.TabIndex = 2;
            // 
            // tbNombreVideojuego
            // 
            this.tbNombreVideojuego.Location = new System.Drawing.Point(187, 73);
            this.tbNombreVideojuego.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombreVideojuego.Name = "tbNombreVideojuego";
            this.tbNombreVideojuego.Size = new System.Drawing.Size(138, 20);
            this.tbNombreVideojuego.TabIndex = 3;
            // 
            // btnRegistrarVideojuego
            // 
            this.btnRegistrarVideojuego.Location = new System.Drawing.Point(43, 116);
            this.btnRegistrarVideojuego.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarVideojuego.Name = "btnRegistrarVideojuego";
            this.btnRegistrarVideojuego.Size = new System.Drawing.Size(90, 26);
            this.btnRegistrarVideojuego.TabIndex = 4;
            this.btnRegistrarVideojuego.Text = "Registrar";
            this.btnRegistrarVideojuego.UseVisualStyleBackColor = true;
            this.btnRegistrarVideojuego.Click += new System.EventHandler(this.btnRegistrarVideojuego_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(233, 116);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 26);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvVideojuegos
            // 
            this.dgvVideojuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVideojuegos.Location = new System.Drawing.Point(43, 167);
            this.dgvVideojuegos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVideojuegos.Name = "dgvVideojuegos";
            this.dgvVideojuegos.RowHeadersWidth = 51;
            this.dgvVideojuegos.RowTemplate.Height = 24;
            this.dgvVideojuegos.Size = new System.Drawing.Size(280, 178);
            this.dgvVideojuegos.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(43, 356);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 26);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(248, 356);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 26);
            this.btnMostrar.TabIndex = 8;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // frmVideojuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(371, 391);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgvVideojuegos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrarVideojuego);
            this.Controls.Add(this.tbNombreVideojuego);
            this.Controls.Add(this.tbCodigoVideojuego);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmVideojuego";
            this.Text = "Registro de Videojuego";
            this.Load += new System.EventHandler(this.frmVideojuego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideojuegos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCodigoVideojuego;
        private System.Windows.Forms.TextBox tbNombreVideojuego;
        private System.Windows.Forms.Button btnRegistrarVideojuego;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvVideojuegos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnMostrar;
    }
}