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


            //string cadena = "Data Source=DESKTOP-B8OH59T; initial catalog=RegistroNotas1201; user ID=sa; password=jossy96";

            ////SqlConnection _conexion = new SqlConnection("cadena");

            //bool usuariovalido = false;

            //using (SqlConnection conexion = new SqlConnection(cadena))
            //{
            //    string consulta = "SELECT 1 FROM Usuario WHERE Codigo'" + usuario_textBox + "'AND Clave='" + contra_textBox + "';";
            //    conexion.Open();

            //    using (SqlCommand comando = new SqlCommand(consulta, conexion))
            //    {
            //        usuariovalido = Convert .ToBoolean(comando.ExecuteScalar())     ;
            //    }
            //}

            //if (usuariovalido)
            //{
            //    MessageBox.Show("Bienvenido");
            //}
            //else
            //{
            //    MessageBox.Show("usuario o contraseña incorecta");
            //}
            //    ///baseDatos _base = new baseDatos();


                registro formu = new registro();
             this.Hide();

             formu.Show();
            
      

           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void contra_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
