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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            CargarClasificacionGrilla();
        }


        public void CargarClasificacionGrilla()
        {
            Registro r = new Registro();
            try
            {

                dgvClasificacion.DataSource = r.ListaClasificacion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnIngresarClasificacion_Click(object sender, EventArgs e)
        {
            try
            {
                Registro r = new Registro();
                r.GuardarClasificacion(txtClasificacion.Text);
                dgvClasificacion.DataSource = r.ListaClasificacion();
                MessageBox.Show("La Clasificacion se guardo correctamente");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void btnEliminarClasificacion_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            int CantidadFilasSeleccionadas = 0;
            try
            {
                CantidadFilasSeleccionadas = dgvClasificacion.SelectedRows.Count;
                if (CantidadFilasSeleccionadas > 0)
                {
                    while (CantidadFilasSeleccionadas > 0)
                    {
                        r.EliminaClasificacion(dgvClasificacion.SelectedRows[0].Cells[0].Value.ToString());
                        dgvClasificacion.Rows.RemoveAt(dgvClasificacion.SelectedRows[0].Index);
                        CantidadFilasSeleccionadas--;
                    }
                }
                else
                {
                    MessageBox.Show("seleccione fila");
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnModificarClasificacion_Click(object sender, EventArgs e)
        {
            Form9 f = new Form9();
            f.ShowDialog();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            dgvClasificacion.DataSource = r.ListaClasificacion();
        }
    }
}
