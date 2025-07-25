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
            this.btncopiar = new System.Windows.Forms.Button();
            this.txtpantalla = new System.Windows.Forms.TextBox();
            this.panelnumerico = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnmult = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnporcent = new System.Windows.Forms.Button();
            this.btnoff = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.btncopiar);
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
            this.lblnum1.Visible = false;
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
            this.lbloperacion.Visible = false;
            // 
            // btncopiar
            // 
            this.btncopiar.BackgroundImage = global::CursoCsharp.Properties.Resources.copia1;
            this.btncopiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncopiar.FlatAppearance.BorderSize = 0;
            this.btncopiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btncopiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btncopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncopiar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncopiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncopiar.Location = new System.Drawing.Point(280, 153);
            this.btncopiar.Name = "btncopiar";
            this.btncopiar.Size = new System.Drawing.Size(25, 27);
            this.btncopiar.TabIndex = 0;
            this.btncopiar.UseVisualStyleBackColor = true;
            this.btncopiar.Click += new System.EventHandler(this.btncopiar_Click);
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
            this.flowLayoutPanel2.Controls.Add(this.btnmult);
            this.flowLayoutPanel2.Controls.Add(this.btnresta);
            this.flowLayoutPanel2.Controls.Add(this.btnsuma);
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
            // btnmult
            // 
            this.btnmult.BackgroundImage = global::CursoCsharp.Properties.Resources.circuloNaranja;
            this.btnmult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmult.FlatAppearance.BorderSize = 0;
            this.btnmult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnmult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmult.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmult.Location = new System.Drawing.Point(3, 52);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(44, 43);
            this.btnmult.TabIndex = 3;
            this.btnmult.Text = "X";
            this.btnmult.UseVisualStyleBackColor = true;
            this.btnmult.Click += new System.EventHandler(this.btnmult_Click);
            // 
            // btnresta
            // 
            this.btnresta.BackgroundImage = global::CursoCsharp.Properties.Resources.circuloNaranja;
            this.btnresta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnresta.FlatAppearance.BorderSize = 0;
            this.btnresta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnresta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnresta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnresta.Location = new System.Drawing.Point(3, 101);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(44, 43);
            this.btnresta.TabIndex = 3;
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = true;
            this.btnresta.Click += new System.EventHandler(this.btnresta_Click);
            // 
            // btnsuma
            // 
            this.btnsuma.BackgroundImage = global::CursoCsharp.Properties.Resources.circuloNaranja;
            this.btnsuma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsuma.FlatAppearance.BorderSize = 0;
            this.btnsuma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnsuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsuma.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsuma.Location = new System.Drawing.Point(3, 150);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(44, 43);
            this.btnsuma.TabIndex = 3;
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.btnsuma_Click);
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
            this.flowLayoutPanel1.Controls.Add(this.btnborrar);
            this.flowLayoutPanel1.Controls.Add(this.btnporcent);
            this.flowLayoutPanel1.Controls.Add(this.btnoff);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(280, 191);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(145, 52);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnborrar
            // 
            this.btnborrar.BackgroundImage = global::CursoCsharp.Properties.Resources.circulogrisclaro;
            this.btnborrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnborrar.FlatAppearance.BorderSize = 0;
            this.btnborrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnborrar.Location = new System.Drawing.Point(3, 3);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(37, 40);
            this.btnborrar.TabIndex = 0;
            this.btnborrar.Text = "AC";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnporcent
            // 
            this.btnporcent.BackgroundImage = global::CursoCsharp.Properties.Resources.circulogrisclaro;
            this.btnporcent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnporcent.FlatAppearance.BorderSize = 0;
            this.btnporcent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnporcent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnporcent.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnporcent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnporcent.Location = new System.Drawing.Point(46, 3);
            this.btnporcent.Name = "btnporcent";
            this.btnporcent.Size = new System.Drawing.Size(40, 40);
            this.btnporcent.TabIndex = 1;
            this.btnporcent.Text = "%";
            this.btnporcent.UseVisualStyleBackColor = true;
            this.btnporcent.Click += new System.EventHandler(this.btnporcent_Click);
            // 
            // btnoff
            // 
            this.btnoff.BackgroundImage = global::CursoCsharp.Properties.Resources.circulogrisclaro;
            this.btnoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnoff.FlatAppearance.BorderSize = 0;
            this.btnoff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnoff.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnoff.Location = new System.Drawing.Point(92, 3);
            this.btnoff.Name = "btnoff";
            this.btnoff.Size = new System.Drawing.Size(45, 40);
            this.btnoff.TabIndex = 2;
            this.btnoff.Text = "off";
            this.btnoff.UseVisualStyleBackColor = true;
            this.btnoff.Click += new System.EventHandler(this.btnoff_Click);
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
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnporcent;
        private System.Windows.Forms.Button btnoff;
        private Button btndiv;
        private Button btnmult;
        private Button btnresta;
        private Button btnsuma;
        private Button btnigual;
        private Button btncopiar;
        private TextBox txtpantalla;
        private Label lbloperacion;
        private Label lblnum1;
    }
}
