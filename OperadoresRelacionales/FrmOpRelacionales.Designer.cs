namespace CursoCsharp.OperadoresRelacionales
{
    partial class FrmOpRelacionales
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnmayor = new System.Windows.Forms.Button();
            this.btnmenor = new System.Windows.Forms.Button();
            this.btnmenorigual = new System.Windows.Forms.Button();
            this.btnmayorigual = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.btndiferente = new System.Windows.Forms.Button();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblresultado = new System.Windows.Forms.Label();
            this.lblnumero2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnumero1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnmayor);
            this.flowLayoutPanel1.Controls.Add(this.btnmenor);
            this.flowLayoutPanel1.Controls.Add(this.btnmenorigual);
            this.flowLayoutPanel1.Controls.Add(this.btnmayorigual);
            this.flowLayoutPanel1.Controls.Add(this.btnigual);
            this.flowLayoutPanel1.Controls.Add(this.btndiferente);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(216, 241);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(373, 45);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // btnmayor
            // 
            this.btnmayor.BackColor = System.Drawing.Color.Yellow;
            this.btnmayor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmayor.Location = new System.Drawing.Point(3, 3);
            this.btnmayor.Name = "btnmayor";
            this.btnmayor.Size = new System.Drawing.Size(56, 38);
            this.btnmayor.TabIndex = 0;
            this.btnmayor.Text = ">";
            this.btnmayor.UseVisualStyleBackColor = false;
            this.btnmayor.Click += new System.EventHandler(this.btnmayor_Click);
            // 
            // btnmenor
            // 
            this.btnmenor.BackColor = System.Drawing.Color.OrangeRed;
            this.btnmenor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenor.Location = new System.Drawing.Point(65, 3);
            this.btnmenor.Name = "btnmenor";
            this.btnmenor.Size = new System.Drawing.Size(56, 38);
            this.btnmenor.TabIndex = 0;
            this.btnmenor.Text = "<";
            this.btnmenor.UseVisualStyleBackColor = false;
            this.btnmenor.Click += new System.EventHandler(this.btnmenor_Click);
            // 
            // btnmenorigual
            // 
            this.btnmenorigual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnmenorigual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmenorigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenorigual.Location = new System.Drawing.Point(127, 3);
            this.btnmenorigual.Name = "btnmenorigual";
            this.btnmenorigual.Size = new System.Drawing.Size(56, 38);
            this.btnmenorigual.TabIndex = 0;
            this.btnmenorigual.Text = "<=";
            this.btnmenorigual.UseVisualStyleBackColor = false;
            this.btnmenorigual.Click += new System.EventHandler(this.btnmenorigual_Click);
            // 
            // btnmayorigual
            // 
            this.btnmayorigual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnmayorigual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmayorigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmayorigual.Location = new System.Drawing.Point(189, 3);
            this.btnmayorigual.Name = "btnmayorigual";
            this.btnmayorigual.Size = new System.Drawing.Size(56, 38);
            this.btnmayorigual.TabIndex = 0;
            this.btnmayorigual.Text = ">=";
            this.btnmayorigual.UseVisualStyleBackColor = false;
            this.btnmayorigual.Click += new System.EventHandler(this.btnmayorigual_Click);
            // 
            // btnigual
            // 
            this.btnigual.BackColor = System.Drawing.Color.Yellow;
            this.btnigual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnigual.Location = new System.Drawing.Point(251, 3);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(56, 38);
            this.btnigual.TabIndex = 1;
            this.btnigual.Text = "==";
            this.btnigual.UseVisualStyleBackColor = false;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // btndiferente
            // 
            this.btndiferente.BackColor = System.Drawing.Color.OrangeRed;
            this.btndiferente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndiferente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiferente.Location = new System.Drawing.Point(313, 3);
            this.btndiferente.Name = "btndiferente";
            this.btndiferente.Size = new System.Drawing.Size(56, 38);
            this.btndiferente.TabIndex = 2;
            this.btndiferente.Text = "!=";
            this.btndiferente.UseVisualStyleBackColor = false;
            this.btndiferente.Click += new System.EventHandler(this.btndiferente_Click);
            // 
            // txtnumero2
            // 
            this.txtnumero2.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtnumero2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnumero2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtnumero2.Location = new System.Drawing.Point(318, 167);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(200, 13);
            this.txtnumero2.TabIndex = 20;
            // 
            // txtresultado
            // 
            this.txtresultado.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtresultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtresultado.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtresultado.Location = new System.Drawing.Point(318, 366);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(200, 13);
            this.txtresultado.TabIndex = 21;
            // 
            // txtnumero1
            // 
            this.txtnumero1.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtnumero1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnumero1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtnumero1.Location = new System.Drawing.Point(318, 130);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(200, 13);
            this.txtnumero1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(318, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 2);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(318, 380);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 2);
            this.panel3.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(318, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 2);
            this.panel1.TabIndex = 25;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.ForeColor = System.Drawing.Color.White;
            this.lblresultado.Location = new System.Drawing.Point(212, 361);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(110, 22);
            this.lblresultado.TabIndex = 18;
            this.lblresultado.Text = "Resultado:";
            // 
            // lblnumero2
            // 
            this.lblnumero2.AutoSize = true;
            this.lblnumero2.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero2.ForeColor = System.Drawing.Color.White;
            this.lblnumero2.Location = new System.Drawing.Point(212, 161);
            this.lblnumero2.Name = "lblnumero2";
            this.lblnumero2.Size = new System.Drawing.Size(100, 22);
            this.lblnumero2.TabIndex = 19;
            this.lblnumero2.Text = "Numero 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(212, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Operadores Relacionales";
            // 
            // lblnumero1
            // 
            this.lblnumero1.AutoSize = true;
            this.lblnumero1.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero1.ForeColor = System.Drawing.Color.White;
            this.lblnumero1.Location = new System.Drawing.Point(212, 127);
            this.lblnumero1.Name = "lblnumero1";
            this.lblnumero1.Size = new System.Drawing.Size(100, 22);
            this.lblnumero1.TabIndex = 17;
            this.lblnumero1.Text = "Numero 1:";
            // 
            // FrmOpRelacionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtnumero1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblnumero2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblnumero1);
            this.Name = "FrmOpRelacionales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOpRelacionales";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FrmOpRelacionales_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnmayor;
        private System.Windows.Forms.Button btnmenor;
        private System.Windows.Forms.Button btnmenorigual;
        private System.Windows.Forms.Button btnmayorigual;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.Button btndiferente;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label lblnumero2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnumero1;
    }
}