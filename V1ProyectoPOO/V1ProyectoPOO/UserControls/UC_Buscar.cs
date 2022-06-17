using System.Windows.Forms;
using System.Collections.Generic;

namespace V1ProyectoPOO.UserControls
{
    public partial class UC_Buscar : UserControl
    {
        public UC_Buscar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            if(cmbOpcionesBuscar.Text == "Titulo completo") // Aqui pones el nombre que le hayas puesto a la combobox
            {

                List<Ejemplar> resultado = BuscarEjemplarDAO.FiltrarPorTitulo(txtBuscarEjemplar.Text.Trim()); // Ponele el nombre de la txt box

                dgvResultadosBusqueda.DataSource = null;
                dgvResultadosBusqueda.DataSource = resultado;

            }
            else if (cmbOpcionesBuscar.Text == "Titulo parcial")
            {

                List<Ejemplar> resultado = BuscarEjemplarDAO.FiltrarPorTituloParcial(txtBuscarEjemplar.Text.Trim());

                dgvResultadosBusqueda.DataSource = null;
                dgvResultadosBusqueda.DataSource = resultado;

            }
            else if (cmbOpcionesBuscar.Text == "Autor")
            {

                List<Ejemplar> resultado = BuscarEjemplarDAO.FiltrarPorAutor(txtBuscarEjemplar.Text.Trim());

                dgvResultadosBusqueda.DataSource = null;
                dgvResultadosBusqueda.DataSource = resultado;

            }
            else if (cmbOpcionesBuscar.Text == "Fisico")
            {
                txtBuscarEjemplar.Text = cmbOpcionesBuscar.Text;
                List<Ejemplar> resultado = BuscarEjemplarDAO.FiltrarPorFormato(cmbOpcionesBuscar.Text.Trim());

                dgvResultadosBusqueda.DataSource = null;
                dgvResultadosBusqueda.DataSource = resultado;

            }
            else if (cmbOpcionesBuscar.Text == "Digital")
            {
                txtBuscarEjemplar.Text = cmbOpcionesBuscar.Text;
                List<Ejemplar> resultado = BuscarEjemplarDAO.FiltrarPorFormato(cmbOpcionesBuscar.Text.Trim());

                dgvResultadosBusqueda.DataSource = null;
                dgvResultadosBusqueda.DataSource = resultado;

            }
            else
            {

                List<Ejemplar> resultado = BuscarEjemplarDAO.FiltrarPorPalabraClave(txtBuscarEjemplar.Text.Trim()); // Ponele el nombre de la txt box

                dgvResultadosBusqueda.DataSource = null;
                dgvResultadosBusqueda.DataSource = resultado;
            }
        }
    }
}