using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimiSoft
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnProductos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabMdiManager.MdiParent == null)
                tabMdiManager.MdiParent = this;

            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmProductos))
                {
                    form.Activate();
                    return;
                }

            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Productos ...");
            new frmProductos() { MdiParent = this }.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void btnClientes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabMdiManager.MdiParent == null)
                tabMdiManager.MdiParent = this;

            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmClientes))
                {
                    form.Activate();
                    return;
                }

            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Clientes ...");
            new frmClientes() { MdiParent = this }.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void btnProveedores_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabMdiManager.MdiParent == null)
                tabMdiManager.MdiParent = this;

            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmProveedores))
                {
                    form.Activate();
                    return;
                }

            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Proveedores ...");
            new frmProveedores() { MdiParent = this }.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show(string.Format("¿Está seguro de cerrar? \n\n"),
                     "SimiSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                     DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAdminVentas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabMdiManager.MdiParent == null)
                tabMdiManager.MdiParent = this;

            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmVentas))
                {
                    form.Activate();
                    return;
                }

            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Ventas ...");
            new frmVentas() { MdiParent = this }.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void btnFormasPago_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabMdiManager.MdiParent == null)
                tabMdiManager.MdiParent = this;

            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmFormasPago))
                {
                    form.Activate();
                    return;
                }

            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Formas de Pago ...");
            new frmFormasPago() { MdiParent = this }.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }
    }
}
