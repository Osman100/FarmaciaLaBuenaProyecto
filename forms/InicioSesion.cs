using La_Buena_Farmacia.classes;
using La_Buena_Farmacia.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_Buena_Farmacia
{
    public partial class InicioSesion : Form
    {
        public int idRol;
        REmpleado empleado = new REmpleado();
        RRoles rRoles = new RRoles();
        Empleado  empleados = new Empleado();
        private FARMACIA_BUENA__SALUDEntities2 db = new FARMACIA_BUENA__SALUDEntities2();


        public InicioSesion()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        public void login()
        {
            REmpleado nuevoEmpleado = new REmpleado();
            nuevoEmpleado.nombreEmpleado = nombreUsuario.Text;
            nuevoEmpleado.EmpleadoPassword = passwordUsuario.Text;

            




            bool respuesta = empleado.login(nuevoEmpleado);

            if (respuesta)
            {
                List<Empleado> empleados = db.Empleado.ToList();
                var empleadoFiltrado = empleados.Where(empleado => empleado.nombreEmpleado == nuevoEmpleado.nombreEmpleado).FirstOrDefault();
                int idRol = empleadoFiltrado.idRol;


                Program.AppContext.UsuarioActual = new Empleado();
                Program.AppContext.UsuarioActual.idEmpleado = empleadoFiltrado.idEmpleado;
                Program.AppContext.UsuarioActual.nombreEmpleado = empleadoFiltrado.nombreEmpleado;
                Program.AppContext.UsuarioActual.empleadoPassword = empleadoFiltrado.empleadoPassword;
                Program.AppContext.UsuarioActual.idRol = empleadoFiltrado.idRol;


                if (idRol == 1)
                {
                    idRol = 1;
                    forms.MenuPrincipal menu = new forms.MenuPrincipal();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    idRol = 2;
                    forms.MenuVendedores menu = new forms.MenuVendedores();
                    menu.Show();
                    this.Hide();
                }
                
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos","Error en el inicio de sesion", MessageBoxButtons.OK,MessageBoxIcon.Error);   
              
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.login();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(passwordUsuario.UseSystemPasswordChar == false)
            {
                passwordUsuario.UseSystemPasswordChar = true;
            }
            else
            {
                passwordUsuario.UseSystemPasswordChar = false;
            }
        

        }
    }
}
