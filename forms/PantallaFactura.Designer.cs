namespace La_Buena_Farmacia.forms
{
    partial class PantallaFactura
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vistaDetalleVenta4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fARMACIA_BUENA__SALUDDataSet = new La_Buena_Farmacia.FARMACIA_BUENA__SALUDDataSet();
            this.vistaVenta3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vistaDetalleVenta4TableAdapter = new La_Buena_Farmacia.FARMACIA_BUENA__SALUDDataSetTableAdapters.VistaDetalleVenta4TableAdapter();
            this.vistaVenta3TableAdapter = new La_Buena_Farmacia.FARMACIA_BUENA__SALUDDataSetTableAdapters.VistaVenta3TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vistaDetalleVenta4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA_BUENA__SALUDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaVenta3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vistaDetalleVenta4BindingSource
            // 
            this.vistaDetalleVenta4BindingSource.DataMember = "VistaDetalleVenta4";
            this.vistaDetalleVenta4BindingSource.DataSource = this.fARMACIA_BUENA__SALUDDataSet;
            // 
            // fARMACIA_BUENA__SALUDDataSet
            // 
            this.fARMACIA_BUENA__SALUDDataSet.DataSetName = "FARMACIA_BUENA__SALUDDataSet";
            this.fARMACIA_BUENA__SALUDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaVenta3BindingSource
            // 
            this.vistaVenta3BindingSource.DataMember = "VistaVenta3";
            this.vistaVenta3BindingSource.DataSource = this.fARMACIA_BUENA__SALUDDataSet;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DetalleVenta";
            reportDataSource1.Value = this.vistaDetalleVenta4BindingSource;
            reportDataSource2.Name = "Venta";
            reportDataSource2.Value = this.vistaVenta3BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "La_Buena_Farmacia.reports.FacturaVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 23);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(351, 415);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // vistaDetalleVenta4TableAdapter
            // 
            this.vistaDetalleVenta4TableAdapter.ClearBeforeFill = true;
            // 
            // vistaVenta3TableAdapter
            // 
            this.vistaVenta3TableAdapter.ClearBeforeFill = true;
            // 
            // PantallaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(375, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PantallaFactura";
            this.Text = "PantallaFactura";
            this.Load += new System.EventHandler(this.PantallaFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vistaDetalleVenta4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA_BUENA__SALUDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaVenta3BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FARMACIA_BUENA__SALUDDataSet fARMACIA_BUENA__SALUDDataSet;
        private System.Windows.Forms.BindingSource vistaDetalleVenta4BindingSource;
        private FARMACIA_BUENA__SALUDDataSetTableAdapters.VistaDetalleVenta4TableAdapter vistaDetalleVenta4TableAdapter;
        private System.Windows.Forms.BindingSource vistaVenta3BindingSource;
        private FARMACIA_BUENA__SALUDDataSetTableAdapters.VistaVenta3TableAdapter vistaVenta3TableAdapter;
    }
}