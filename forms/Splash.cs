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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            metroProgressBar1.Value = startpoint;
            if(metroProgressBar1.Value == 100)
            {
                metroProgressBar1.Value = 0;
                timer1.Stop();
                InicioSesion login = new InicioSesion();
                this.Hide();
                login.Show();
            }
            else
            {
                metroProgressBar1.Value += 1;
            }   
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void metroProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
