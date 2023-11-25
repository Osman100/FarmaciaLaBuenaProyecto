using System;
using System.Windows.Forms;

namespace La_Buena_Farmacia.forms
{
    partial class Vendedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vendedores));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.SalarioVendedores = new System.Windows.Forms.TextBox();
            this.PasswordVendedores = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RolVendedores = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fARMACIABUENASALUDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fARMACIA_BUENA__SALUDDataSet = new La_Buena_Farmacia.FARMACIA_BUENA__SALUDDataSet();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.EstadoVendedores = new System.Windows.Forms.TextBox();
            this.NombreVendedores = new System.Windows.Forms.TextBox();
            this.IDVendedores = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.empleadoTableAdapter = new La_Buena_Farmacia.FARMACIA_BUENA__SALUDDataSetTableAdapters.EmpleadoTableAdapter();
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolTableAdapter = new La_Buena_Farmacia.FARMACIA_BUENA__SALUDDataSetTableAdapters.RolTableAdapter();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosTableAdapter = new La_Buena_Farmacia.FARMACIA_BUENA__SALUDDataSetTableAdapters.EmpleadosTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIABUENASALUDDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA_BUENA__SALUDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.SalarioVendedores);
            this.panel1.Controls.Add(this.PasswordVendedores);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.RolVendedores);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.EstadoVendedores);
            this.panel1.Controls.Add(this.NombreVendedores);
            this.panel1.Controls.Add(this.IDVendedores);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 450);
            this.panel1.TabIndex = 1;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.Menu;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.button10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button10.Location = new System.Drawing.Point(103, 419);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(125, 28);
            this.button10.TabIndex = 21;
            this.button10.Text = "Deseleccionar";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // SalarioVendedores
            // 
            this.SalarioVendedores.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalarioVendedores.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SalarioVendedores.Location = new System.Drawing.Point(113, 332);
            this.SalarioVendedores.Name = "SalarioVendedores";
            this.SalarioVendedores.Size = new System.Drawing.Size(207, 26);
            this.SalarioVendedores.TabIndex = 20;
            // 
            // PasswordVendedores
            // 
            this.PasswordVendedores.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordVendedores.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PasswordVendedores.Location = new System.Drawing.Point(112, 212);
            this.PasswordVendedores.Name = "PasswordVendedores";
            this.PasswordVendedores.Size = new System.Drawing.Size(208, 26);
            this.PasswordVendedores.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Menu;
            this.label7.Location = new System.Drawing.Point(12, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Contraseña:";
            // 
            // RolVendedores
            // 
            this.RolVendedores.DataSource = this.rolBindingSource1;
            this.RolVendedores.DisplayMember = "nombreRol";
            this.RolVendedores.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RolVendedores.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.RolVendedores.FormattingEnabled = true;
            this.RolVendedores.Location = new System.Drawing.Point(112, 251);
            this.RolVendedores.Name = "RolVendedores";
            this.RolVendedores.Size = new System.Drawing.Size(206, 26);
            this.RolVendedores.TabIndex = 17;
            this.RolVendedores.ValueMember = "idRol";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Menu;
            this.label6.Location = new System.Drawing.Point(225, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Gestión de empleados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.rolDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.salarioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.empleadosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(337, 124);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(457, 292);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.fARMACIABUENASALUDDataSetBindingSource;
            // 
            // fARMACIABUENASALUDDataSetBindingSource
            // 
            this.fARMACIABUENASALUDDataSetBindingSource.DataSource = this.fARMACIA_BUENA__SALUDDataSet;
            this.fARMACIABUENASALUDDataSetBindingSource.Position = 0;
            // 
            // fARMACIA_BUENA__SALUDDataSet
            // 
            this.fARMACIA_BUENA__SALUDDataSet.DataSetName = "FARMACIA_BUENA__SALUDDataSet";
            this.fARMACIA_BUENA__SALUDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Menu;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.button6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button6.Location = new System.Drawing.Point(229, 381);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 28);
            this.button6.TabIndex = 12;
            this.button6.Text = "Eliminar";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Menu;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.button5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button5.Location = new System.Drawing.Point(126, 381);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 28);
            this.button5.TabIndex = 11;
            this.button5.Text = "Editar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Menu;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.button4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button4.Location = new System.Drawing.Point(17, 381);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 28);
            this.button4.TabIndex = 10;
            this.button4.Text = "Añadir";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // EstadoVendedores
            // 
            this.EstadoVendedores.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadoVendedores.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.EstadoVendedores.Location = new System.Drawing.Point(113, 292);
            this.EstadoVendedores.Name = "EstadoVendedores";
            this.EstadoVendedores.Size = new System.Drawing.Size(207, 26);
            this.EstadoVendedores.TabIndex = 8;
            // 
            // NombreVendedores
            // 
            this.NombreVendedores.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreVendedores.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NombreVendedores.Location = new System.Drawing.Point(112, 169);
            this.NombreVendedores.Name = "NombreVendedores";
            this.NombreVendedores.Size = new System.Drawing.Size(208, 26);
            this.NombreVendedores.TabIndex = 6;
            // 
            // IDVendedores
            // 
            this.IDVendedores.Enabled = false;
            this.IDVendedores.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDVendedores.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.IDVendedores.Location = new System.Drawing.Point(112, 124);
            this.IDVendedores.Name = "IDVendedores";
            this.IDVendedores.ReadOnly = true;
            this.IDVendedores.Size = new System.Drawing.Size(208, 26);
            this.IDVendedores.TabIndex = 5;
            this.IDVendedores.TextChanged += new System.EventHandler(this.IDVendedores_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Menu;
            this.label5.Location = new System.Drawing.Point(14, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Salario:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Menu;
            this.label4.Location = new System.Drawing.Point(14, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(14, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rol:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(14, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(14, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // rolBindingSource
            // 
            this.rolBindingSource.DataMember = "Rol";
            this.rolBindingSource.DataSource = this.fARMACIABUENASALUDDataSetBindingSource;
            // 
            // rolTableAdapter
            // 
            this.rolTableAdapter.ClearBeforeFill = true;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.fARMACIA_BUENA__SALUDDataSet;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // rolDataGridViewTextBoxColumn
            // 
            this.rolDataGridViewTextBoxColumn.DataPropertyName = "Rol";
            this.rolDataGridViewTextBoxColumn.HeaderText = "Rol";
            this.rolDataGridViewTextBoxColumn.Name = "rolDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // salarioDataGridViewTextBoxColumn
            // 
            this.salarioDataGridViewTextBoxColumn.DataPropertyName = "Salario";
            this.salarioDataGridViewTextBoxColumn.HeaderText = "Salario";
            this.salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
            // 
            // rolBindingSource1
            // 
            this.rolBindingSource1.DataMember = "Rol";
            this.rolBindingSource1.DataSource = this.fARMACIA_BUENA__SALUDDataSet;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(17, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 28);
            this.button1.TabIndex = 26;
            this.button1.Text = "Home";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Vendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Vendedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendedores";
            this.Load += new System.EventHandler(this.Vendedores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIABUENASALUDDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA_BUENA__SALUDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox EstadoVendedores;
        private System.Windows.Forms.TextBox NombreVendedores;
        private System.Windows.Forms.TextBox IDVendedores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RolVendedores;
        private System.Windows.Forms.TextBox PasswordVendedores;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SalarioVendedores;
        private FARMACIA_BUENA__SALUDDataSet fARMACIA_BUENA__SALUDDataSet;
        private System.Windows.Forms.BindingSource fARMACIABUENASALUDDataSetBindingSource;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private FARMACIA_BUENA__SALUDDataSetTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private Button button10;
        private BindingSource rolBindingSource;
        private FARMACIA_BUENA__SALUDDataSetTableAdapters.RolTableAdapter rolTableAdapter;
        private BindingSource empleadosBindingSource;
        private FARMACIA_BUENA__SALUDDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rolDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private BindingSource rolBindingSource1;
        private Button button1;
    }
}