﻿namespace NavajaSuiza.Aplicación_3
{
    partial class FrmAplicacion3
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
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TextBaseForm3 = new System.Windows.Forms.TextBox();
            this.TextExpForm3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Resultado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BaseExponente);
            // 
            // TextBaseForm3
            // 
            this.TextBaseForm3.Location = new System.Drawing.Point(101, 21);
            this.TextBaseForm3.Name = "TextBaseForm3";
            this.TextBaseForm3.Size = new System.Drawing.Size(100, 20);
            this.TextBaseForm3.TabIndex = 1;
            this.TextBaseForm3.TextChanged += new System.EventHandler(this.TextBaseForm3_TextChanged);
            this.TextBaseForm3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBaseForm3_KeyPress);
            // 
            // TextExpForm3
            // 
            this.TextExpForm3.Location = new System.Drawing.Point(101, 99);
            this.TextExpForm3.Name = "TextExpForm3";
            this.TextExpForm3.Size = new System.Drawing.Size(100, 20);
            this.TextExpForm3.TabIndex = 2;
            this.TextExpForm3.TextChanged += new System.EventHandler(this.TextExpForm3_TextChanged);
            this.TextExpForm3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextExpForm3_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Base";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Exponente";
            // 
            // FrmAplicacion3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextExpForm3);
            this.Controls.Add(this.TextBaseForm3);
            this.Controls.Add(this.button1);
            this.Name = "FrmAplicacion3";
            this.Text = "Base Exponente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox TextBaseForm3;
        private System.Windows.Forms.TextBox TextExpForm3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

