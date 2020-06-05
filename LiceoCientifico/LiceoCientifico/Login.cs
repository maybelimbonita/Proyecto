using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiceoCientifico.Logica; 

namespace LiceoCientifico
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUsuario usr = new clsUsuario(); 
            if(usr.InicioDeSesion(txtUsuario.Text,txtContraseña.Text))
            {
                MessageBox.Show("Bienvenido " + usr.usuarioPrincipal.Nombres + " " + usr.usuarioPrincipal.Apellidos);
                MenuPrincipal objPrincipal = new MenuPrincipal(usr.usuarioPrincipal);
                this.Hide();
                objPrincipal.Show();
            }
            else
            {
                MessageBox.Show(usr.Mensaje==string.Empty?"Crendenciales Invalidas": usr.Mensaje);
            }
        }
    }
}
