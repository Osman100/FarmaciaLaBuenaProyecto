using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_Buena_Farmacia.forms
{
    public partial class ReporteCompras : Form
    {
        private FARMACIA_BUENA__SALUDEntities2 db = new FARMACIA_BUENA__SALUDEntities2();
        public ReporteCompras()
        {
            InitializeComponent();
        }

        private void ReporteCompras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.VistaCompra' table. You can move, or remove it, as needed.
            this.vistaCompraTableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.VistaCompra);

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = InicioCompras.Value;
            DateTime fechaFin = FinalCompras.Value;

            List<VistaCompra> vistaCompras = db.VistaCompra.ToList();

            vistaCompras = vistaCompras.Where(compra => compra.Fecha >= fechaInicio && compra.Fecha <= fechaFin).ToList();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Compras", vistaCompras));
            reportViewer1.RefreshReport();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Compras", db.VistaCompra.ToList()));
            reportViewer1.RefreshReport();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.Show();
            this.Hide();
        }
    }
}
