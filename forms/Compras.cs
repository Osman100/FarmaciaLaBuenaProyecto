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
        Compra compra = new Compra();
        classes.RCompras rCompra = new classes.RCompras();
        DetalleCompra detalleCompra = new DetalleCompra();
        classes.RDetalleCompra rDetalleCompra = new RDetalleCompra();
        private FARMACIA_BUENA__SALUDEntities2 db = new FARMACIA_BUENA__SALUDEntities2();


        public Compras()
        {
            InitializeComponent();
        }

        
        private void Compras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.Proveedor' table. You can move, or remove it, as needed.
            this.proveedorTableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.Proveedor);
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

            comboBox3_SelectedIndexChanged(sender, e);

        }

        private void button4_Click(object sender, EventArgs e)
        {


         
            int proveedorID = (int)comboBoxProveedor.SelectedValue;
            DataRowView selectedRow = (DataRowView)comboBox3.SelectedItem;
            int idCompra = Convert.ToInt32(selectedRow["ID"]);
            string categoria = tipoCompras.Text;
            DateTime fecha = DateTime.Parse(FechaCompras.Text);
            string tipo = tipoCompras.Text;
            Producto productoSeleccionado = (Producto)comboBox2.SelectedItem;
            int idProducto = productoSeleccionado.idProducto;
            decimal nuevoPrecio = decimal.Parse(textBoxPrecio.Text);
            int nuevaCantidad = int.Parse(CantidadCompras.Text);
            decimal subtotal = nuevaCantidad * nuevoPrecio;
            

            detalleCompra.idCompra = idCompra;
            detalleCompra.idProducto = idProducto;
            detalleCompra.cantidadProducto = nuevaCantidad;
            detalleCompra.subtotal = subtotal;
            

            int resultado = rDetalleCompra.create(detalleCompra);


            if (resultado != -1)
            {

                dataGridView2.DataSource = db.VistaDetalleCompra.ToList();
                dataGridView1.DataSource = db.VistaCompra.ToList();
                decimal totalCompra = rDetalleCompra.CalcularTotalCompra(idCompra);
                rCompra.ActualizarTotalCompra(idCompra,totalCompra);

                dataGridView1.DataSource = db.VistaCompra.ToList();

                MessageBox.Show(Text = "Producto agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                // Ocurrió un error al agregar el empleado
                MessageBox.Show("Ocurrió un error al agregar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada
            
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

        private void button6_Click_1(object sender, EventArgs e)
        {
            string nuevoID = IDCompras.Text;
            int proveedorID = (int)comboBoxProveedor.SelectedValue;
            string categoria = tipoCompras.Text;
            DateTime fecha = DateTime.Parse(FechaCompras.Text);
            string tipo = tipoCompras.Text;

            compra.idCompra = int.Parse(nuevoID);
            compra.idProveedor = proveedorID;
            compra.tipoCompra = categoria;
            compra.fechaCompra = fecha;
            compra.totalCompra = 0;

            int resultado = rCompra.create(compra);

            if(resultado != -1)
            {
                dataGridView1.DataSource = rCompra.getAll();
                MessageBox.Show(Text = "Compra agregada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrió un error al agregar la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            int idCompra = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCompraSeleccionada = (int)comboBox3.SelectedValue;
            List<VistaDetalleCompra> detalleCompra = db.VistaDetalleCompra.Where(c => c.ID == idCompraSeleccionada).ToList();
            dataGridView2.DataSource = detalleCompra;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }
    }
}
