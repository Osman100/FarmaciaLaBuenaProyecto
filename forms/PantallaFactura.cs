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
    public partial class PantallaFactura : Form
    {
        public PantallaFactura()
        {
            InitializeComponent();
        }

        private void PantallaFactura_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.VistaVenta3' table. You can move, or remove it, as needed.
            this.vistaVenta3TableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.VistaVenta3);
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.VistaDetalleVenta4' table. You can move, or remove it, as needed.
            this.vistaDetalleVenta4TableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.VistaDetalleVenta4);

            this.reportViewer1.RefreshReport();
        }

        public void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        public Microsoft.Reporting.WinForms.ReportViewer ObtenerReportViewer()
        {
            return reportViewer1;
        }
    }
}
