using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Formulario
{
    public partial class TrapecioSimple : Form
    {
        public TrapecioSimple(Datos datos)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "" && this.textBox2.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
            }
            else
            {
                Datos nuevosdatos = new Datos();
                nuevosdatos.ValorXA = Convert.ToDouble(this.textBox1.Text);
                nuevosdatos.ValorXB = Convert.ToDouble(this.textBox2.Text);

                FormularioPrincipal formu = this.Owner as FormularioPrincipal;
                if (formu != null)
                {
                    double variable = formu.MetodoTrapezoideSimple(nuevosdatos);
                    string vari = "";
                    vari = Convert.ToString("SOLUCION AREA: " + variable);
                    MessageBox.Show(vari);
                }
            }
        }
    }
}


