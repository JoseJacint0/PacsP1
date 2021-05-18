using DevExpress.XtraEditors;
using SimiSoft.BML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimiSoft
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if(new Usuario
                {
                    username = txtUsuario.Text,
                    password = txtContraseña.Text
                }.Login()!= null)
                {
                    Misc.actualiza = true;
                    XtraMessageBox.Show("Acceso correcto", "SimiSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    //mostrar main
                }
                else
                {
                    XtraMessageBox.Show("Error en las credenciales", "SimiSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.EditValue = null;
                    txtContraseña.EditValue = null;
                    txtUsuario.Focus();
                }
            }
        }

        private bool Validar()
        {
            var ban = false;
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                txtUsuario.ErrorText = "Ingresa el usuario";
                txtUsuario.Focus();
                ban = true;
            }
            if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                txtContraseña.ErrorText = "Ingresa una contraseña";
                if (!ban)
                {
                    txtContraseña.Focus();
                    ban = true;
                }
            }

            return !ban;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtContraseña_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Misc.actualiza == false)
                if (XtraMessageBox.Show("¿Deseas cerrar esta pantalla?", "SimiSoft - 2021",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
        }
    }
}