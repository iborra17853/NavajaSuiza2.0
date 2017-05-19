using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza.Aplicación_1
{
    public partial class FrmAplicacion1 : Form
    {
        public FrmAplicacion1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Llama a la aplicacion 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonPrimos(object sender, EventArgs e)
        {
            string mensaje = ClaseLogica.Apl1Lógica.EsONoPrimo(int.Parse(TextForm1.Text));
            MessageBox.Show(mensaje);

        }
        /// <summary>
        /// Limitamos el textBox a 5 caracteres como maximo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextForm1_TextChanged(object sender, EventArgs e)
        {
            TextForm1.MaxLength = 5;
        }
        /// <summary>
        /// Prohibmos que nos puedan insertar letras, para asegurarnos que son números
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextForm1_KeyPress(object sender, KeyPressEventArgs e)
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
