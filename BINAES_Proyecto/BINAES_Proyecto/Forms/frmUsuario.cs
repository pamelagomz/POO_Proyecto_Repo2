using System;
using System.Windows.Forms;

namespace BINAES_Proyecto.Forms
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }
        

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.UsuarioID = Convert.ToInt32(txtUsuarioID.Text);
            user.UsuarioNombre = txtNombreUsuarios.Text;
            user.UserOcupacion = txtOcupacion.Text;
            user.UserDireccion = txtDireccionUsuario.Text;
            user.UserInstitucion = txtInstitucion.Text;
            user.UserTelefono = txtTelefono.Text;
            user.UserCorreo = txt.Text;
    
            UsuarioDAO.IngresarUsuario(user);
            MessageBox.Show("Ingresado con exito");
            
        }


        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            dgvMostrarUser.DataSource = null;
            dgvMostrarUser.DataSource = UsuarioDAO.MostrarUsuarios();
        }
    }
}


    
