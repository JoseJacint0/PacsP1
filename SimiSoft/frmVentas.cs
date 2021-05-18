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
    public partial class frmVentas : DevExpress.XtraEditors.XtraForm
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNVenta().ShowDialog();
            ventaBindingSource.DataSource = new Venta().GetAll();
            gvVentas.BestFitColumns();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ventaBindingSource.DataSource = new Venta().GetAll();
            gvVentas.BestFitColumns();
        }
    }
}