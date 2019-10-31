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
    public partial class Form1 : Form, FormularioPrincipal
    {
        public Principal Principal { get; set; }

        public Form1()
        {
            InitializeComponent();
            Principal = new Principal();
        }

        public double MetodoSimpsonMultipleUnTercio(Datos dato, int Nintervalos)
        {
            return Principal.MetodoSimpsonMultipleUnTercio(dato, Nintervalos);
        }

        public double MetodoSimpsonSimpleUnTercio(Datos dato)
        {
            return Principal.MetodoSimpsonSimpleUnTercio(dato);
        }

        public double MetodoSimpsonTresOctavos(Datos dato)
        {
            return Principal.MetodoSimpsonTresOctavos(dato);
        }

        public double MetodoTrapezoideMultiple(Datos dato, int Nintervalos)
        {
            return Principal.MetodoTrapezoideMultiple(dato, Nintervalos);
        }

        public double MetodoTrapezoideSimple(Datos dato)
        {
            return Principal.MetodoTrapezoideSimple(dato);
        }

        private void TrapezoideSimple_Click(object sender, EventArgs e)
        {
            TrapecioSimple nuevo = new TrapecioSimple(new Datos());
            nuevo.Owner = this;
            nuevo.ShowDialog();
        }

        private void TrapezoideMultiple_Click(object sender, EventArgs e)
        {
            TrapecioMultiple nuevo = new TrapecioMultiple(new Datos());
            nuevo.Owner = this;
            nuevo.ShowDialog();
        }

        private void SimpsonSimpleUnTercio_Click(object sender, EventArgs e)
        {
            SimpsonUnTercioSimple nuevo = new SimpsonUnTercioSimple(new Datos());
            nuevo.Owner = this;
            nuevo.ShowDialog();
        }

        private void SimpsonMultipleUnTercio_Click(object sender, EventArgs e)
        {
            SimpsonUnTercioMultiple nuevo = new SimpsonUnTercioMultiple(new Datos());
            nuevo.Owner = this;
            nuevo.ShowDialog();
        }

        private void SimpsonTresOctavos_Click(object sender, EventArgs e)
        {
            SimpsonTresOctavos nuevo = new SimpsonTresOctavos(new Datos());
            nuevo.Owner = this;
            nuevo.ShowDialog();
        }
    }
}
