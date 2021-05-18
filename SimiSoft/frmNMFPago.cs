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
    public partial class frmNMFPago : DevExpress.XtraEditors.XtraForm
    {
        private FormaPago formapago;
        //cuando es nueva Forma de Pago
        public frmNMFPago()
        {
            InitializeComponent();
        }

        //cuando es modificar la forma de pago
        public frmNMFPago(int idFPago)
        {
            InitializeComponent();
            formapago = new FormaPago
            {
                idFPago = idFPago
            }.GetById();
            txtID.Text = formapago.idFPago.ToString();
            txtDescripcion.Text = formapago.descripcion;
            
        }

        private void frmNMFPago_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (formapago == null)
                {
                    if (new FormaPago
                    {
                        descripcion = txtDescripcion.Text
                    }.Add() > 0)
                    {
                        XtraMessageBox.Show("Forma de pago insertada correctamente", "SimiSoft", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrió un error en la inserción", "SimiSoft", MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else
                {
                    formapago.descripcion = txtDescripcion.Text;
                    if (formapago.Update() > 0)
                    {
                        XtraMessageBox.Show("Forma de pago modificada correctamente", "SimiSoft", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrió un error en la modificación", "SimiSoft", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }

        private bool Validar()
        {
            var ban = false;
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                txtDescripcion.ErrorText = "Ingresa la descripción";
                txtDescripcion.Focus();
                ban = true;
            }
            
            return !ban;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}