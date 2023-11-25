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
    public partial class Proveedores : Form
    {

        Proveedor proveedor = new Proveedor();
        classes.RProveedores rProveedor = new classes.RProveedores();
        Compras compras = new Compras();
        RCompras rCompras = new RCompras();
        DetalleCompra detalleCompra = new DetalleCompra();
        RDetalleCompra rDetalleCompra = new RDetalleCompra();

        public Proveedores()
        {
            InitializeComponent();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            

            if(dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                IDProveedores.Text = selectedRow.Cells["idProveedorDataGridViewTextBoxColumn"].Value.ToString();
                NombreProveedores.Text = selectedRow.Cells["nombreProveedorDataGridViewTextBoxColumn"].Value.ToString();
                TelefonoProveedores.Text = selectedRow.Cells["telefonoProveedorDataGridViewTextBoxColumn"].Value.ToString();


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.Proveedor' table. You can move, or remove it, as needed.
            this.proveedorTableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.Proveedor);

        }

        private void button4_Click(object sender, EventArgs e)
        {

            string nuevoNombre = NombreProveedores.Text;
            string nuevoTelefono = TelefonoProveedores.Text;


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

        private void button5_Click(object sender, EventArgs e)
        {
            int idProveedor = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string nuevoNombre = NombreProveedores.Text;
            string nuevoTelefono = TelefonoProveedores.Text;

            proveedor.idProveedor = idProveedor;
            proveedor.nombreProveedor = nuevoNombre;
            proveedor.telefonoProveedor = nuevoTelefono;

            int resultado = rProveedor.update(proveedor);

            if (resultado != -1)
            {
                // La categoría se actualizó correctamente
                dataGridView1.DataSource = rProveedor.getAll();
                dataGridView1.Refresh();
                MessageBox.Show("Categoría actualizada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Puedes limpiar el TextBox si es necesario
                NombreProveedores.Text = "";
                IDProveedores.Text = "";
            }
            else
            {
                // Ocurrió un error al actualizar la categoría
                MessageBox.Show("Ocurrió un error al actualizar la categoría", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Acceder al valor de la clave primaria (ID) de la fila seleccionada
                int idProveedor = Convert.ToInt32(selectedRow.Cells["idProveedorDataGridViewTextBoxColumn"].Value);


                List<Compra> compras = rCompras.getAll();

                List<DetalleCompra> detalleCompras = rDetalleCompra.getAll();

                var comprasFiltradas = compras.Where(compra => compra.idProveedor == idProveedor).ToList();
                var detalleComprasFiltradas = detalleCompras.Where(detalleCompra => detalleCompra.idCompra == comprasFiltradas[0].idCompra).ToList();

                detalleComprasFiltradas.ForEach(detalleCompra => rDetalleCompra.delete(detalleCompra.idDetalleCompra));
                comprasFiltradas.ForEach(compra => rCompras.delete(compra.idCompra));

                // Eliminar la fila de la base de datos utilizando el método delete
                int resultado = rProveedor.delete(idProveedor);



                if (resultado != -1)
                {
                    // La fila se eliminó correctamente de la base de datos
                    MessageBox.Show("Proveedor eliminado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    // Asigna la lista de empleados al DataGridView
                    dataGridView1.DataSource = rProveedor.getAll();
                    dataGridView1.Refresh();

                }
                else
                {
                    // Ocurrió un error al eliminar la fila
                    MessageBox.Show("Ocurrió un error al eliminar el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // No se ha seleccionado ninguna fila
                MessageBox.Show("Por favor, seleccione un proveedor para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos productos  = new Productos();
            productos.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vendedores vendedores = new Vendedores();
            vendedores.Show();
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
            Categorias categorias = new Categorias();
            categorias.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Compras compras = new Compras();
            compras.Show();
            this.Hide();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        private void NombreProveedores_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
