using La_Buena_Farmacia.classes;
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
    public partial class Compras : Form
    {



        Producto producto = new Producto();
        classes.RProductos rProducto = new RProductos();

        public Compras()
        {
            InitializeComponent();
        }

        
        private void Compras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.VistaCompra' table. You can move, or remove it, as needed.
            this.vistaCompraTableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.VistaCompra);
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.VistaDetalleVenta' table. You can move, or remove it, as needed.
            this.vistaDetalleVentaTableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.VistaDetalleVenta);
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.VistaEmpleados' table. You can move, or remove it, as needed.
            this.vistaEmpleadosTableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.VistaEmpleados);
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.Categoria);
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.Compra' table. You can move, or remove it, as needed.
            this.compraTableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.Compra);
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.DetalleCompra' table. You can move, or remove it, as needed.
            this.detalleCompraTableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.DetalleCompra);

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tipoCompras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Asegúrate de que haya una fila seleccionada
            if (comboBox1.SelectedItem != null)
            {
                // Accede a la fila seleccionada
                DataRowView selectedRow = (DataRowView)comboBox1.SelectedItem;

                // Accede al valor específico de la columna que contiene el ID de la categoría
                int idCategoria = Convert.ToInt32(selectedRow["idCategoria"]);

                // Luego puedes usar idCategoria en tu lógica
                List<Producto> producto = rProducto.getAll();
                List<Producto> productosFiltrados = producto.Where(c => c.idCategoria == idCategoria).ToList();

                // Configura el ComboBox de Productos con los productos filtrados
                comboBox2.DataSource = productosFiltrados;
                comboBox2.DisplayMember = "nombreProducto";
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                Producto productoSeleccionado = (Producto)comboBox2.SelectedItem;

                // Muestra el precio en el TextBox (o cualquier otro control que uses)
                textBoxPrecio.Text = productoSeleccionado.precioProducto.ToString();
            }
        }
    }
}
