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
    public partial class Ventas : Form
    {

        private FARMACIA_BUENA__SALUDEntities2 db = new FARMACIA_BUENA__SALUDEntities2();
        private Venta venta = new Venta();
        private DetalleVenta detalleVenta = new DetalleVenta();
        private classes.RVentas rVenta = new classes.RVentas();
        private classes.RDetalleVenta rDetalleVenta = new classes.RDetalleVenta();
        private classes.RTarjetaCredito rTarjetaCredito = new classes.RTarjetaCredito();
        private classes.RProductos rProducto = new classes.RProductos();
        private classes.RDetalleVenta rDetalle = new classes.RDetalleVenta();
        private classes.RCategorias rCategoria = new classes.RCategorias();

        public Ventas()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.Categoria);
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.Venta' table. You can move, or remove it, as needed.
            this.ventaTableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.Venta);
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.TarjetaCredito' table. You can move, or remove it, as needed.
            this.tarjetaCreditoTableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.TarjetaCredito);
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet1.Empleado' table. You can move, or remove it, as needed.
            this.empleadoTableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet1.Empleado);

            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.VistaDetalleVenta4' table. You can move, or remove it, as needed.
            this.vistaDetalleVenta4TableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.VistaDetalleVenta4);
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.VistaDetalleVenta3' table. You can move, or remove it, as needed.
            this.vistaDetalleVenta3TableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.VistaDetalleVenta3);
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.VistaVenta3' table. You can move, or remove it, as needed.
            this.vistaVenta3TableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.VistaVenta3);
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.VistaDetalleVenta' table. You can move, or remove it, as needed.
            this.vistaDetalleVentaTableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.VistaDetalleVenta);
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.VistaCompra' table. You can move, or remove it, as needed.
            this.vistaCompraTableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.VistaCompra);
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.Cliente);
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.VistaVenta' table. You can move, or remove it, as needed.

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
            if (comboBox3.Items.Count > 0 && comboBox3.SelectedValue != null)
            {
                int idVentaSeleccionada = (int)comboBox3.SelectedValue;
                List<VistaDetalleVenta4> detalleVenta = db.VistaDetalleVenta4.Where(c => c.ID_de_venta == idVentaSeleccionada).ToList();
                dataGridView1.DataSource = detalleVenta;

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos producto = new Productos();
            producto.Show();
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
            Categorias categoria = new Categorias();
            categoria.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();
            proveedores.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int idCliente = (int)comboBoxCliente.SelectedValue;

            int idEmpleado = 0;
            if (idVendedor.SelectedValue != null)
            {
                DataRowView drv = (DataRowView)idVendedor.SelectedItem;
                idEmpleado = Convert.ToInt32(drv["idEmpleado"]);

            }
             
            string tipo = (string)tipoVenta.SelectedItem;
            DateTime fecha = DateTime.Parse(FechaCompras.Text);


            venta.idCliente = idCliente;
            venta.idEmpleado = idEmpleado;
            venta.tipoVenta = tipo;

            if (tipo == "Tarjeta de credito")
            {

                int idTarjeta = (int)tarjeta.SelectedValue;
                venta.idTarjetaCredito = idTarjeta;
            }
            else
            {
                venta.idTarjetaCredito = null;

            }

            venta.fechaVenta = fecha;

            venta.total = 0;
            int resultado = rVenta.create(venta);

            if (resultado != -1)
            {
                dataGridView2.DataSource = db.VistaVenta3.ToList();
                comboBox3.DataSource = db.VistaVenta3.ToList();
                //comboBox3.DataSource = db.VistaCompra.ToList();
                //comboBox3.DisplayMember = "ID";
                //comboBox3.ValueMember = "ID";

                MessageBox.Show(Text = "Compra agregada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrió un error al agregar la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {


            //Actualiza campos de texto en base a la fila seleccionada en el datagridview
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idDetalleVenta = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
                VistaDetalleVenta4 detalleVenta = db.VistaDetalleVenta4.FirstOrDefault(c => c.ID == idDetalleVenta);
                string nombreProducto = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                int idVenta = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                if (detalleVenta != null)
                {


                    // Luego puedes usar idCategoria en tu lógica
                    List<Producto> producto = rProducto.getAll();
                    List<Producto> productosFiltrados = producto.Where(c => c.nombreProducto == nombreProducto).ToList();


                    // Configura el ComboBox de Productos con los productos filtrados


                    comboBox3.SelectedValue = idVenta;
                    comboBox1.SelectedValue = productosFiltrados[0].idCategoria;
                    comboBox2.DataSource = productosFiltrados;
                    comboBox2.DisplayMember = "nombreProducto";
                    Producto productoSeleccionado = (Producto)comboBox2.SelectedItem;

                    // Muestra el precio en el TextBox (o cualquier otro control que uses)
                    textBoxPrecio.Text = productoSeleccionado.precioProducto.ToString();

                    int cantidadFilaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);

                    // Establece el valor del TextBox con la cantidad de la fila seleccionada
                    CantidadVentas.Text = cantidadFilaSeleccionada.ToString();


                }
            }

        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            

            if (dataGridView2.SelectedRows.Count > 0)
            {
                string nombreCliente = (string)dataGridView2.SelectedRows[0].Cells[1].Value;
                int idCliente = rVenta.obtenerIDClientePorNombre(nombreCliente);
                string nombreEmpleado = (string)dataGridView2.SelectedRows[0].Cells[4].Value;
                int idEmpleado = rVenta.obtenerIDVendedorPorNombre(nombreEmpleado);
                tipoVenta.Text = (string)dataGridView2.SelectedRows[0].Cells[2].Value;
                if(tipoVenta.Text == "Tarjeta de credito")
                {
                    string numeroTarjeta = (string)dataGridView2.SelectedRows[0].Cells[3].Value;
                    int idTarjeta = rVenta.encontrarIDTarjetaPorNumero(numeroTarjeta);
                    tarjeta.SelectedValue = idTarjeta;
                }
                else
                {

                }
                

                IDVenta.Text = Convert.ToString(dataGridView2.SelectedRows[0].Cells[0].Value);
                comboBoxCliente.SelectedValue = idCliente;
                idVendedor.SelectedValue = idEmpleado;
               
                FechaCompras.Text = Convert.ToString(dataGridView2.SelectedRows[0].Cells[5].Value);
                total.Text = Convert.ToString(dataGridView2.SelectedRows[0].Cells[6].Value);


                

                
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(dataGridView2.SelectedRows.Count > 0)
            {
                int idVenta = (int)dataGridView2.SelectedRows[0].Cells[0].Value;
                int idCliente = (int)comboBoxCliente.SelectedValue;
                int idEmpleado = (int)idVendedor.SelectedValue;
                string tipo = (string)tipoVenta.SelectedItem;
                DateTime fecha = DateTime.Parse(FechaCompras.Text);
                if (tipo == "Tarjeta de credito")
                {

                    int idTarjeta = (int)tarjeta.SelectedValue;
                    venta.idTarjetaCredito = idTarjeta;
                }
                else
                {
                    venta.idTarjetaCredito = null;

                }

                venta.idVenta = idVenta;
                venta.idCliente = idCliente;
                venta.idEmpleado = idEmpleado;
                venta.tipoVenta = tipo;
                venta.fechaVenta = fecha;
                venta.total = 0;
                int resultado = rVenta.update(venta);

                if (resultado != -1)
                {
                    dataGridView2.DataSource = db.VistaVenta3.ToList();
                    MessageBox.Show(Text = "Compra actualizada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al actualizar la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna compra seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxCliente.SelectedValue != null)
            {
                int idCliente = (int)comboBoxCliente.SelectedValue;
                var tarjetas = db.TarjetaCredito.Where(t => t.idCliente == idCliente).ToList();
                tarjeta.DataSource = tarjetas;

            }
            
        }

        private void tipoVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            string metodoPago = (string)tipoVenta.SelectedItem;

            if (metodoPago == "Efectivo")
            {
                tarjeta.Enabled = false;
                tarjeta.SelectedIndex = -1;
            }
            else
            {
                tarjeta.Enabled = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(dataGridView2.SelectedRows.Count > 0)
            {
                List<DetalleVenta> detalleVenta = db.DetalleVenta.ToList();
                var detalleVentaFiltrado = detalleVenta.Where(c => c.idVenta == (int)dataGridView2.SelectedRows[0].Cells[0].Value).ToList();

                db.DetalleVenta.RemoveRange(detalleVentaFiltrado);
                db.SaveChanges();


                int idVenta = (int)dataGridView2.SelectedRows[0].Cells[0].Value;
                int resultado = rVenta.delete(idVenta);

                if (resultado != -1)
                {
                    dataGridView2.DataSource = db.VistaVenta3.ToList();
                    comboBox3.DataSource = db.VistaVenta3.ToList();
                    comboBox3.SelectedIndex = -1;
                    MessageBox.Show(Text = "Compra eliminada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al eliminar la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna compra seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Items.Count > 0 && comboBox3.SelectedValue != null)
            {
                int idVentaSeleccionada = (int)comboBox3.SelectedValue;
                List<VistaDetalleVenta4> detalleVenta = db.VistaDetalleVenta4.Where(c => c.ID_de_venta == idVentaSeleccionada).ToList();
                dataGridView1.DataSource = detalleVenta;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void button12_Click(object sender, EventArgs e)
        {
            //Agrega el producto a la lista de productos
            int IDVenta = Convert.ToInt32(comboBox3.SelectedValue);
            Producto productoSeleccionado = (Producto)comboBox2.SelectedItem;
            int idProducto = productoSeleccionado.idProducto;
            if(CantidadVentas.Text != "")
            {
                int cantidad = Convert.ToInt32(CantidadVentas.Text);
                decimal precio = Convert.ToDecimal(textBoxPrecio.Text);
                decimal total = cantidad * precio;
                detalleVenta.idVenta = IDVenta;
                detalleVenta.idProducto = idProducto;
                detalleVenta.cantidadProducto = cantidad;
                detalleVenta.subtotal = total;

                int resultado = rDetalleVenta.create(detalleVenta);
                if (resultado != -1)
                {
                    decimal totalVenta = rDetalle.CalcularTotal(IDVenta);
                    rVenta.actualizarTotalVenta(IDVenta, totalVenta);
                    if (comboBox3.Items.Count > 0 && comboBox3.SelectedValue != null)
                    {
                        int idVentaSeleccionada = (int)comboBox3.SelectedValue;
                        List<VistaDetalleVenta4> detalleVenta = db.VistaDetalleVenta4.Where(c => c.ID_de_venta == idVentaSeleccionada).ToList();
                        dataGridView1.DataSource = detalleVenta;

                    }
                    dataGridView2.DataSource = db.VistaVenta3.ToList();
                    db.decreaseStock(idProducto, cantidad);

                    MessageBox.Show(Text = "Producto agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al agregar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Ingrese una cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Actualiza el producto de la lista de productos
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int idVenta = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                int idDetalleVenta = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
                int cantidadInicial = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);

                Producto productoSeleccionado = (Producto)comboBox2.SelectedItem;
                int idProducto = productoSeleccionado.idProducto;
                int cantidad = Convert.ToInt32(CantidadVentas.Text);
                decimal precio = Convert.ToDecimal(textBoxPrecio.Text);
                decimal total = cantidad * precio;

                detalleVenta.idDetalle = idDetalleVenta;
                detalleVenta.idVenta = idVenta;
                detalleVenta.idProducto = idProducto;
                detalleVenta.cantidadProducto = cantidad;
                detalleVenta.subtotal = total;

                int resultado = rDetalleVenta.update(detalleVenta);
                if(resultado != -1)
                {
                    decimal totalVenta = rDetalle.CalcularTotal(idVenta);
                    rVenta.actualizarTotalVenta(idVenta, totalVenta);
                    if (comboBox3.Items.Count > 0 && comboBox3.SelectedValue != null)
                    {
                        int idVentaSeleccionada = (int)comboBox3.SelectedValue;
                        List<VistaDetalleVenta4> detalleVenta = db.VistaDetalleVenta4.Where(c => c.ID_de_venta == idVentaSeleccionada).ToList();
                        dataGridView1.DataSource = detalleVenta;

                    }
                    db.increaseStock(idProducto, cantidadInicial);
                    db.decreaseStock(idProducto, cantidad);
                    
                    dataGridView2.DataSource = db.VistaVenta3.ToList();

                    MessageBox.Show(Text = "Producto actualizado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al actualizar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Eliminar el producto de la lista de productos
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int idDetalleVenta = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
                int idVenta = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                int cantidadInicial = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
                Producto productoSeleccionado = (Producto)comboBox2.SelectedItem;
                int idProducto = productoSeleccionado.idProducto;

                int resultado = rDetalleVenta.delete(idDetalleVenta);
                if(resultado != -1)
                {
                    decimal totalVenta = rDetalle.CalcularTotal(idVenta);
                    rVenta.actualizarTotalVenta(idVenta, totalVenta);
                    if (comboBox3.Items.Count > 0 && comboBox3.SelectedValue != null)
                    {
                        int idVentaSeleccionada = (int)comboBox3.SelectedValue;
                        List<VistaDetalleVenta4> detalleVenta = db.VistaDetalleVenta4.Where(c => c.ID_de_venta == idVentaSeleccionada).ToList();
                        dataGridView1.DataSource = detalleVenta;

                    }
                    dataGridView2.DataSource = db.VistaVenta3.ToList();
                    db.increaseStock(idProducto, cantidadInicial);

                    MessageBox.Show(Text = "Producto eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al eliminar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (Program.AppContext.UsuarioActual.idRol == 1)
            {
                MenuPrincipal menuPrincipal = new MenuPrincipal();
                menuPrincipal.Show();
                this.Hide();
            }
            else
            {
                MenuVendedores menuVendedores = new MenuVendedores();
                menuVendedores.Show();
                this.Hide();
            }

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            if(dataGridView2.SelectedRows.Count > 0 )
            {
                PantallaFactura pantallaFactura = new PantallaFactura();

                int idVenta = (int)dataGridView2.SelectedRows[0].Cells[0].Value;
                Console.WriteLine("ID de Venta Seleccionado: " + idVenta);
                List<VistaDetalleVenta5> vistaDetalleVenta5s = db.VistaDetalleVenta5.ToList();
                var vistaDetalleVenta5Filtrado = vistaDetalleVenta5s.Where(c => c.IDDeVenta == (int)dataGridView2.SelectedRows[0].Cells[0].Value).ToList();
                List<VistaVenta3> vistaVenta3s = db.VistaVenta3.ToList();
                var vistaVenta3Filtrado = vistaVenta3s.Where(c => c.ID == (int)dataGridView2.SelectedRows[0].Cells[0].Value).ToList();

                DataTable venta = ConvertirListaADatatable(vistaVenta3Filtrado);
                DataTable detalleVenta = ConvertirListaADatatable(vistaDetalleVenta5Filtrado);

                ReportDataSource fuente1 = new ReportDataSource("Venta", venta);
                ReportDataSource fuente2 = new ReportDataSource("DetalleVenta", detalleVenta);



                PantallaFactura pantallaFactura1 = new PantallaFactura();
                pantallaFactura1.EditarSources(venta,detalleVenta);

                pantallaFactura1.ShowDialog();


            }
            else
            {
                MessageBox.Show("No hay ninguna compra seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        // Método para convertir una lista a un DataTable
        static DataTable ConvertirListaADatatable<T>(List<T> lista)
        {
            DataTable dataTable = new DataTable();

            // Obtén las propiedades de la clase (los nombres de las columnas)
            var propiedades = typeof(T).GetProperties();

            // Agrega las columnas al DataTable
            foreach (var propiedad in propiedades)
            {
                dataTable.Columns.Add(propiedad.Name, propiedad.PropertyType);
            }

            // Agrega las filas al DataTable
            foreach (var elemento in lista)
            {
                DataRow fila = dataTable.NewRow();

                foreach (var propiedad in propiedades)
                {
                    fila[propiedad.Name] = propiedad.GetValue(elemento);
                }

                dataTable.Rows.Add(fila);
            }

            return dataTable;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Deseleccionar venta
            if(dataGridView2.SelectedRows.Count > 0)
            {
                dataGridView2.ClearSelection();

                comboBoxCliente.SelectedIndex = -1;
                idVendedor.SelectedIndex = -1;
                tipoVenta.SelectedIndex = -1;
                tarjeta.SelectedIndex = -1;
                FechaCompras.Text = "";
                total.Text = "";
            }
            else
            {
                MessageBox.Show("No hay ninguna compra seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //Deseleccionar un producto de la lista de productos
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.ClearSelection();
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;


                textBoxPrecio.Text = "";
                CantidadVentas.Text = "";
            }
            else
            {
                MessageBox.Show("No hay ningun producto seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
