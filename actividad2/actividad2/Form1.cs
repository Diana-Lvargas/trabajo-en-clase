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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();//cierra el formulario
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (usuario.Text == "juancho" && clave.Text == "123tamarindo")
            {
                MessageBox.Show("bienvenido Sr juancho");
                this.Hide();//escondemos ventana login
                ventana_2 CursosVentana = new ventana_2();
                CursosVentana.Show();
                this.Visible = false;

            }
            else
            {
                MessageBox.Show("Usuario o contraseña no valida");
                usuario.Text = "";
                clave.Text = "";
                usuario.Focus();

            }
        }

        private void Clave_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (usuario.Text == "juancho" && clave.Text == "123tamarindo")
                {
                    MessageBox.Show("bienvenido Sr juancho");
                    this.Hide();//escondemos ventana login
                    ventana_2 CursosVentana = new ventana_2();
                    CursosVentana.Show();
                    this.Visible = false;

                }
                else
                {
                    MessageBox.Show("Usuario o contraseña no valida");
                    usuario.Text = "";
                    clave.Text = "";
                    usuario.Focus();
                }



            }
        }

        private void Usuario_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                clave.Focus();
            }
        }
    }
}
