﻿namespace NavajaSuiza.Aplicación_2
{
    partial class FrmAplicacion2
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TextForm2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número entre 1 y 15";
            // 
            // TextForm2
            // 
            this.TextForm2.Location = new System.Drawing.Point(151, 87);
            this.TextForm2.Name = "TextForm2";
            this.TextForm2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TextForm2.Size = new System.Drawing.Size(100, 20);
            this.TextForm2.TabIndex = 1;
            this.TextForm2.TextChanged += new System.EventHandler(this.TextForm2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Resultado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Boton1al15);
            // 
            // FrmAplicacion2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextForm2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAplicacion2";
            this.Text = "Numero de 1 a 15";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextForm2;
        private System.Windows.Forms.Button button1;
    }
}

