using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        /// <summary>
        /// llama a una aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta apliación calcula si el número introducido es primo o no");
            Aplicación_1.FrmAplicacion1 oFormulario = new Aplicación_1.FrmAplicacion1();
            oFormulario.ShowDialog();

            
         }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta apliación mostrará una cadena de numeros del 1 al 10 el numero de veces que se introduzca en el textBox, del 1 al 15");
            Aplicación_2.FrmAplicacion2 oFormulario = new Aplicación_2.FrmAplicacion2();
            oFormulario.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta apliación mostrará el resultado de realizar una operacion con bases y exponentes");
            Aplicación_3.FrmAplicacion3 oFormulario = new Aplicación_3.FrmAplicacion3();
            oFormulario.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta apliación escribe y sume la serie 3,6,9....99, teniendo en cuenta que solo puede escribir 10 números por linea.");
            Aplicación_4.FrmAplicacion4 oFormulario = new Aplicación_4.FrmAplicacion4();
            oFormulario.ShowDialog();
        }
    }
}
