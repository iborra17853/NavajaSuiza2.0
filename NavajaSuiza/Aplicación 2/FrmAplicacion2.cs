using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza.Aplicación_2
{
    public partial class FrmAplicacion2 : Form
    {
        public FrmAplicacion2()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Llama a la aplicacion 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Boton1al15(object sender, EventArgs e)
        {
            string mensaje = ClaseLogica.Apl2Lógica.contar15(int.Parse(TextForm2.Text));
            MessageBox.Show(mensaje);
        }
        /// <summary>
        /// maximo tamaño del textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextForm2_TextChanged(object sender, EventArgs e)
        {
            TextForm2.MaxLength = 2;
        }
        /// <summary>
        /// Permite solo numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextForm2_KeyPress(object sender, KeyPressEventArgs e)
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
