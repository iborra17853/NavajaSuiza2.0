using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza.Aplicación_4
{
    public partial class FrmAplicacion4 : Form
    {
        public FrmAplicacion4()
        {
            InitializeComponent();
        }

        private void BBserie_Click(object sender, EventArgs e)
        {
            int i, suma, contNum;
            string texto;

            i = 3;
            suma = 0;
            contNum = 0;
            texto = "";

            while (i <= 100)
            {
                if (contNum == 10)
                {
                    contNum = 0;
                    texto = texto + "\n";
                }
                if (i % 3 == 0)
                {
                    texto = texto + i + ", ";
                    suma = suma + i;
                    contNum++;
                }
                i = i + 1;          
            }
            MessageBox.Show("Los múltiplos de 3 son: " +"\n" + texto + "y la suma de todos es: " + suma);
        }
    }
}
