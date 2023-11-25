namespace La_Buena_Farmacia.forms
{
    partial class ReportesVentas
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
            this.vistaVenta3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fARMACIA_BUENA__SALUDDataSet = new La_Buena_Farmacia.FARMACIA_BUENA__SALUDDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button2 = new System.Windows.Forms.Button();
            this.FinalVentas = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.InicioVentas = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vistaVenta3TableAdapter = new La_Buena_Farmacia.FARMACIA_BUENA__SALUDDataSetTableAdapters.VistaVenta3TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vistaVenta3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA_BUENA__SALUDDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vistaVenta3BindingSource
            // 
            this.vistaVenta3BindingSource.DataMember = "VistaVenta3";
            this.vistaVenta3BindingSource.DataSource = this.fARMACIA_BUENA__SALUDDataSet;
            // 
            // fARMACIA_BUENA__SALUDDataSet
            // 
            this.fARMACIA_BUENA__SALUDDataSet.DataSetName = "FARMACIA_BUENA__SALUDDataSet";
            this.fARMACIA_BUENA__SALUDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.FinalVentas);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.InicioVentas);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 452);
            this.panel1.TabIndex = 6;
            // 
            // reportViewer1
            // 
            this.reportViewer1.ForeColor = System.Drawing.SystemColors.HotTrack;
            reportDataSource1.Name = "Ventas";
            reportDataSource1.Value = this.vistaVenta3BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "La_Buena_Farmacia.reports.Ventas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(96, 182);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(636, 246);
            this.reportViewer1.TabIndex = 32;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Menu;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(522, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 28);
            this.button2.TabIndex = 31;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FinalVentas
            // 
            this.FinalVentas.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalVentas.CalendarForeColor = System.Drawing.SystemColors.HotTrack;
            this.FinalVentas.CalendarTitleForeColor = System.Drawing.SystemColors.HotTrack;
            this.FinalVentas.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalVentas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FinalVentas.Location = new System.Drawing.Point(373, 101);
            this.FinalVentas.Name = "FinalVentas";
            this.FinalVentas.Size = new System.Drawing.Size(109, 21);
            this.FinalVentas.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(260, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Fecha final:";
            // 
            // InicioVentas
            // 
            this.InicioVentas.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InicioVentas.CalendarForeColor = System.Drawing.SystemColors.HotTrack;
            this.InicioVentas.CalendarTitleForeColor = System.Drawing.SystemColors.HotTrack;
            this.InicioVentas.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InicioVentas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.InicioVentas.Location = new System.Drawing.Point(127, 101);
            this.InicioVentas.Name = "InicioVentas";
            this.InicioVentas.Size = new System.Drawing.Size(116, 21);
            this.InicioVentas.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(665, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 28);
            this.button1.TabIndex = 26;
            this.button1.Text = "Quitar filtros";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Menu;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.button7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button7.Location = new System.Drawing.Point(32, 21);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(84, 28);
            this.button7.TabIndex = 25;
            this.button7.Text = "Reportes";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(21, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Fecha inicio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Menu;
            this.label6.Location = new System.Drawing.Point(315, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Reporte de ventas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(14, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 0;
            // 
            // vistaVenta3TableAdapter
            // 
            this.vistaVenta3TableAdapter.ClearBeforeFill = true;
            // 
            // ReportesVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ReportesVentas";
            this.Text = "ReportesVentas";
            this.Load += new System.EventHandler(this.ReportesVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vistaVenta3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA_BUENA__SALUDDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker FinalVentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker InicioVentas;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FARMACIA_BUENA__SALUDDataSet fARMACIA_BUENA__SALUDDataSet;
        private System.Windows.Forms.BindingSource vistaVenta3BindingSource;
        private FARMACIA_BUENA__SALUDDataSetTableAdapters.VistaVenta3TableAdapter vistaVenta3TableAdapter;
    }
}