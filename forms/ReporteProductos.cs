using La_Buena_Farmacia.classes;
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
    public partial class ReporteProductos : Form
    {

        private FARMACIA_BUENA__SALUDEntities2 db = new FARMACIA_BUENA__SALUDEntities2();
        RProductos rProductos = new RProductos();
        RCategorias rCategorias = new RCategorias();
        public ReporteProductos()
        {
            InitializeComponent();
        }

        private void ReporteProductos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.Categoria);
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.VistaProductos1' table. You can move, or remove it, as needed.
            this.vistaProductos1TableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.VistaProductos1);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            cmbPrecios.SelectedIndex = -1;
            cmbCategorias.SelectedIndex = -1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void RefreshReport1()
        {


                // Obtener la categoría seleccionada
                string categoriaSeleccionada = cmbCategorias.SelectedValue?.ToString(); // Ajusta según tu implementación


                // Obtener la consulta base sin filtros

                List<VistaProductos1> productos = db.VistaProductos1.ToList();

                // Aplicar filtros según las selecciones
                if (categoriaSeleccionada != null)
                {
                    productos = productos.Where(producto => producto.Categoria == categoriaSeleccionada).ToList();
                }
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Productos", productos));
                this.reportViewer1.RefreshReport();
          
            

            




        }

        private void RefreshReport2()
        {

                // Obtener el precio seleccionado
                decimal? precioSeleccionado = cmbPrecios.SelectedValue as decimal?; // Ajusta según tu implementación

                // Obtener la consulta base sin filtros

                List<VistaProductos1> productos = db.VistaProductos1.ToList();
                if (precioSeleccionado != null)
                {
                    productos = productos.Where(producto => producto.Precio == precioSeleccionado).ToList();

                }
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Productos", productos));
                this.reportViewer1.RefreshReport();
            
            
            
        }





        private void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshReport1();
        }

        private void cmbPrecios_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshReport2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbCategorias.SelectedIndex = -1;
            cmbPrecios.SelectedIndex = -1;

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Productos", db.VistaProductos1.ToList()));
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
