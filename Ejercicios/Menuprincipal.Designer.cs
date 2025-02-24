using System;
using System.Windows.Forms;

namespace CursoCsharp.Ejercicios
{
    partial class Menuprincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnE1 = new System.Windows.Forms.Button();
            this.btnE2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelVisor = new System.Windows.Forms.Panel();
            this.btnE3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 450);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnE1);
            this.flowLayoutPanel1.Controls.Add(this.btnE2);
            this.flowLayoutPanel1.Controls.Add(this.btnE3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(184, 410);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnE1
            // 
            this.btnE1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnE1.FlatAppearance.BorderSize = 0;
            this.btnE1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnE1.Font = new System.Drawing.Font("Consolas", 14F);
            this.btnE1.Location = new System.Drawing.Point(3, 3);
            this.btnE1.Name = "btnE1";
            this.btnE1.Size = new System.Drawing.Size(167, 88);
            this.btnE1.TabIndex = 0;
            this.btnE1.Text = "Ejercicio 1\r\n(Operadores logicos)";
            this.btnE1.UseVisualStyleBackColor = false;
            this.btnE1.Click += new System.EventHandler(this.btnE1_Click);
            // 
            // btnE2
            // 
            this.btnE2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnE2.FlatAppearance.BorderSize = 0;
            this.btnE2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnE2.Font = new System.Drawing.Font("Consolas", 14F);
            this.btnE2.Location = new System.Drawing.Point(3, 97);
            this.btnE2.Name = "btnE2";
            this.btnE2.Size = new System.Drawing.Size(167, 88);
            this.btnE2.TabIndex = 1;
            this.btnE2.Text = "Ejercicio 2\r\n(Operadores aritmeticos)";
            this.btnE2.UseVisualStyleBackColor = false;
            this.btnE2.Click += new System.EventHandler(this.btnE2_Click_1);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Consolas", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ejercicios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelVisor
            // 
            this.panelVisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVisor.Location = new System.Drawing.Point(184, 0);
            this.panelVisor.Name = "panelVisor";
            this.panelVisor.Size = new System.Drawing.Size(616, 450);
            this.panelVisor.TabIndex = 1;
            this.panelVisor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnE3
            // 
            this.btnE3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnE3.FlatAppearance.BorderSize = 0;
            this.btnE3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnE3.Font = new System.Drawing.Font("Consolas", 14F);
            this.btnE3.Location = new System.Drawing.Point(3, 191);
            this.btnE3.Name = "btnE3";
            this.btnE3.Size = new System.Drawing.Size(167, 100);
            this.btnE3.TabIndex = 2;
            this.btnE3.Text = "Ejercicio 3\r\n(Operadores logicos relacionales)";
            this.btnE3.UseVisualStyleBackColor = false;
            this.btnE3.Click += new System.EventHandler(this.btnE3_Click);
            // 
            // Menuprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelVisor);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.Name = "Menuprincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnE1;
        private System.Windows.Forms.Panel panelVisor;
        private Button btnE2;
        private Button btnE3;
    }
}