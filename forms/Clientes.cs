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
    public partial class Clientes : Form
    {

        Cliente cliente = new Cliente();
        RCliente rcliente = new RCliente();
        public Clientes()
        {
            InitializeComponent();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nombreCliente = NombreCliente.Text;
            string email = EmailCliente.Text;
            string telefono = TelefonoCliente.Text;
            cliente.nombreCliente = nombreCliente;
            cliente.correoElectronico = email;
            cliente.númeroTelefónico = telefono;

            int resultado = rcliente.create(cliente);
            if(resultado != -1)
            {
                dataGridView1.DataSource = rcliente.getAll();
                MessageBox.Show(Text = "Cliente agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Text = "Error al agregar cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.Cliente);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

       
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idCliente = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                string nombreCliente = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string email = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string telefono = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                
                IDCliente.Text = idCliente.ToString();  
                NombreCliente.Text = nombreCliente;
                EmailCliente.Text = email;
                TelefonoCliente.Text = telefono;
                cliente.idCliente = idCliente;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int idCliente = int.Parse(IDCliente.Text);
                string nombreCliente = NombreCliente.Text;
                string email = EmailCliente.Text;
                string telefono = TelefonoCliente.Text;

                cliente.idCliente = idCliente;
                cliente.nombreCliente = nombreCliente;
                cliente.correoElectronico = email;
                cliente.númeroTelefónico = telefono;

                int resultado = rcliente.update(cliente);

                if(resultado != -1)
                {
                    dataGridView1.DataSource = rcliente.getAll();
                    MessageBox.Show(Text = "Cliente editado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Text = "Error al editar cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show(Text = "Seleccione un cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }   
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int idCliente = int.Parse(IDCliente.Text);
                string nombreCliente = NombreCliente.Text;
                string email = EmailCliente.Text;
                string telefono = TelefonoCliente.Text;

                cliente.idCliente = idCliente;
                cliente.nombreCliente = nombreCliente;
                cliente.correoElectronico = email;
                cliente.númeroTelefónico = telefono;

                int resultado = rcliente.delete(idCliente);

                if (resultado != -1)
                {
                    dataGridView1.DataSource = rcliente.getAll();
                    MessageBox.Show(Text = "Cliente eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Text = "Error al eliminar cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show(Text = "Seleccione un cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            IDCliente.Text = string.Empty;
            NombreCliente.Text = string.Empty;
            EmailCliente.Text = string.Empty;
            TelefonoCliente.Text = string.Empty;
            dataGridView1.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Categorias categorias = new Categorias();
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
            Vendedores vendedores = new Vendedores();
            vendedores.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }
    }
}
