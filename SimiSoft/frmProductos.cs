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
    public partial class frmProductos : DevExpress.XtraEditors.XtraForm
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            productoBindingSource.DataSource = new Producto().GetAll();
            gvProductos.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMProducto()
            {
                Text = "Nuevo Producto"
            }.ShowDialog();
            productoBindingSource.DataSource = new Producto().GetAll();
            gvProductos.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMProducto((int)gvProductos.GetFocusedRowCellValue("idProducto"))
            {
                Text = "Modificar Producto"
            }.ShowDialog();
            productoBindingSource.DataSource = new Producto().GetAll();
            gvProductos.BestFitColumns();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvProductos.FocusedRowHandle >= 0)
                if (XtraMessageBox.Show(string.Format("¿Esta seguro de eliminar el producto? \n\n" +
                    "{0}", gvProductos.GetFocusedRowCellValue("descripcion")),
                    "SimiSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {

                    if (new Producto()
                    {
                        idProducto = (int)gvProductos.GetFocusedRowCellValue("idProducto")
                    }.Delete() > 0)
                        XtraMessageBox.Show("Producto eliminado correctamente", "SimiSoft",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Ocurrio un error al eliminar el producto. \nVerifique con el deparamento de TI",
                            "SimiSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    productoBindingSource.DataSource = new Producto().GetAll();
                    gvProductos.BestFitColumns();
                }
        }
    }
}