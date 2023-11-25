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
    public partial class ReportesProveedores : Form
    {
        public ReportesProveedores()
        {
            InitializeComponent();
        }

        private void ReportesProveedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.Proveedor' table. You can move, or remove it, as needed.
            this.proveedorTableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.Proveedor);

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
