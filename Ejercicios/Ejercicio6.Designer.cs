using System.Windows.Forms;

namespace CursoCsharp.Ejercicios
{
    partial class Ejercicio6
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblejercicio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lbloperacion = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.txtpantalla = new System.Windows.Forms.TextBox();
            this.panelnumerico = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btndiv = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lblejercicio
            // 
            this.lblejercicio.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblejercicio.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblejercicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblejercicio.Location = new System.Drawing.Point(0, 0);
            this.lblejercicio.Name = "lblejercicio";
            this.lblejercicio.Size = new System.Drawing.Size(150, 531);
            this.lblejercicio.TabIndex = 1;
            this.lblejercicio.Text = "Ejercicio6";
            this.lblejercicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CursoCsharp.Properties.Resources.celular1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.lblnum1);
            this.panel1.Controls.Add(this.lbloperacion);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.txtpantalla);
            this.panel1.Controls.Add(this.panelnumerico);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(150, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 531);
            this.panel1.TabIndex = 2;
            // 
            // lblnum1
            // 
            this.lblnum1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum1.ForeColor = System.Drawing.Color.White;
            this.lblnum1.Location = new System.Drawing.Point(371, 88);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(110, 26);
            this.lblnum1.TabIndex = 4;
            this.lblnum1.Text = "0";
            this.lblnum1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbloperacion
            // 
            this.lbloperacion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloperacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbloperacion.Location = new System.Drawing.Point(371, 124);
            this.lbloperacion.Name = "lbloperacion";
            this.lbloperacion.Size = new System.Drawing.Size(110, 26);
            this.lbloperacion.TabIndex = 4;
            this.lbloperacion.Text = "0";
            this.lbloperacion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::CursoCsharp.Properties.Resources.copia1;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(280, 153);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(25, 27);
            this.button9.TabIndex = 0;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // txtpantalla
            // 
            this.txtpantalla.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtpantalla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpantalla.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpantalla.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtpantalla.Location = new System.Drawing.Point(326, 153);
            this.txtpantalla.Name = "txtpantalla";
            this.txtpantalla.ReadOnly = true;
            this.txtpantalla.Size = new System.Drawing.Size(155, 32);
            this.txtpantalla.TabIndex = 3;
            this.txtpantalla.Text = "0";
            this.txtpantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panelnumerico
            // 
            this.panelnumerico.Location = new System.Drawing.Point(280, 249);
            this.panelnumerico.Name = "panelnumerico";
            this.panelnumerico.Size = new System.Drawing.Size(145, 228);
            this.panelnumerico.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btndiv);
            this.flowLayoutPanel2.Controls.Add(this.button5);
            this.flowLayoutPanel2.Controls.Add(this.button6);
            this.flowLayoutPanel2.Controls.Add(this.button7);
            this.flowLayoutPanel2.Controls.Add(this.btnigual);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(431, 191);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(50, 286);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btndiv
            // 
            this.btndiv.BackgroundImage = global::CursoCsharp.Properties.Resources.circuloNaranja;
            this.btndiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndiv.FlatAppearance.BorderSize = 0;
            this.btndiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btndiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndiv.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndiv.Location = new System.Drawing.Point(3, 3);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(44, 43);
            this.btndiv.TabIndex = 3;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::CursoCsharp.Properties.Resources.circuloNaranja;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(3, 52);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 43);
            this.button5.TabIndex = 3;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::CursoCsharp.Properties.Resources.circuloNaranja;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(3, 101);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(44, 43);
            this.button6.TabIndex = 3;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::CursoCsharp.Properties.Resources.circuloNaranja;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(3, 150);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(44, 43);
            this.button7.TabIndex = 3;
            this.button7.Text = "+";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btnigual
            // 
            this.btnigual.BackgroundImage = global::CursoCsharp.Properties.Resources.circuloNaranja;
            this.btnigual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnigual.FlatAppearance.BorderSize = 0;
            this.btnigual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnigual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnigual.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnigual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnigual.Location = new System.Drawing.Point(3, 199);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(44, 43);
            this.btnigual.TabIndex = 3;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = true;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(280, 191);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(145, 52);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CursoCsharp.Properties.Resources.circulogrisclaro;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "AC";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::CursoCsharp.Properties.Resources.circulogrisclaro;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(46, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "%";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::CursoCsharp.Properties.Resources.circulogrisclaro;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(92, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "off";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Ejercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblejercicio);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Ejercicio6";
            this.Size = new System.Drawing.Size(996, 531);
            this.Load += new System.EventHandler(this.Ejercicio6_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblejercicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel panelnumerico;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Button btndiv;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button btnigual;
        private Button button9;
        private TextBox txtpantalla;
        private Label lbloperacion;
        private Label lblnum1;
    }
}
