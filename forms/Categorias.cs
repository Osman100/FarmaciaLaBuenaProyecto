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
    public partial class Categorias : Form


    {
        

        Categoria categoria = new Categoria();
        classes.RCategorias rCategoria = new classes.RCategorias();
        public Categorias()
        {
            InitializeComponent();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Muestra los valores en los TextBox
        
                IDCategorias.Text = selectedRow.Cells["idCategoriaDataGridViewTextBoxColumn"].Value.ToString();
                NombreCategorias.Text= selectedRow.Cells["nombreCategoriaDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)


        {

            string nuevoNombre = NombreCategorias.Text;
            categoria.nombreCategoria =  nuevoNombre; // Suponiendo que tienes un TextBox para ingresar el nombre de la categoría

            int resultado = rCategoria.create(categoria);

            if (resultado != -1)
            {
                // La categoría se agregó correctamente
                MessageBox.Show("Categoría agregada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Puedes limpiar el TextBox si es necesario
                NombreCategorias.Text = "";
            }
            else
            {
                // Ocurrió un error al agregar la categoría
                MessageBox.Show("Ocurrió un error al agregar la categoría", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.Categoria);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int idCategoria = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string nuevoNombre = NombreCategorias.Text;

            categoria.idCategoria = idCategoria;
            categoria.nombreCategoria = nuevoNombre;
            int resultado = rCategoria.update(categoria); 

            if(resultado != -1)
            {
                // La categoría se actualizó correctamente
                dataGridView1.DataSource = rCategoria.getAll();
                dataGridView1.Refresh();
                MessageBox.Show("Categoría actualizada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Puedes limpiar el TextBox si es necesario
                NombreCategorias.Text = "";
                IDCategorias.Text = "";
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
                int idEmpleado = Convert.ToInt32(selectedRow.Cells["idCategoriaDataGridViewTextBoxColumn"].Value);

                // Eliminar la fila de la base de datos utilizando el método delete
                int resultado = rCategoria.delete(idEmpleado);



                if (resultado != -1)
                {
                    // La fila se eliminó correctamente de la base de datos
                    MessageBox.Show("Fila eliminada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    // Asigna la lista de empleados al DataGridView
                    dataGridView1.DataSource = rCategoria.getAll();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            IDCategorias.Text = String.Empty;
            NombreCategorias.Text = String.Empty;
        }

        private void IDCategorias_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
