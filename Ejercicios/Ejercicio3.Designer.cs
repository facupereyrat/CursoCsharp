namespace CursoCsharp.Ejercicios
{
    partial class Ejercicio3
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
            this.lbl3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbla = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblcondicion = new System.Windows.Forms.TextBox();
            this.lblimc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btncalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl3
            // 
            this.lbl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl3.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(0, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(1027, 58);
            this.lbl3.TabIndex = 8;
            this.lbl3.Text = "Ejercicio 3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbla);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblcondicion);
            this.panel1.Controls.Add(this.lblimc);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.btncalcular);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.txtaltura);
            this.panel1.Controls.Add(this.txtpeso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 196);
            this.panel1.TabIndex = 11;
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbla.ForeColor = System.Drawing.Color.White;
            this.lbla.Location = new System.Drawing.Point(73, 157);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(100, 22);
            this.lbla.TabIndex = 3;
            this.lbla.Text = "Condicion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(133, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "imc";
            // 
            // lblcondicion
            // 
            this.lblcondicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblcondicion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblcondicion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblcondicion.Location = new System.Drawing.Point(179, 163);
            this.lblcondicion.Name = "lblcondicion";
            this.lblcondicion.Size = new System.Drawing.Size(126, 13);
            this.lblcondicion.TabIndex = 5;
            // 
            // lblimc
            // 
            this.lblimc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblimc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblimc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblimc.Location = new System.Drawing.Point(179, 130);
            this.lblimc.Name = "lblimc";
            this.lblimc.Size = new System.Drawing.Size(126, 13);
            this.lblimc.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(73, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Altura(m)";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(105, 111);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 2);
            this.panel7.TabIndex = 10;
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.Yellow;
            this.btncalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(324, 58);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(123, 52);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Peso(kg)";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(105, 65);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 2);
            this.panel6.TabIndex = 10;
            // 
            // txtaltura
            // 
            this.txtaltura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtaltura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtaltura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtaltura.Location = new System.Drawing.Point(179, 97);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(126, 13);
            this.txtaltura.TabIndex = 5;
            // 
            // txtpeso
            // 
            this.txtpeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtpeso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpeso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtpeso.Location = new System.Drawing.Point(179, 49);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(126, 13);
            this.txtpeso.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(0, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1027, 58);
            this.label2.TabIndex = 10;
            this.label2.Text = "Solucion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::CursoCsharp.Properties.Resources.Ejercicio_3;
            this.pictureBox1.Location = new System.Drawing.Point(0, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1027, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl3);
            this.Name = "Ejercicio3";
            this.Size = new System.Drawing.Size(1027, 545);
            this.Load += new System.EventHandler(this.Ejercicio3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lblcondicion;
        private System.Windows.Forms.TextBox lblimc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtaltura;
    }
}
