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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            CargarClasificacion();
        }

        public void CargarClasificacion()
        {
            Registro a = new Registro();
            try
            {
                cmbClasificacion.ValueMember = "Id";
                cmbClasificacion.DisplayMember = "Descripción";
                cmbClasificacion.DataSource = a.ListaClasificacion();
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
                dt = a.CargaClasificacionPorID(Convert.ToInt32(cmbClasificacion.SelectedValue));

                if (dt.Rows.Count > 0)//El datatable tiene filas
                {
                    lblID.Text = dt.Rows[0]["ID"].ToString();
                    txtClasificacion.Text = dt.Rows[0]["c_descripcion"].ToString();

                }
            }
            catch (Exception ex)
            {


            }
        }

        private void btnClasificacion_Click(object sender, EventArgs e)
        {
            Registro a = new Registro();
            try
            {
                a.ActualizarClasificacion(lblID.Text,
                                   txtClasificacion.Text);

                MessageBox.Show("Datos Actualizados Correctamente");
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
