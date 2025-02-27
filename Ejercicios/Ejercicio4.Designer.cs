namespace CursoCsharp.Ejercicios
{
    partial class Ejercicio4
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblejercicio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTallaL = new System.Windows.Forms.RadioButton();
            this.rbTallaS = new System.Windows.Forms.RadioButton();
            this.rbTallaM = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbRojo = new System.Windows.Forms.RadioButton();
            this.rbBlanco = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblejercicio
            // 
            this.lblejercicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblejercicio.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.lblejercicio.ForeColor = System.Drawing.Color.White;
            this.lblejercicio.Location = new System.Drawing.Point(0, 0);
            this.lblejercicio.Name = "lblejercicio";
            this.lblejercicio.Size = new System.Drawing.Size(866, 58);
            this.lblejercicio.TabIndex = 9;
            this.lblejercicio.Text = "Ejercicio 4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::CursoCsharp.Properties.Resources.Captura_de_pantalla_2025_02_26_210414;
            this.pictureBox1.Location = new System.Drawing.Point(0, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(866, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(305, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Casacas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTallaL);
            this.groupBox1.Controls.Add(this.rbTallaS);
            this.groupBox1.Controls.Add(this.rbTallaM);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(26, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 133);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Talla";
            // 
            // rbTallaL
            // 
            this.rbTallaL.AutoSize = true;
            this.rbTallaL.Location = new System.Drawing.Point(7, 25);
            this.rbTallaL.Name = "rbTallaL";
            this.rbTallaL.Size = new System.Drawing.Size(99, 24);
            this.rbTallaL.TabIndex = 14;
            this.rbTallaL.TabStop = true;
            this.rbTallaL.Text = "L ($ 200)";
            this.rbTallaL.UseVisualStyleBackColor = true;
            // 
            // rbTallaS
            // 
            this.rbTallaS.AutoSize = true;
            this.rbTallaS.Location = new System.Drawing.Point(7, 85);
            this.rbTallaS.Name = "rbTallaS";
            this.rbTallaS.Size = new System.Drawing.Size(86, 24);
            this.rbTallaS.TabIndex = 13;
            this.rbTallaS.TabStop = true;
            this.rbTallaS.Text = "S ($50)";
            this.rbTallaS.UseVisualStyleBackColor = true;
            // 
            // rbTallaM
            // 
            this.rbTallaM.AutoSize = true;
            this.rbTallaM.Location = new System.Drawing.Point(7, 55);
            this.rbTallaM.Name = "rbTallaM";
            this.rbTallaM.Size = new System.Drawing.Size(103, 24);
            this.rbTallaM.TabIndex = 0;
            this.rbTallaM.TabStop = true;
            this.rbTallaM.Text = "M ($ 100)";
            this.rbTallaM.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbRojo);
            this.groupBox2.Controls.Add(this.rbBlanco);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(380, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 133);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colores";
            // 
            // rbRojo
            // 
            this.rbRojo.AutoSize = true;
            this.rbRojo.Location = new System.Drawing.Point(7, 65);
            this.rbRojo.Name = "rbRojo";
            this.rbRojo.Size = new System.Drawing.Size(75, 24);
            this.rbRojo.TabIndex = 14;
            this.rbRojo.TabStop = true;
            this.rbRojo.Text = "ROJO";
            this.rbRojo.UseVisualStyleBackColor = true;
            // 
            // rbBlanco
            // 
            this.rbBlanco.AutoSize = true;
            this.rbBlanco.Location = new System.Drawing.Point(7, 25);
            this.rbBlanco.Name = "rbBlanco";
            this.rbBlanco.Size = new System.Drawing.Size(98, 24);
            this.rbBlanco.TabIndex = 0;
            this.rbBlanco.TabStop = true;
            this.rbBlanco.Text = "BLANCO";
            this.rbBlanco.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Yellow;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(686, 314);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(123, 52);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDetalle
            // 
            this.txtDetalle.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDetalle.Location = new System.Drawing.Point(26, 415);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetalle.Size = new System.Drawing.Size(619, 100);
            this.txtDetalle.TabIndex = 14;
            // 
            // Ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblejercicio);
            this.Name = "Ejercicio4";
            this.Size = new System.Drawing.Size(866, 535);
            this.Load += new System.EventHandler(this.Ejercicio4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblejercicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTallaL;
        private System.Windows.Forms.RadioButton rbTallaS;
        private System.Windows.Forms.RadioButton rbTallaM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbRojo;
        private System.Windows.Forms.RadioButton rbBlanco;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDetalle;
    }
}
