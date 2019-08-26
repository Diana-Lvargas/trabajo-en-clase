using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace actividad2
{
    public partial class ventana_2 : Form
    {
        public ventana_2()
        {
            InitializeComponent();
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formulario = new Form1();
            formulario.Visible = true;
        }

        private void Btncerrar_Click(object sender, EventArgs e)
        {

        }

        private void Btncomprar_Click(object sender, EventArgs e)
        {
            int conteo = 0;
            string seleccion;
            if(visualc.Checked == true)
            {
                conteo++;

            }
            if(visualb.Checked == true)
            {
                conteo++;
            }
            if (tarjeta.Checked==true)
            {
                seleccion = "tarjeta de credito";
            }
            else
            {
                seleccion = "PayPal";
            }
            MessageBox.Show("has seleccionado" + conteo + "curso y tu metodo de pago es " + seleccion);
        }
    }
}
