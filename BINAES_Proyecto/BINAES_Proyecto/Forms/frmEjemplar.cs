using System;
using System.Windows.Forms;

namespace BINAES_Proyecto.Forms
{
    public partial class frmEjemplar : Form
    {
        public frmEjemplar()
        {
            InitializeComponent();
        }

        private void frmEjemplar_Load(object sender, EventArgs e)
        {
            cmbColeccionEjemplar.DataSource = null;
            cmbColeccionEjemplar.ValueMember = "coleccionID";
            cmbColeccionEjemplar.DisplayMember = "coleccionNombre";
            cmbColeccionEjemplar.DataSource = EjemplarDAO.CargarDatosColeccion();

            cmbEditorial.DataSource = null;
            cmbEditorial.ValueMember = "editorialID";
            cmbEditorial.DisplayMember = "nombreEditorial";
            cmbEditorial.DataSource = EjemplarDAO.CargarDatosEditorial();

            cmbFomato.DataSource = null;
            cmbFomato.ValueMember = "formatoID";
            cmbFomato.DisplayMember = "nombreFormato";
            cmbFomato.DataSource = EjemplarDAO.CargarDatosFormato();
            
            cmbIdioma.DataSource = null;
            cmbIdioma.ValueMember = "idIdioma";
            cmbIdioma.DisplayMember = "nombreIdioma";
            cmbIdioma.DataSource = EjemplarDAO.CargarDatosIdiomas();
        }

        private void btnCrearEjemplar_Click(object sender, EventArgs e)
        {
            Ejemplar ejem = new Ejemplar();
            ejem.nombre = txtNombreEjemplar.Text;
            ejem.fecha = Convert.ToDateTime(txtFechaPublicacion.Text);
            ejem.coleccion = cmbColeccionEjemplar.SelectedValue.ToString();
            ejem.editorial = cmbEditorial.SelectedValue.ToString();
            ejem.formato = cmbFomato.SelectedValue.ToString();
            ejem.idioma = cmbIdioma.SelectedValue.ToString();
            ejem.imagen = txtFotografia.Text;
            ejem.isbn = txtIsbn.Text;
            ejem.issn = txtissn.Text;
            ejem.doi = txtDoi.Text;
            
            
            EjemplarDAO.IngresarEjemplar(ejem);
            MessageBox.Show("Ingresado con éxito");
        }

        private void btnCrearEditorial_Click(object sender, EventArgs e)
        {
            Editorial edit = new Editorial();
            edit.nombreEditorial = txtNuevaEditorial.Text;
            
            EditorialDAO.InsertarNuevaEditorial(edit);
            MessageBox.Show("Editorial ingresada con éxito");
            Update();
        }
    }
}