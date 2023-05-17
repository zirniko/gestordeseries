using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeriesAnimeBBDD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            Registro r = new Registro();
            DataTable dt = new DataTable();
            try
            {
                dt = r.VerificaUsuario(txtUsuario.Text, txtPassword.Text);
                if (dt.Rows.Count > 0)
                {
                    Form2 f = new Form2();
                    f.ShowDialog();                    
                    txtUsuario.Text = "";
                    txtPassword.Text = "";
                    
                   
                }
                else
                {
                    MessageBox.Show("Usuario o Password no existen");
                    txtUsuario.Text = "";
                    txtPassword.Text = "";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
