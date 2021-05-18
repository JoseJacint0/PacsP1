
namespace SimiSoft
{
    partial class frmPagos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagos));
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.gControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lupFormaPago = new DevExpress.XtraEditors.LookUpEdit();
            this.formaPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPago = new DevExpress.XtraEditors.TextEdit();
            this.txtCambio = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalPago = new DevExpress.XtraEditors.TextEdit();
            this.lblFormaPago = new DevExpress.XtraEditors.LabelControl();
            this.lblPago = new DevExpress.XtraEditors.LabelControl();
            this.lblCambio = new DevExpress.XtraEditors.LabelControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnRegistrarVenta = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gControl1)).BeginInit();
            this.gControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lupFormaPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCambio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPago.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Appearance.Options.UseFont = true;
            this.lblTotal.Location = new System.Drawing.Point(14, 11);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(117, 19);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total a Pagar:";
            // 
            // gControl1
            // 
            this.gControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gControl1.Controls.Add(this.lupFormaPago);
            this.gControl1.Controls.Add(this.txtPago);
            this.gControl1.Controls.Add(this.txtCambio);
            this.gControl1.Controls.Add(this.txtTotalPago);
            this.gControl1.Controls.Add(this.lblFormaPago);
            this.gControl1.Controls.Add(this.lblPago);
            this.gControl1.Controls.Add(this.lblCambio);
            this.gControl1.Controls.Add(this.lblTotal);
            this.gControl1.Location = new System.Drawing.Point(12, 1);
            this.gControl1.Name = "gControl1";
            this.gControl1.Size = new System.Drawing.Size(312, 131);
            this.gControl1.TabIndex = 1;
            // 
            // lupFormaPago
            // 
            this.lupFormaPago.Location = new System.Drawing.Point(137, 45);
            this.lupFormaPago.Name = "lupFormaPago";
            this.lupFormaPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupFormaPago.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idFPago", "id FPago", 50, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Descripción", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 38, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lupFormaPago.Properties.DataSource = this.formaPagoBindingSource;
            this.lupFormaPago.Properties.DisplayMember = "descripcion";
            this.lupFormaPago.Properties.NullText = "";
            this.lupFormaPago.Properties.ShowFooter = false;
            this.lupFormaPago.Properties.ShowHeader = false;
            this.lupFormaPago.Properties.ValueMember = "idFPago";
            this.lupFormaPago.Size = new System.Drawing.Size(159, 20);
            this.lupFormaPago.TabIndex = 1;
            this.lupFormaPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lupFormaPago_KeyPress);
            // 
            // formaPagoBindingSource
            // 
            this.formaPagoBindingSource.DataSource = typeof(SimiSoft.BML.FormaPago);
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(137, 71);
            this.txtPago.Name = "txtPago";
            this.txtPago.Properties.Mask.EditMask = "c";
            this.txtPago.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPago.Size = new System.Drawing.Size(159, 20);
            this.txtPago.TabIndex = 2;
            this.txtPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPago_KeyPress);
            // 
            // txtCambio
            // 
            this.txtCambio.Enabled = false;
            this.txtCambio.Location = new System.Drawing.Point(137, 99);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(159, 20);
            this.txtCambio.TabIndex = 3;
            // 
            // txtTotalPago
            // 
            this.txtTotalPago.Enabled = false;
            this.txtTotalPago.Location = new System.Drawing.Point(137, 13);
            this.txtTotalPago.Name = "txtTotalPago";
            this.txtTotalPago.Size = new System.Drawing.Size(159, 20);
            this.txtTotalPago.TabIndex = 0;
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaPago.Appearance.Options.UseFont = true;
            this.lblFormaPago.Location = new System.Drawing.Point(28, 44);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(103, 19);
            this.lblFormaPago.TabIndex = 3;
            this.lblFormaPago.Text = "Forma Pago:";
            // 
            // lblPago
            // 
            this.lblPago.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPago.Appearance.Options.UseFont = true;
            this.lblPago.Location = new System.Drawing.Point(59, 72);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(72, 19);
            this.lblPago.TabIndex = 2;
            this.lblPago.Text = "Su Pago:";
            // 
            // lblCambio
            // 
            this.lblCambio.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Appearance.Options.UseFont = true;
            this.lblCambio.Location = new System.Drawing.Point(39, 97);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(92, 19);
            this.lblCambio.TabIndex = 1;
            this.lblCambio.Text = "Su Cambio:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(12, 138);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVenta.Appearance.Options.UseFont = true;
            this.btnRegistrarVenta.Location = new System.Drawing.Point(212, 138);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(112, 23);
            this.btnRegistrarVenta.TabIndex = 5;
            this.btnRegistrarVenta.Text = "Registrar Venta";
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // frmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(338, 176);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmPagos.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gControl1)).EndInit();
            this.gControl1.ResumeLayout(false);
            this.gControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lupFormaPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCambio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPago.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraEditors.GroupControl gControl1;
        private DevExpress.XtraEditors.LookUpEdit lupFormaPago;
        private DevExpress.XtraEditors.TextEdit txtPago;
        private DevExpress.XtraEditors.TextEdit txtCambio;
        private DevExpress.XtraEditors.TextEdit txtTotalPago;
        private DevExpress.XtraEditors.LabelControl lblFormaPago;
        private DevExpress.XtraEditors.LabelControl lblPago;
        private DevExpress.XtraEditors.LabelControl lblCambio;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnRegistrarVenta;
        private System.Windows.Forms.BindingSource formaPagoBindingSource;
    }
}