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
    public partial class Ventas : Form
    {

        private FARMACIA_BUENA__SALUDEntities2 db = new FARMACIA_BUENA__SALUDEntities2();
        private Venta venta = new Venta();
        private DetalleVenta detalleVenta = new DetalleVenta();
        private classes.RVentas rVenta = new classes.RVentas();
        private classes.RDetalleVenta rDetalleVenta = new classes.RDetalleVenta();

        public Ventas()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
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
            venta.fechaVenta = fecha;
            venta.total = 0;
            int resultado = rVenta.create(venta);

            if (resultado != -1)
            {
                dataGridView2.DataSource = db.VistaVenta3.ToList();
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
    }
}
