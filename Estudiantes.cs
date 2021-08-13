using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace registro_de_notas
{
    public partial class Estudiantes : Syncfusion.Windows.Forms.Office2010Form
    {
        
        public Estudiantes()
        {
            InitializeComponent();
        }

        private string operacion = string.Empty;
        private void button3_Click(object sender, EventArgs e)

        {
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Apellido", "Apellido");
            dataGridView1.Columns.Add("Grado", "Grado");
            dataGridView1.Columns.Add("Seccion", "Seccion");
            dataGridView1.Columns.Add("1 Parcial", "1 Parcial");
            dataGridView1.Columns.Add("2 Parcial", "2 Parcial");
            dataGridView1.Columns.Add("3 Parcial", "3 Parcial");
            dataGridView1.Columns.Add("4 Parcial", "1 Parcial");
            dataGridView1.Columns.Add("NotaFinal", "NotaFinal");

            dataGridView1.Rows.Add(nombre_textBox.Text, apellido_textBox.Text, grado_textBox.Text, seccion_textBox.Text,textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,notafinal_textBox.Text);
            baseDatos bd = new baseDatos();
            if (operacion == "nuevo")
            {
                bd.EstudiantesDatos(nombre_textBox.Text, apellido_textBox.Text, Convert.ToInt32(grado_textBox.Text), Convert.ToInt32(seccion_textBox.Text), Convert.ToDecimal(textBox1.Text), Convert.ToDecimal(textBox2.Text), Convert.ToDecimal(textBox3.Text));



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            operacion = "nuevo";
            nombre_textBox.Clear();
            apellido_textBox.Clear();
            grado_textBox.Clear();
            seccion_textBox.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            notafinal_textBox.Clear();
            dataGridView1.Rows.Clear();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            int nota1 = 0;
            nota1 = Convert.ToInt32(textBox1.Text);
            int nota2 = 0;
            nota2 = Convert.ToInt32(textBox2.Text);
            int nota3 = 0;
            nota3 = Convert.ToInt32(textBox3.Text);
            int nota4 = 0;
            nota4 = Convert.ToInt32(textBox4.Text);

            int notafinal = 0;
            notafinal_textBox.Text = notafinal.ToString();



            if (nota1 > 100)
            {
                MessageBox.Show("Calificacion Invalida");
                MessageBox.Show("Introduzca Nuevamente");

            }

            if (nota2 > 100)
            {
                MessageBox.Show("Calificacion Invalida");
                MessageBox.Show("Introduzca Nuevamente");

            }

            if (nota3 > 100)
            {
                MessageBox.Show("Calificacion Invalida");
                MessageBox.Show("Introduzca Nuevamente");

            }


            if (nota4 > 100)
            {
                MessageBox.Show("Calificacion Invalida");
                MessageBox.Show("Introduzca Nuevamente");

            }

            notafinal = (nota1 + nota2 + nota3 + nota4) / 4;
            notafinal_textBox.Text = notafinal.ToString();
            guardar_button.Enabled = true;
        }

        private void Estudiantes_Load(object sender, EventArgs e)
        {
            guardar_button.Enabled = false;



        }



        private void textBox1_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))            {
                e.Handled = true;
            }


        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))            {
                e.Handled = true;
            }

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))            {
                e.Handled = true;
            }

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))            {
                e.Handled = true;
            }

        }

        private void nombre_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;

            }


        }

        private void grado_textBox_KeyPress(object sender, KeyPressEventArgs pE)
        {
            if (Char.IsLetter(pE.KeyChar))            {                pE.Handled = false;            }            else if (Char.IsControl(pE.KeyChar))            {                pE.Handled = false;            }            else if (Char.IsSeparator(pE.KeyChar))            {                pE.Handled = false;            }            else            {                pE.Handled = true;            }
        }

        private void seccion_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
