namespace NavajaSuiza.Aplicación_4
{
    partial class FrmAplicacion4
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
            this.BBserie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BBserie
            // 
            this.BBserie.Location = new System.Drawing.Point(198, 147);
            this.BBserie.Name = "BBserie";
            this.BBserie.Size = new System.Drawing.Size(151, 98);
            this.BBserie.TabIndex = 0;
            this.BBserie.Text = "Serie y suma de múltiplos de 3";
            this.BBserie.UseVisualStyleBackColor = true;
            this.BBserie.Click += new System.EventHandler(this.BBserie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 389);
            this.Controls.Add(this.BBserie);
            this.Name = "Form1";
            this.Text = "Ejercicio 26";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BBserie;
    }
}

