﻿using System;
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

        private void BotonPrimos(object sender, EventArgs e)
        {
            int numero, contador, i;
            contador = 0;
            i = 1;
            numero = int.Parse(TextForm1.Text);
            while (i <= numero)
            {
                if (numero % i == 0)
                    {
                    contador = contador + 1;
                }
                i = i + 1;
            }
            if (contador > 2)
            {
                MessageBox.Show("El numero introducido no es primo");
            }
            else
            {
                MessageBox.Show("El numero introducido si que es primo");
            }
                     
        }

        private void TextForm1_TextChanged(object sender, EventArgs e)
        {
            TextForm1.MaxLength = 5;
        }
    }
}
