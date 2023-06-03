using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplos12clParcial
{
    public partial class frmAcceso : Form
    {
        public frmAcceso()
        {
            InitializeComponent();
        }

        private void frmAcceso_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Supervisor" & txtContrasena.Text == "456")
            {
                MessageBox.Show("Bienvenido", "MedialCenter");
                // comentarios aqui explique
                // usams código de C# instrucción if
                this.Hide();
                frmMenuPrincipal frm = new frmMenuPrincipal();
                frm.Show();
                txtUsuario.BackColor = Color.White;
                txtContrasena.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Usuario y contraseña incorrectos", "MedicalCenter");
                txtUsuario.Text = "";
                txtContrasena.Text = "";
                txtUsuario.Focus();
                txtUsuario.BackColor = Color.Pink;
                txtContrasena.BackColor = Color.Pink;
            }
        }
    }
}
