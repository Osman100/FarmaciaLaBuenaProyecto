﻿using La_Buena_Farmacia.classes;
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
    public partial class Vendedores : Form
    {

        Empleado empleado = new Empleado();
        REmpleado rEmpleado = new REmpleado();
        Rol rol = new Rol();
        RRoles rRoles = new RRoles();

        private FARMACIA_BUENA__SALUDEntities2 db = new FARMACIA_BUENA__SALUDEntities2();
        public Vendedores()
        {

            InitializeComponent();
            this.MaximizeBox = false;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            empleado.nombreEmpleado = NombreVendedores.Text;

            if(RolVendedores.Text == "Administrador" )
            {
                empleado.idRol = 1;
            }
            else
            {
                empleado.idRol = 2;
            }
            empleado.empleadoPassword = rEmpleado.MD5Hash(PasswordVendedores.Text);
            empleado.estadoLaboral = EstadoVendedores.Text;
            empleado.salario = decimal.Parse(SalarioVendedores.Text);

            int resultado = rEmpleado.create(empleado);

            if (resultado != -1)

            {

                List<Empleado> empleados = rEmpleado.getAll();

                dataGridView1.DataSource = empleados;

                dataGridView1.Refresh();

                // El empleado se agregó correctamente a la base de datos
                MessageBox.Show("Empleado agregado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Puedes limpiar los campos del formulario si es necesario
                NombreVendedores.Text = "";
                RolVendedores.SelectedIndex = -1; // Limpia la selección
                PasswordVendedores.Text = "";
                EstadoVendedores.Text = "";
                SalarioVendedores.Text = "";
            }
            else
            {
                // Ocurrió un error al agregar el empleado
                MessageBox.Show("Ocurrió un error al agregar el empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void Vendedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.Empleados' table. You can move, or remove it, as needed.
            this.empleadosTableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.Empleados);
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.Rol' table. You can move, or remove it, as needed.
            this.rolTableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.Rol);
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.Empleado' table. You can move, or remove it, as needed.
            this.empleadoTableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.Empleado);

        }

#pragma warning disable IDE1006 // Naming Styles
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            if (dataGridView1.SelectedRows.Count > 0) // Si hay una fila seleccionada
            {
                
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0]; // Selecciona la primera fila seleccionada

                int idEmpleado = Convert.ToInt32(selectedRow.Cells[0].Value);
                string nombreEmpleado = selectedRow.Cells[1].Value.ToString();
                string nombreRol = selectedRow.Cells[2].Value.ToString();
                string estadoLaboral = selectedRow.Cells[3].Value.ToString();
                string salario = selectedRow.Cells[4].Value.ToString();
                List<Rol> roles = rRoles.getAll();
                int idRol = roles.Where(rol => rol.nombreRol == nombreRol).FirstOrDefault().idRol;


                NombreVendedores.Text = nombreEmpleado;
                EstadoVendedores.Text = estadoLaboral;
                SalarioVendedores.Text = salario;
                PasswordVendedores.Text = string.Empty;
                RolVendedores.SelectedValue = idRol;



            }
        }




        


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
            // Verifica si se ha seleccionado alguna fila en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int idEmpleado = Convert.ToInt32(selectedRow.Cells[0].Value);
                string nombreEmpleado = selectedRow.Cells[1].Value.ToString();
                string nombreRol = selectedRow.Cells[2].Value.ToString();
                string estadoLaboral = selectedRow.Cells[3].Value.ToString();
                string salario = selectedRow.Cells[4].Value.ToString();
                List<Rol> roles = rRoles.getAll();
                int idRol = roles.Where(rol => rol.nombreRol == nombreRol).FirstOrDefault().idRol;

                // Asigna los valores a los campos del formulario
                IDVendedores.Text = Convert.ToString(idEmpleado);
                NombreVendedores.Text = nombreEmpleado;
                PasswordVendedores.Text = string.Empty;
                EstadoVendedores.Text = estadoLaboral;
                RolVendedores.SelectedValue = idRol;
                SalarioVendedores.Text = salario.ToString();
            }
        }


        private void IDVendedores_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int id = Convert.ToInt32(selectedRow.Cells[0].Value);

                string nuevoNombre = NombreVendedores.Text;
                int nuevoRol = (int)RolVendedores.SelectedValue;
                string nuevoPassword = rEmpleado.MD5Hash(PasswordVendedores.Text);
                string nuevoEstado = EstadoVendedores.Text;
                decimal nuevoSalario = Convert.ToDecimal(SalarioVendedores.Text);

                empleado.idEmpleado = id;
                empleado.nombreEmpleado = nuevoNombre;
                empleado.idRol = Convert.ToInt32(nuevoRol);
                empleado.empleadoPassword = nuevoPassword;
                empleado.estadoLaboral = nuevoEstado;
                empleado.salario = nuevoSalario;

                List<Empleados> empleados = db.Empleados.ToList();

                // Asigna la lista de empleados al DataGridView
                dataGridView1.DataSource = empleados;
                dataGridView1.Refresh();

                int resultado = rEmpleado.update(empleado);
                if (resultado != -1)
                {
                    // Los datos se actualizaron correctamente en la base de datos
                    MessageBox.Show("Datos actualizados con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Ocurrió un error al actualizar los datos en la base de datos
                    MessageBox.Show("Ocurrió un error al actualizar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Acceder al valor de la clave primaria (ID) de la fila seleccionada
                int idEmpleado = Convert.ToInt32(selectedRow.Cells[0].Value);

                // Eliminar la fila de la base de datos utilizando el método delete
                int resultado = rEmpleado.delete(idEmpleado);



                if (resultado != -1)
                {
                    // La fila se eliminó correctamente de la base de datos
                    MessageBox.Show("Fila eliminada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<Empleados> empleados = db.Empleados.ToList();

                    // Asigna la lista de empleados al DataGridView
                    dataGridView1.DataSource = empleados;
                    dataGridView1.Refresh();

                }
                else
                {
                    // Ocurrió un error al eliminar la fila
                    MessageBox.Show("Ocurrió un error al eliminar la fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // No se ha seleccionado ninguna fila
                MessageBox.Show("Por favor, seleccione una fila para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button10_Click(object sender, EventArgs e)

        {
            dataGridView1.ClearSelection();
            IDVendedores.Text = string.Empty;
            NombreVendedores.Text = string.Empty;
            RolVendedores.SelectedIndex = -1;
            PasswordVendedores.Text = string.Empty;
            EstadoVendedores.Text = string.Empty;
            SalarioVendedores.Text = string.Empty;


        }

        private void button7_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }
    }
}
