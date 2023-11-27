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
    public partial class ReporteEmpleados : Form
    {
        private FARMACIA_BUENA__SALUDEntities2 db = new FARMACIA_BUENA__SALUDEntities2();
        public ReporteEmpleados()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void ReporteEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.Rol' table. You can move, or remove it, as needed.
            this.rolTableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.Rol);
            // TODO: This line of code loads data into the 'fARMACIA_BUENA__SALUDDataSet.Empleados' table. You can move, or remove it, as needed.
            this.empleadosTableAdapter.Fill(this.fARMACIA_BUENA__SALUDDataSet.Empleados);

            this.reportViewer1.RefreshReport();
        }

        private void RefreshReport1()
        {
            // Obtener el rol seleccionado
            string rolSeleccionado = cmbRol.SelectedValue?.ToString(); // Ajusta según tu implementación
            List<Empleados> vistaEmpleados = db.Empleados.ToList();

            if(rolSeleccionado != null)
            {
                // Filtrar por rol
                vistaEmpleados = vistaEmpleados.Where(empleado => empleado.Rol == rolSeleccionado).ToList();
            }

            // Actualizar el origen de datos del reporte
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Empleados1", vistaEmpleados));
            reportViewer1.RefreshReport();


        }
        private void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshReport1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbRol.SelectedIndex = -1;
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Empleados1", db.Empleados.ToList()));
            this.reportViewer1.RefreshReport();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.Show();
            this.Hide();
        }
    }
}
