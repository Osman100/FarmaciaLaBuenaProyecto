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
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.Categoria);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nuevoNombre = NombreProductos.Text;
            string nuevoStock = StockProductos.Text;
            string nuevoPrecio = PrecioProducto.Text;
            string nuevaCategoria = CategoriaProductos.SelectedItem.ToString();


            proveedor.nombreProveedor = nuevoNombre; // Suponiendo que tienes un TextBox para ingresar el nombre de la categoría
            proveedor.telefonoProveedor = nuevoTelefono;
            int resultado = rProveedor.create(proveedor);

            if (resultado != -1)
            {
                // La categoría se agregó correctamente
                MessageBox.Show("Categoría agregada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView1.DataSource = rProveedor.getAll();
                // Puedes limpiar el TextBox si es necesario
                NombreProveedores.Text = "";
            }
            else
            {
                // Ocurrió un error al agregar la categoría
                MessageBox.Show("Ocurrió un error al agregar la categoría", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
