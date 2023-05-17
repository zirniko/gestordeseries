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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            CargarGenero();
            CargarAdaptacion();
            CargarClasificacion();
            CargarAnimeGrilla();
            CargarGeneroM();
            CargarAdaptacionM();
            CargarClasificacionM(); 
            CargarGeneroF();
            CargarAdaptacionF();
            CargarClasificacionF();
        }



        public void CargarGeneroM()
        {
            Registro a = new Registro();
            try
            {
                cmbGENEROM.ValueMember = "Id";
                cmbGENEROM.DisplayMember = "Descripción";
                cmbGENEROM.DataSource = a.ListaGenero();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void CargarGeneroF()
        {
            Registro a = new Registro();
            try
            {
                cmbG.ValueMember = "Id";
                cmbG.DisplayMember = "Descripción";
                cmbG.DataSource = a.ListaGenero();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        public void CargarGenero()
        {
            Registro a = new Registro();
            try
            {
                cmbGenero.ValueMember = "Id";
                cmbGenero.DisplayMember = "Descripción";
                cmbGenero.DataSource = a.ListaGenero();
            }
            catch (Exception ex)
            {

                throw ex;
            }
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

        public void CargarAdaptacionM()
        {
            Registro a = new Registro();
            try
            {
                cmbADAPTACIONM.ValueMember = "Id";
                cmbADAPTACIONM.DisplayMember = "Descripción";
                cmbADAPTACIONM.DataSource = a.ListaAdaptacion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void CargarAdaptacionF()
        {
            Registro a = new Registro();
            try
            {
                cmbA.ValueMember = "Id";
                cmbA.DisplayMember = "Descripción";
                cmbA.DataSource = a.ListaAdaptacion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
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

        public void CargarClasificacionF()
        {
            Registro a = new Registro();
            try
            {
                cmbC.ValueMember = "Id";
                cmbC.DisplayMember = "Descripción";
                cmbC.DataSource = a.ListaClasificacion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void CargarClasificacionM()
        {
            Registro a = new Registro();
            try
            {
                cmbCLASIFICACIONM.ValueMember = "Id";
                cmbCLASIFICACIONM.DisplayMember = "Descripción";
                cmbCLASIFICACIONM.DataSource = a.ListaClasificacion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void CargarAnimeGrilla()
        {
            Registro r = new Registro();
            try
            {

                dgvAnime.DataSource = r.ListaAnime();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnIngresarAnime_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            r.GuardarAnime( txtNombre.Text,
                            txtFecha.Text,
                            Convert.ToInt32(nudEpisodios.Value),
                            Convert.ToInt32(cmbGenero.SelectedValue.ToString()),
                            Convert.ToInt32(cmbAdaptacion.SelectedValue.ToString()),
                            Convert.ToInt32(cmbClasificacion.SelectedValue.ToString())
                                           );
            dgvAnime.DataSource = r.ListaAnime();
            MessageBox.Show("Datos Guardados Correctamente");
        }

        private void btnEliminarClasificacion_Click(object sender, EventArgs e)
        {         
        }

        private void btnEliminarAnime_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            int CantidadFilasSeleccionadas = 0;
            try
            {
                CantidadFilasSeleccionadas = dgvAnime.SelectedRows.Count;
                if (CantidadFilasSeleccionadas > 0)
                {
                    while (CantidadFilasSeleccionadas > 0)
                    {
                        r.EliminaAnime(dgvAnime.SelectedRows[0].Cells[0].Value.ToString());

                        dgvAnime.Rows.RemoveAt(dgvAnime.SelectedRows[0].Index);
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

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            dgvAnime.DataSource = r.ListaAnime();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Registro r = new Registro();
            int CantidadFilasSeleccionadas = 0;
            try
            {
                CantidadFilasSeleccionadas = dgvAnime.SelectedRows.Count;
                if (CantidadFilasSeleccionadas == 1)
                {
                    panelM.Visible = true;
                   
                    dt = r.CargaAnimePorID(dgvAnime.SelectedRows[0].Cells[0].Value.ToString());

                    if (dt.Rows.Count > 0)//El datatable tiene filas
                    {
                        lblID.Text = dt.Rows[0]["ID"].ToString();
                        txtNOMBREM.Text = dt.Rows[0]["an_nombre"].ToString();
                        txtFECHAM.Text = dt.Rows[0]["an_fechaEmision"].ToString();
                        nudEPISODIOSM.Text = dt.Rows[0]["an_episodios"].ToString();
                        cmbGENEROM.SelectedValue = Convert.ToInt32(dt.Rows[0]["an_generoId"].ToString());
                        cmbADAPTACIONM.SelectedValue = Convert.ToInt32(dt.Rows[0]["an_adaptacionId"].ToString());
                        cmbCLASIFICACIONM.SelectedValue = Convert.ToInt32(dt.Rows[0]["an_clasificacionId"].ToString());

                    }

                    CantidadFilasSeleccionadas--;
                    
                }
                else
                {
                    MessageBox.Show("seleccione fila y solo una");
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
                a.ActualizarAnime (
                                   lblID.Text,
                                   txtNOMBREM.Text,
                                   txtFECHAM.Text,
                                   Convert.ToInt32(nudEPISODIOSM.Value),
                                   Convert.ToInt32(cmbGENEROM.SelectedValue.ToString()),
                                   Convert.ToInt32(cmbADAPTACIONM.SelectedValue.ToString()),
                                   Convert.ToInt32(cmbCLASIFICACIONM.SelectedValue.ToString())
                                  );
                panelM.Visible = false;
                dgvAnime.DataSource = a.ListaAnime();
                MessageBox.Show("Datos Actualizados Correctamente");


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void cbFiltro_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbFiltro.Checked)
                {
                    panelFiltro.Visible = true;

                }
                else
                {
                    panelFiltro.Visible = false;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            try
            {

                dgvAnime.DataSource = r.ListaAnimeFiltro(cmbG.Text.ToString(),
                                                         cmbA.Text.ToString(),
                                                         cmbC.Text.ToString()
                                                        );

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void pictureG_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            try
            {

                dgvAnime.DataSource = r.ListaAnimeGenero(cmbG.Text.ToString());

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void pictureA_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            try
            {

                dgvAnime.DataSource = r.ListaAnimeAdaptacion(cmbA.Text.ToString());

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void pictureC_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            try
            {

                dgvAnime.DataSource = r.ListaAnimeClasificacion(cmbC.Text.ToString());

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
