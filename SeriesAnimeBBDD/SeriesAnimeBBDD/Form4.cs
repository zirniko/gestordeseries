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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            CargarAdaptacionGrilla();
        }

        public void CargarAdaptacionGrilla()
        {
            Registro r = new Registro();
            try
            {

                dgvAdaptacion.DataSource = r.ListaAdaptacion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnIngresarAdaptacion_Click(object sender, EventArgs e)
        {
            try
            {
                Registro r = new Registro();
                r.GuardarAdaptacion(txtAdaptacion.Text);
                dgvAdaptacion.DataSource = r.ListaAdaptacion();
                MessageBox.Show("La adaptacion se guardo correctamente");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnEliminarAdaptacion_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            int CantidadFilasSeleccionadas = 0;
            try
            {
                CantidadFilasSeleccionadas = dgvAdaptacion.SelectedRows.Count;
                if (CantidadFilasSeleccionadas > 0)
                {
                    while (CantidadFilasSeleccionadas > 0)
                    {
                        r.EliminaAdaptacion(dgvAdaptacion.SelectedRows[0].Cells[0].Value.ToString());
                        dgvAdaptacion.Rows.RemoveAt(dgvAdaptacion.SelectedRows[0].Index);
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

        private void btnModificarAdaptacion_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            f.ShowDialog();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            dgvAdaptacion.DataSource = r.ListaAdaptacion();
        }
    }
}
