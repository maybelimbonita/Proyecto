using LiceoCientifico.Data;
using LiceoCientifico.Logica;
using System;
using System.Windows.Forms;

namespace LiceoCientifico.Pantallas
{
    public partial class ucAgregarUsuario : UserControl
    {
        private static ucAgregarUsuario _agregarUsuario;
        public static ucAgregarUsuario agregarUsuario
        {
            get
            {
                if (_agregarUsuario == null)
                    _agregarUsuario = new ucAgregarUsuario();
                    return _agregarUsuario;
            } 
        }

        public ucAgregarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text.Equals(string.Empty) || txtApellidos.Text.Equals(string.Empty) || txtUsuario.Text.Equals(string.Empty)
                || txtContraseña.Text.Equals(string.Empty) || txtTelefono.Text.Equals(string.Empty) || txtCorreo.Text.Equals(string.Empty))
            {
                MessageBox.Show("Hay campos  obligatorios vacios.");
            }
            else
            {
                Usuario nuevoUsuario = new Usuario()
                {
                    Nombres = txtNombres.Text,
                    Apellidos = txtApellidos.Text,
                    Usuario1 = txtUsuario.Text,
                    Contraseña = txtContraseña.Text,
                    Telefono = long.Parse(txtTelefono.Text),
                    Correo = txtCorreo.Text
                };

                clsUsuario usuario = new clsUsuario();
                if(usuario.AgregarUsuario(nuevoUsuario))
                {
                    MessageBox.Show("Usuario Creado exitosamente");
                    Utilidades.limpiarControles(this); 
                }
                else
                {
                    MessageBox.Show(usuario.Mensaje);
                }


            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
        }
    }
}
