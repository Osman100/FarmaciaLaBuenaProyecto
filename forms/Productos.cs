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
    public partial class Productos : Form
    {

        Producto producto = new Producto();
        classes.RProductos rProducto = new classes.RProductos();
        Categoria categoria = new Categoria();
        RCategorias rCategorias = new RCategorias();
        Venta Venta = new Venta();
        RVentas rVentas = new RVentas();
        RDetalleVenta rDetalleVenta = new RDetalleVenta();
        DetalleVenta detalleVenta = new DetalleVenta();
        Compra compra = new Compra();
        RCompras rCompra = new RCompras();
        private FARMACIA_BUENA__SALUDEntities2 db = new FARMACIA_BUENA__SALUDEntities2();


        public Productos()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            
            
            
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.VistaProductos1' table. You can move, or remove it, as needed.
            this.vistaProductos1TableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.VistaProductos1);
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.VistaVenta' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.VistaProductos' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.Producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.Producto);
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.Categoria);
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;



        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nuevoNombre = NombreProductos.Text;
            string nuevoStock = StockProductos.Text;
            string nuevoPrecio = PrecioProducto.Text;
            DataRowView selectedRow = (DataRowView)CategoriaProductos.SelectedItem;
            

            // Acceder al valor específico de la columna que contiene el ID de la categoría
            int idCategoriaSeleccionada = Convert.ToInt32(selectedRow["IdCategoria"]);


            producto.nombreProducto = nuevoNombre; // Suponiendo que tienes un TextBox para ingresar el nombre de la categoría
            producto.CantidadStock = int.Parse(nuevoStock);
            producto.precioProducto = decimal.Parse(nuevoPrecio);
            producto.idCategoria = idCategoriaSeleccionada;
            int resultado = rProducto.create(producto);


            if (resultado != -1)
            {
                // La categoría se agregó correctamente
                MessageBox.Show("Producto agregado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView1.Refresh();
                // Puedes limpiar el TextBox si es necesario
                NombreProductos.Text = "";
            }
            else
            {
                // Ocurrió un error al agregar la categoría
                MessageBox.Show("Ocurrió un error al agregar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {



            string nuevoId = IDProductos.Text;
            string nuevoNombre = NombreProductos.Text;
            string nuevoStock = StockProductos.Text;
            string nuevoPrecio = PrecioProducto.Text;
            string nuevaCategoria = CategoriaProductos.SelectedValue.ToString();
            List<Producto> productos = rProducto.getAll();
            List<Categoria> categorias = rCategorias.getAll();
            List<Categoria> categoriaFiltrada = categorias.Where(c => c.idCategoria == int.Parse(nuevaCategoria)).ToList();

            producto.idProducto = int.Parse(nuevoId);
            producto.nombreProducto = nuevoNombre; // Suponiendo que tienes un TextBox para ingresar el nombre de la categoría
            producto.CantidadStock = int.Parse(nuevoStock);
            producto.precioProducto = decimal.Parse(nuevoPrecio);

            producto.idCategoria = categoriaFiltrada[0].idCategoria;

            int resultado = rProducto.update(producto);

            if (resultado != -1)
            {
                // La categoría se actualizó correctamente
                dataGridView1.DataSource = db.VistaProductos1;
                dataGridView1.Refresh();
                MessageBox.Show("Producto actualizado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Puedes limpiar el TextBox si es necesario
                NombreProductos.Text = "";
                IDProductos.Text = "";


            }
            else
            {
                // Ocurrió un error al actualizar la categoría
                MessageBox.Show("Ocurrió un error al actualizar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vendedores vendedores = new Vendedores();
            vendedores.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Categorias categorias  = new Categorias();  
            categorias.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.Show();
            this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();
            proveedores.Show();
            this.Hide();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Compras compras = new Compras();
            compras.Show();
            this.Hide();
        }

        private void IDProductos_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Eliminar producto
            if(dataGridView1.SelectedRows.Count > 0)
            {
                 int idProductoSeleccionado = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                 List<Producto> products = rProducto.getAll();
                List<Producto> productoFiltrado = products.Where(p => p.idProducto == idProductoSeleccionado).ToList();
                List<DetalleVenta> detalleVentas = rDetalleVenta.getAll();
                List<DetalleVenta> detalleVentaFiltrado = detalleVentas.Where(d => d.idProducto == productoFiltrado[0].idProducto).ToList();
                if(detalleVentaFiltrado.Count > 0)
                {
                    MessageBox.Show("No se puede eliminar el producto porque tiene ventas asociadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int resultado = rProducto.delete(idProductoSeleccionado);
                    if (resultado != -1)
                    {
                        MessageBox.Show("Producto eliminado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = db.VistaProductos1.ToList();
                        dataGridView1.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al eliminar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            

            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Cambio de selección");
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                // Obtener el ID de la categoría seleccionada
                int idProductoSeleccionado = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                // Obtener la categoría seleccionada
                List<Producto> productos = rProducto.getAll();  
                List<Producto> productoFiltrado = productos.Where(p => p.idProducto == idProductoSeleccionado).ToList();
                List<Categoria> categorias = rCategorias.getAll();
                List<Categoria> categoriaFiltrada = categorias.Where(c => c.idCategoria == productoFiltrado[0].idCategoria).ToList();

               

                // Mostrar la categoría en los TextBox
                IDProductos.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                NombreProductos.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                StockProductos.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                PrecioProducto.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                CategoriaProductos.SelectedValue = categoriaFiltrada[0].idCategoria;
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            //Deseleccionar producto 
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.ClearSelection();
                IDProductos.Text = "";
                NombreProductos.Text = "";
                StockProductos.Text = "";
                PrecioProducto.Text = "";
                CategoriaProductos.SelectedIndex = -1;
            }
        }
    }
}
