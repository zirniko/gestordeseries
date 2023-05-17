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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            CargarGenero();
        }

        public void CargarGenero()
        {
            Registro a = new Registro();
            try
            {
                cmbGenero.ValueMember = "id";
                cmbGenero.DisplayMember = "descripción";
                cmbGenero.DataSource = a.ListaGenero();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Registro a = new Registro();

            try
            {
                dt = a.CargaGeneroPorID(Convert.ToInt32(cmbGenero.SelectedValue));

                if (dt.Rows.Count > 0)//El datatable tiene filas
                {
                    lblID.Text = dt.Rows[0]["ID"].ToString();
                    txtGenero.Text = dt.Rows[0]["g_descripcion"].ToString();

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Registro a = new Registro();
            try
            {
                a.ActualizarGenero(lblID.Text,
                                   txtGenero.Text);

                MessageBox.Show("Datos Actualizados Correctamente");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
