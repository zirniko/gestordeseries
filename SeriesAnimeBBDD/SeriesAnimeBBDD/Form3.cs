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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            CargarGeneroGrilla();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        public void CargarGeneroGrilla()
        {
            Registro r = new Registro();
            try
            {

                dgvGenero.DataSource = r.ListaGenero();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }




        private void btnIngresarGenero_Click(object sender, EventArgs e)
        {
            try
            {
                Registro r = new Registro();
                r.GuardarGenero(txtGenero.Text);
                dgvGenero.DataSource = r.ListaGenero();
                MessageBox.Show("El genero se guardo correctamente");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnEliminarGenero_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            int CantidadFilasSeleccionadas = 0;
            try
            {
                CantidadFilasSeleccionadas = dgvGenero.SelectedRows.Count;
                if (CantidadFilasSeleccionadas > 0)
                {
                    while (CantidadFilasSeleccionadas > 0)
                    {
                        r.EliminaGenero(dgvGenero.SelectedRows[0].Cells[0].Value.ToString());
                        dgvGenero.Rows.RemoveAt(dgvGenero.SelectedRows[0].Index);
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

        private void btnModificarGenero_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.ShowDialog();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            dgvGenero.DataSource = r.ListaGenero();
        }
    }
}
