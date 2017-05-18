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

        private void button1_Click(object sender, EventArgs e)
        {
            int numero, i, j;
            string resultado="";

            numero = int.Parse(textBox1.Text);


            if (numero >= 1 && numero <= 15)
            {

                for (i = 1; i <= numero; i++)
                {
                    for (j = 1; j <= 10; j++)
                    {
                        resultado = resultado + j+",";
                    }
                    resultado = resultado + "\n";
                }
                MessageBox.Show(resultado);
            }
            else
            {

                MessageBox.Show("Numero mal introducido");
            }

            






        }
    }
}
