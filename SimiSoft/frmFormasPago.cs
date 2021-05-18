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
    public partial class frmFormasPago : DevExpress.XtraEditors.XtraForm
    {
        public frmFormasPago()
        {
            InitializeComponent();
        }

        private void frmFormasPago_Load(object sender, EventArgs e)
        {
            formaPagoBindingSource.DataSource = new FormaPago().GetAll();
            gvFormasPago.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMFPago()
            {
                Text = "Nueva Forma de Pago"
            }.ShowDialog();
            formaPagoBindingSource.DataSource = new FormaPago().GetAll();
            gvFormasPago.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMFPago((int)gvFormasPago.GetFocusedRowCellValue("idFPago"))
            {
                Text = "Modificar Forma de Pago"
            }.ShowDialog();
            formaPagoBindingSource.DataSource = new FormaPago().GetAll();
            gvFormasPago.BestFitColumns();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvFormasPago.FocusedRowHandle >= 0)
                if (XtraMessageBox.Show(string.Format("¿Está seguro de eliminar la forma de pago? \n\n" +
                    "{0}", gvFormasPago.GetFocusedRowCellValue("descripcion")),
                    "SimiSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {

                    if (new FormaPago()
                    {
                        idFPago = (int)gvFormasPago.GetFocusedRowCellValue("idFPago")
                    }.Delete() > 0)
                        XtraMessageBox.Show("Forma de pago eliminada correctamente", "SimiSoft",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Ocurrió un error al eliminar la forma de pago. \nVerifique con el deparamento de TI",
                            "SimiSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    formaPagoBindingSource.DataSource = new FormaPago().GetAll();
                    gvFormasPago.BestFitColumns();
                }
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formaPagoBindingSource.DataSource = new FormaPago().GetAll();
            gvFormasPago.BestFitColumns();
        }
    }
}