using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace registro_de_notas
{
    public partial class registro : Syncfusion.Windows.Forms.Office2010Form
    {
        public registro()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Login formu = new Login();
            this.Close();

            formu.Show();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
            if (frmestudiantes == null)
            {
                frmestudiantes = new Estudiantes();
                frmestudiantes.MdiParent = this;
                frmestudiantes.FormClosed += Frmestudiantes_FormClosed;
                frmestudiantes.Show();
            }
            else
            {
                frmestudiantes.Activate();
            }
        }

        private Estudiantes frmestudiantes;



        private void Frmestudiantes_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmestudiantes = null;
        }
    }
    
}
