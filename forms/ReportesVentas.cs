using Microsoft.Reporting.WinForms;
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
    public partial class ReportesVentas : Form
    {
        private FARMACIA_BUENA__SALUDEntities2 db = new FARMACIA_BUENA__SALUDEntities2();
        public ReportesVentas()
        {
            InitializeComponent();
            ActualizarValorTextBoxInforme();
            
        }

        private void ActualizarValorTextBoxInforme()
        {
            var productoMasVendido = db.VistaProductosMasVendidos.OrderByDescending(venta => venta.CantidadVendida).FirstOrDefault();

            if(productoMasVendido != null)
            {

                int cantidadVendida = (int)productoMasVendido.CantidadVendida;
                string nombreProducto = productoMasVendido.Nombre;

                
                ReportParameter parametro = new ReportParameter("MasVendido", nombreProducto);
                ReportParameter parametro2 = new ReportParameter("CantidadMasVendida", cantidadVendida.ToString());

                reportViewer1.LocalReport.SetParameters(parametro);
                reportViewer1.LocalReport.SetParameters(parametro2);
                reportViewer1.RefreshReport();
            }

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = InicioVentas.Value;
            DateTime fechaFin = FinalVentas.Value;

            List<VistaVenta3> vistaVentas = db.VistaVenta3.ToList();

            vistaVentas = vistaVentas.Where(venta => venta.Fecha >= fechaInicio && venta.Fecha <= fechaFin).ToList();

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Ventas", vistaVentas));
            reportViewer1.RefreshReport();


        }

        private void ReportesVentas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.VistaVenta3' table. You can move, or remove it, as needed.
            this.vistaVenta3TableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.VistaVenta3);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Ventas", db.VistaVenta3.ToList()));   
            this.reportViewer1.RefreshReport();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.Show();
            this.Hide();
        }
    }
}
