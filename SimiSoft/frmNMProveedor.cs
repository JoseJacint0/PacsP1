﻿using DevExpress.XtraEditors;
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
    public partial class frmNMProveedor : DevExpress.XtraEditors.XtraForm
    {
        private Proveedor proveedor;
        //cuando es nuevo proveedor
        public frmNMProveedor()
        {
            InitializeComponent();
        }

        //cuando es modificar el proveedor
        public frmNMProveedor(int idProveedor)
        {
            InitializeComponent();
            proveedor = new Proveedor
            {
                idProveedor = idProveedor
            }.GetById();
            txtID.Text = proveedor.idProveedor.ToString();
            txtNombre.Text = proveedor.nombre;
            txtTelefono.Text = proveedor.telefono;
            
        }

        private void txtTelefono_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmNMProveedor_Load(object sender, EventArgs e)
        {

        }

        private bool Validar()
        {
            var ban = false;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                txtNombre.ErrorText = "Ingresa un nombre";
                txtNombre.Focus();
                ban = true;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                txtTelefono.ErrorText = "Ingresa un teléfono";
                if (!ban)
                {
                    txtTelefono.Focus();
                    ban = true;
                }
            }
            

            return !ban;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (proveedor == null)
                {
                    if (new Proveedor
                    {
                        nombre = txtNombre.Text,
                        telefono = txtTelefono.Text,                     
                    }.Add() > 0)
                    {
                        XtraMessageBox.Show("Proveedor insertado correctamente", Application.ProductName, MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrio un error en la inserción", Application.ProductName, MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else
                {
                    proveedor.nombre = txtNombre.Text;
                    proveedor.telefono = txtTelefono.Text;                  
                    if (proveedor.Update() > 0)
                    {
                        XtraMessageBox.Show("Proveedor modificado correctamente", Application.ProductName, MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrio un error en la modificación", Application.ProductName, MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}