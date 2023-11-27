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
    public partial class TarjetasCredito : Form
    {
        TarjetaCredito tarjetaCredito = new TarjetaCredito();
        classes.RTarjetaCredito rTarjetaCredito = new classes.RTarjetaCredito();
        private FARMACIA_BUENA__SALUDEntities2 db = new FARMACIA_BUENA__SALUDEntities2();

        public TarjetasCredito()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            dataGridView1.DataSource = db.VistaTarjetas.ToList();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TarjetaCredito_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.Cliente);
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.VistaTarjetas' table. You can move, or remove it, as needed.
            this.vistaTarjetasTableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.VistaTarjetas);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tarjetaCredito.idCliente = Convert.ToInt32(cliente.SelectedValue);
            tarjetaCredito.numeroTarjeta = numeroTarjeta.Text;

            int resultado = rTarjetaCredito.create(tarjetaCredito);

            if (resultado > 0)
            {
                MessageBox.Show("Tarjeta de credito agregada correctamente");
                dataGridView1.DataSource = db.VistaTarjetas.ToList();
            }
            else
            {
                MessageBox.Show("Error al agregar tarjeta de credito");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                tarjetaCredito.idTarjeta = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                tarjetaCredito.idCliente = Convert.ToInt32(cliente.SelectedValue);
                tarjetaCredito.numeroTarjeta = numeroTarjeta.Text;

                int resultado = rTarjetaCredito.update(tarjetaCredito);

                if (resultado > 0)
                {
                    MessageBox.Show("Tarjeta de credito actualizada correctamente");
                    dataGridView1.DataSource = db.VistaTarjetas.ToList();
                }
                else
                {
                    MessageBox.Show("Error al actualizar tarjeta de credito");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }

        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                IDTarjetas.Text = Convert.ToString(id);
                tarjetaCredito = db.TarjetaCredito.Find(id);
                cliente.SelectedValue = tarjetaCredito.idCliente;
                numeroTarjeta.Text = tarjetaCredito.numeroTarjeta;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                int resultado = rTarjetaCredito.delete(id);

                if (resultado > 0)
                {
                    MessageBox.Show("Tarjeta de credito eliminada correctamente");
                    dataGridView1.DataSource = db.VistaTarjetas.ToList();
                }
                else
                {
                    MessageBox.Show("Error al eliminar tarjeta de credito");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Metodo para deseleccionar una fila
            if(dataGridView1.SelectedRows.Count > 0)
            {
                IDTarjetas.Text = string.Empty;
                cliente.SelectedIndex = -1;
                numeroTarjeta.Text = string.Empty;
                dataGridView1.ClearSelection();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if(Program.AppContext.UsuarioActual.idRol == 1)
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
    }
}
