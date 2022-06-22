using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BINAES_Proyecto.Forms
{
    public partial class frmEvento : Form
    {
        public frmEvento()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cmbEvento.Text == "Nombre del evento") // Aqui pones el nombre que le hayas puesto a la combobox
             { 
                List<Evento> resultado = BuscarEventoDAO.NombreEvento(txtBuscarEvento.Text.Trim());
                txtBuscarEvento.Clear();

                dgvEvento.DataSource = null;
                dgvEvento.DataSource = resultado;
                
               
                
                dgvEvento.Columns["ID"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvEvento.Columns["Titulo_Evento"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvEvento.Columns["Portada"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvEvento.Columns["Cantidad_de_asistentes"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvEvento.Columns["Inicio_del_vento"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvEvento.Columns["Finalizacion_del_evento"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvEvento.Columns["Area"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvEvento.Columns["Objetivos"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                    
             }

            else
            {
                List<Evento> resultado = BuscarEventoDAO.Eventos();
                txtBuscarEvento.Clear();

                dgvEvento.DataSource = null;
                dgvEvento.DataSource = resultado;
                
                dgvEvento.Columns["ID"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvEvento.Columns["Titulo_Evento"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvEvento.Columns["Portada"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvEvento.Columns["Cantidad_de_asistentes"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvEvento.Columns["Inicio_del_vento"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvEvento.Columns["Finalizacion_del_evento"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvEvento.Columns["Area"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvEvento.Columns["Objetivos"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }
        }
    }
}