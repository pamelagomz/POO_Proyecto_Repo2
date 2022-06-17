using System;
using System.Data;
using System.Windows.Forms;
using BINAES_Proyecto.Properties;

namespace BINAES_Proyecto.Forms
{
    public partial class frmColeccion : Form
    {
        public frmColeccion()
        {
            InitializeComponent();

        }

        private void frmColeccion_Load(object sender, EventArgs e)
        {

            cmbGenero.DataSource = null;
            cmbGenero.ValueMember = "generoID";
            cmbGenero.DisplayMember = "generoNombre";
            cmbGenero.DataSource = GeneroDAO.CargarDatos();

            cmbTipoColeccion.DataSource = null;
            cmbTipoColeccion.ValueMember = "tipoID";
            cmbTipoColeccion.DisplayMember = "tipoNombre";
            cmbTipoColeccion.DataSource = GeneroDAO.CargarDatosTipo();

            cmbAreaColeccion.DataSource = null;
            cmbAreaColeccion.ValueMember = "areaID";
            cmbAreaColeccion.DisplayMember = "areaNombre";
            cmbAreaColeccion.DataSource = GeneroDAO.CargarDatosArea();

        }

        private void btnMostrarColeccion_Click(object sender, EventArgs e)
        {
            dgvMostrarUser.DataSource = null;
            dgvMostrarUser.DataSource = GeneroDAO.CargarDatos();
        }


        private void btnCrearColeccion_Click(object sender, EventArgs e)
        {
            cmbGenero.Items.Insert(0,"0");
            
            Coleccion col = new Coleccion();
            col.coleccionID = Convert.ToInt32(txtColeID.Text);
            col.coleccionNombre = txtNombreColeccion.Text;
            col.generoID = Convert.ToInt32(cmbGenero.SelectedIndex);
            col.tipoID = Convert.ToInt32(cmbTipoColeccion.SelectedIndex);
            col.areaID = Convert.ToInt32(cmbAreaColeccion.SelectedIndex);
            
            GeneroDAO.IngresarColeccion(col);
            MessageBox.Show("Ingresado con exito");
        }
    }
}
