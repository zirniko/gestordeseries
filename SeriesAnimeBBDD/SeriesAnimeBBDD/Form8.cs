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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            CargarAdaptacion();
        }

        public void CargarAdaptacion()
        {
            Registro a = new Registro();
            try
            {
                cmbAdaptacion.ValueMember = "Id";
                cmbAdaptacion.DisplayMember = "Descripción";
                cmbAdaptacion.DataSource = a.ListaAdaptacion();
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
                dt = a.CargaAdaptacionPorID(Convert.ToInt32(cmbAdaptacion.SelectedValue));

                if (dt.Rows.Count > 0)//El datatable tiene filas
                {
                    lblID.Text = dt.Rows[0]["ID"].ToString();
                    txtAdaptacion.Text = dt.Rows[0]["a_descripcion"].ToString();

                }
            }
            catch (Exception ex)
            {


            }
        }

        private void btnAdaptacion_Click(object sender, EventArgs e)
        {
            Registro a = new Registro();
            try
            {
                a.ActualizarAdaptacion(lblID.Text,
                                   txtAdaptacion.Text);

                MessageBox.Show("Datos Actualizados Correctamente");
            }
            catch (Exception ex)
            {

                throw;
            }
        }


    }

}
