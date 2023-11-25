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
    public partial class MenuVendedores : Form
    {
        public MenuVendedores()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TarjetasCredito tarjetaCredito = new TarjetasCredito();
            tarjetaCredito.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            InicioSesion inicioSesion = new InicioSesion();
            inicioSesion.Show();
            this.Hide();
        }
    }
}
