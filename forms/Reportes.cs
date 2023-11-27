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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.VistaProductos1' table. You can move, or remove it, as needed.
            this.vistaProductos1TableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.VistaProductos1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReporteProductos reporteProductos = new ReporteProductos();
            reporteProductos.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReporteEmpleados reporteEmpleados = new ReporteEmpleados();
            reporteEmpleados.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReportesProveedores reportesProveedores = new ReportesProveedores();
            reportesProveedores.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReportesVentas reportesVentas = new ReportesVentas();
            reportesVentas.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReporteCompras reporteCompras = new ReporteCompras();
            reporteCompras.Show();
            this.Hide();
        }
    }
}
