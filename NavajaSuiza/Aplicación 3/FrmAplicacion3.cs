using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza.Aplicación_3
{
    public partial class FrmAplicacion3 : Form
    {
        public FrmAplicacion3()
        {
            InitializeComponent();
        }
        /// <summary>
        /// LLama a la aplicacion 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BaseExponente(object sender, EventArgs e)
        {
            
            string mensaje = ClaseLogica.Apl3Lógica.BaseExponente(int.Parse(TextBaseForm3.Text), int.Parse(TextExpForm3.Text));
            MessageBox.Show(mensaje);

        }

        private void TextBaseForm3_TextChanged(object sender, EventArgs e)
        {
            TextBaseForm3.MaxLength = 4;

        }
        /// <summary>
        /// valor 4 como máxima longitud del textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextExpForm3_TextChanged(object sender, EventArgs e)
        {
            TextExpForm3.MaxLength = 4;

        }
        /// <summary>
        /// Evitamos que introduzcan letras, solo números
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextExpForm3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Introducir solo numeros");
            }
        }
             private void TextBaseForm3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Introducir solo numeros");
            }
        }
    }
}
