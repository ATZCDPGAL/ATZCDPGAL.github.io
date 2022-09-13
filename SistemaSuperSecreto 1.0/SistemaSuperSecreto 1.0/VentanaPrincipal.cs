using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaSuperSecreto_1._0
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formulario = new Form1();
            formulario.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btncomprar_Click(object sender, EventArgs e)
        {
            int conteo = 0;
            string seleccion;
            if (cbvisualc.Checked==true)
            {
                conteo++;
            }
            if (cbvisualbasic.Checked ==true)
            {
                conteo++;
            }
            if (rdtarjeta.Checked == true)
            {
                seleccion = "Tarjeta de Credito";
            }
            else
            {
                seleccion = "Paypal";
            }
            MessageBox.Show("Haz seleccionado " + conteo + " cursos y su metodo de pago es mediante " + seleccion);
        }
    }
}
