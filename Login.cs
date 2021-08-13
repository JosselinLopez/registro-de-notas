using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace registro_de_notas
{
    public partial class Login : Syncfusion.Windows.Forms.Office2010Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (usuario_textBox .Text =="")
            {
                errorProvider1.SetError(usuario_textBox, "ingrese el usuario");
                usuario_textBox.Focus();
                return;
            }
            errorProvider1.SetError(usuario_textBox, "");

            if (contra_textBox.Text == "")
            {
                errorProvider1.SetError(contra_textBox, "ingrese la contraseña");
                contra_textBox.Focus();
                return;
            }
            errorProvider1.SetError(contra_textBox, "");


            // Canectar a la base de datos

            basedats _base = new baseDatos();

            if(_base.ValidarUsuario(usuario_textBox.Text, contra_textBox.Text))
            {

                registro formu = new registro();
                this.Hide();

                formu.Show();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña invalida");
            }


            

           
      

           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void contra_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
