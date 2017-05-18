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

        private void BaseExponente(object sender, EventArgs e)
        {
            int numero, exponente, resultado, i;

            numero = int.Parse(TextBaseForm3.Text);
            exponente = int.Parse(TextExpForm3.Text);
            resultado = 1;
            i = 1;


            if (numero > 0)

                for (i = 1; i <= exponente; i++)
                {

                    resultado = resultado * numero;
                }
            MessageBox.Show("El resultado es" + " " + resultado);
        }

        private void TextBaseForm3_TextChanged(object sender, EventArgs e)
        {
            TextBaseForm3.MaxLength = 4;

        }

        private void TextExpForm3_TextChanged(object sender, EventArgs e)
        {
            TextExpForm3.MaxLength = 4;

        }
    }
}
