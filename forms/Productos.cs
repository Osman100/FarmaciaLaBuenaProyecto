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

        public Productos()
        {
            InitializeComponent();
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
            string nuevaCategoria = CategoriaProductos.SelectedItem.ToString();

            producto.idProducto = int.Parse(nuevoId);
            producto.nombreProducto = nuevoNombre; // Suponiendo que tienes un TextBox para ingresar el nombre de la categoría
            producto.CantidadStock = int.Parse(nuevoStock);
            producto.precioProducto = decimal.Parse(nuevoPrecio);
            producto.idCategoria = int.Parse(nuevaCategoria);

            int resultado = rProducto.update(producto);

            if (resultado != -1)
            {
                // La categoría se actualizó correctamente
                dataGridView1.DataSource = rProducto.getAll();
                dataGridView1.Refresh();
                MessageBox.Show("Categoría actualizada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Puedes limpiar el TextBox si es necesario
                NombreProductos.Text = "";
                IDProductos.Text = "";


            }
            else
            {
                // Ocurrió un error al actualizar la categoría
                MessageBox.Show("Ocurrió un error al actualizar la categoría", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
