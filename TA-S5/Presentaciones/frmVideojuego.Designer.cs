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
            this.txtCodigoVideojuego = new System.Windows.Forms.TextBox();
            this.txtNombreVideojuego = new System.Windows.Forms.TextBox();
            this.btnRegistrarVideojuego = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvVideojuegos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideojuegos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código del Videojuego:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Videojuego:";
            // 
            // txtCodigoVideojuego
            // 
            this.txtCodigoVideojuego.Location = new System.Drawing.Point(249, 38);
            this.txtCodigoVideojuego.Name = "txtCodigoVideojuego";
            this.txtCodigoVideojuego.Size = new System.Drawing.Size(182, 22);
            this.txtCodigoVideojuego.TabIndex = 2;
            // 
            // txtNombreVideojuego
            // 
            this.txtNombreVideojuego.Location = new System.Drawing.Point(249, 90);
            this.txtNombreVideojuego.Name = "txtNombreVideojuego";
            this.txtNombreVideojuego.Size = new System.Drawing.Size(182, 22);
            this.txtNombreVideojuego.TabIndex = 3;
            // 
            // btnRegistrarVideojuego
            // 
            this.btnRegistrarVideojuego.Location = new System.Drawing.Point(57, 143);
            this.btnRegistrarVideojuego.Name = "btnRegistrarVideojuego";
            this.btnRegistrarVideojuego.Size = new System.Drawing.Size(120, 32);
            this.btnRegistrarVideojuego.TabIndex = 4;
            this.btnRegistrarVideojuego.Text = "Registrar";
            this.btnRegistrarVideojuego.UseVisualStyleBackColor = true;
            this.btnRegistrarVideojuego.Click += new System.EventHandler(this.btnRegistrarVideojuego_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(311, 143);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 32);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvVideojuegos
            // 
            this.dgvVideojuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVideojuegos.Location = new System.Drawing.Point(57, 205);
            this.dgvVideojuegos.Name = "dgvVideojuegos";
            this.dgvVideojuegos.RowHeadersWidth = 51;
            this.dgvVideojuegos.RowTemplate.Height = 24;
            this.dgvVideojuegos.Size = new System.Drawing.Size(374, 219);
            this.dgvVideojuegos.TabIndex = 6;
            // 
            // frmVideojuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.dgvVideojuegos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrarVideojuego);
            this.Controls.Add(this.txtNombreVideojuego);
            this.Controls.Add(this.txtCodigoVideojuego);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmVideojuego";
            this.Text = "Videojuegos";
            this.Load += new System.EventHandler(this.frmVideojuego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideojuegos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoVideojuego;
        private System.Windows.Forms.TextBox txtNombreVideojuego;
        private System.Windows.Forms.Button btnRegistrarVideojuego;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvVideojuegos;
    }
}