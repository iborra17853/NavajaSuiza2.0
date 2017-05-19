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
        /// <summary>
        /// Llama a la aplicación 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Multiplos3(object sender, EventArgs e)
        {
            string mensaje = ClaseLogica.Apl4Lógica.multiplos3();
            MessageBox.Show(mensaje);
        }
    }
}
    

