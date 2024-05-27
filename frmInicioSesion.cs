using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryInicioSesion
{
    public partial class frmInicioSesion : Form
    {
        clsUsuario objUsuario;
        public frmInicioSesion()
        {          
            InitializeComponent();
            objUsuario = new clsUsuario();

            txtContraseña.PasswordChar = '*';
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            objUsuario.ValidarUsuario(txtUsuario.Text, txtContraseña.Text);
            objUsuario.RegistroLogInicioSesion();
        }


    }
}
