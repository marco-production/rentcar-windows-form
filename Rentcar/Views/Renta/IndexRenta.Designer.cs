namespace Rentcar.Views.Renta
{
    partial class IndexRenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexRenta));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dtp_fecha_devolucion = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha_renta = new System.Windows.Forms.DateTimePicker();
            this.cmb_empleado = new System.Windows.Forms.ComboBox();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentcarDataSetSelectEmpleadoIndexRenta = new Rentcar.RentcarDataSetSelectEmpleadoIndexRenta();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewRentas = new System.Windows.Forms.DataGridView();
            this.rentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentcarDataSetRentas = new Rentcar.RentcarDataSetRentas();
            this.rentasTableAdapter = new Rentcar.RentcarDataSetRentasTableAdapters.rentasTableAdapter();
            this.empleadosTableAdapter = new Rentcar.RentcarDataSetSelectEmpleadoIndexRentaTableAdapters.empleadosTableAdapter();
            this.button7 = new System.Windows.Forms.Button();
            this.estadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.comentarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiculoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechadevolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecharentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSetSelectEmpleadoIndexRenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSetRentas)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button7);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip2);
            this.splitContainer1.Panel1.Controls.Add(this.button6);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btn_buscar);
            this.splitContainer1.Panel1.Controls.Add(this.dtp_fecha_devolucion);
            this.splitContainer1.Panel1.Controls.Add(this.dtp_fecha_renta);
            this.splitContainer1.Panel1.Controls.Add(this.cmb_empleado);
            this.splitContainer1.Panel1.Controls.Add(this.button5);
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewRentas);
            this.splitContainer1.Size = new System.Drawing.Size(1043, 457);
            this.splitContainer1.SplitterDistance = 157;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem11});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1043, 24);
            this.menuStrip2.TabIndex = 18;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuItem2.Text = "Home";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(120, 20);
            this.toolStripMenuItem3.Text = "Renta y devolución";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem4.Text = "Clientes";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(69, 20);
            this.toolStripMenuItem5.Text = "Vehiculos";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(116, 20);
            this.toolStripMenuItem6.Text = "Tipos de vehiculos";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItem7.Text = "Marcas";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItem8.Text = "Modelos";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(92, 20);
            this.toolStripMenuItem9.Text = "Combustibles";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(87, 20);
            this.toolStripMenuItem11.Text = "Cerrar sesion";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(396, 33);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 50);
            this.button6.TabIndex = 17;
            this.button6.Text = "Exportar a Excel";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1021, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Fehca de devolucion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fecha de renta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Empleado";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(900, 122);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(131, 23);
            this.btn_buscar.TabIndex = 12;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dtp_fecha_devolucion
            // 
            this.dtp_fecha_devolucion.Location = new System.Drawing.Point(562, 125);
            this.dtp_fecha_devolucion.Name = "dtp_fecha_devolucion";
            this.dtp_fecha_devolucion.Size = new System.Drawing.Size(259, 20);
            this.dtp_fecha_devolucion.TabIndex = 11;
            this.dtp_fecha_devolucion.Value = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            // 
            // dtp_fecha_renta
            // 
            this.dtp_fecha_renta.Location = new System.Drawing.Point(288, 125);
            this.dtp_fecha_renta.Name = "dtp_fecha_renta";
            this.dtp_fecha_renta.Size = new System.Drawing.Size(259, 20);
            this.dtp_fecha_renta.TabIndex = 10;
            this.dtp_fecha_renta.Value = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            // 
            // cmb_empleado
            // 
            this.cmb_empleado.DataSource = this.empleadosBindingSource;
            this.cmb_empleado.DisplayMember = "full_name";
            this.cmb_empleado.FormattingEnabled = true;
            this.cmb_empleado.Location = new System.Drawing.Point(12, 124);
            this.cmb_empleado.Name = "cmb_empleado";
            this.cmb_empleado.Size = new System.Drawing.Size(259, 21);
            this.cmb_empleado.TabIndex = 9;
            this.cmb_empleado.ValueMember = "id";
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "empleados";
            this.empleadosBindingSource.DataSource = this.rentcarDataSetSelectEmpleadoIndexRenta;
            // 
            // rentcarDataSetSelectEmpleadoIndexRenta
            // 
            this.rentcarDataSetSelectEmpleadoIndexRenta.DataSetName = "RentcarDataSetSelectEmpleadoIndexRenta";
            this.rentcarDataSetSelectEmpleadoIndexRenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(268, 33);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 50);
            this.button5.TabIndex = 8;
            this.button5.Text = "Inspección";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(956, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 50);
            this.button4.TabIndex = 7;
            this.button4.Text = "← Volver";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(524, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 50);
            this.button3.TabIndex = 6;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewRentas
            // 
            this.dataGridViewRentas.AllowUserToAddRows = false;
            this.dataGridViewRentas.AllowUserToDeleteRows = false;
            this.dataGridViewRentas.AutoGenerateColumns = false;
            this.dataGridViewRentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fecharentaDataGridViewTextBoxColumn,
            this.fechadevolucionDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.vehiculoidDataGridViewTextBoxColumn,
            this.clienteidDataGridViewTextBoxColumn,
            this.empleadoidDataGridViewTextBoxColumn,
            this.comentarioDataGridViewTextBoxColumn,
            this.estadoDataGridViewCheckBoxColumn});
            this.dataGridViewRentas.DataSource = this.rentasBindingSource;
            this.dataGridViewRentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRentas.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRentas.Name = "dataGridViewRentas";
            this.dataGridViewRentas.ReadOnly = true;
            this.dataGridViewRentas.Size = new System.Drawing.Size(1043, 296);
            this.dataGridViewRentas.TabIndex = 0;
            this.dataGridViewRentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRentas_CellContentClick);
            // 
            // rentasBindingSource
            // 
            this.rentasBindingSource.DataMember = "rentas";
            this.rentasBindingSource.DataSource = this.rentcarDataSetRentas;
            // 
            // rentcarDataSetRentas
            // 
            this.rentcarDataSetRentas.DataSetName = "RentcarDataSetRentas";
            this.rentcarDataSetRentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentasTableAdapter
            // 
            this.rentasTableAdapter.ClearBeforeFill = true;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(828, 122);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(64, 23);
            this.button7.TabIndex = 19;
            this.button7.Text = "❌";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // estadoDataGridViewCheckBoxColumn
            // 
            this.estadoDataGridViewCheckBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewCheckBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewCheckBoxColumn.Name = "estadoDataGridViewCheckBoxColumn";
            this.estadoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // comentarioDataGridViewTextBoxColumn
            // 
            this.comentarioDataGridViewTextBoxColumn.DataPropertyName = "comentario";
            this.comentarioDataGridViewTextBoxColumn.HeaderText = "comentario";
            this.comentarioDataGridViewTextBoxColumn.Name = "comentarioDataGridViewTextBoxColumn";
            this.comentarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empleadoidDataGridViewTextBoxColumn
            // 
            this.empleadoidDataGridViewTextBoxColumn.DataPropertyName = "empleado_id";
            this.empleadoidDataGridViewTextBoxColumn.HeaderText = "empleado_id";
            this.empleadoidDataGridViewTextBoxColumn.Name = "empleadoidDataGridViewTextBoxColumn";
            this.empleadoidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteidDataGridViewTextBoxColumn
            // 
            this.clienteidDataGridViewTextBoxColumn.DataPropertyName = "cliente_id";
            this.clienteidDataGridViewTextBoxColumn.HeaderText = "cliente_id";
            this.clienteidDataGridViewTextBoxColumn.Name = "clienteidDataGridViewTextBoxColumn";
            this.clienteidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehiculoidDataGridViewTextBoxColumn
            // 
            this.vehiculoidDataGridViewTextBoxColumn.DataPropertyName = "vehiculo_id";
            this.vehiculoidDataGridViewTextBoxColumn.HeaderText = "vehiculo_id";
            this.vehiculoidDataGridViewTextBoxColumn.Name = "vehiculoidDataGridViewTextBoxColumn";
            this.vehiculoidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechadevolucionDataGridViewTextBoxColumn
            // 
            this.fechadevolucionDataGridViewTextBoxColumn.DataPropertyName = "fecha_devolucion";
            this.fechadevolucionDataGridViewTextBoxColumn.HeaderText = "fecha_devolucion";
            this.fechadevolucionDataGridViewTextBoxColumn.Name = "fechadevolucionDataGridViewTextBoxColumn";
            this.fechadevolucionDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechadevolucionDataGridViewTextBoxColumn.Width = 130;
            // 
            // fecharentaDataGridViewTextBoxColumn
            // 
            this.fecharentaDataGridViewTextBoxColumn.DataPropertyName = "fecha_renta";
            this.fecharentaDataGridViewTextBoxColumn.HeaderText = "fecha_renta";
            this.fecharentaDataGridViewTextBoxColumn.Name = "fecharentaDataGridViewTextBoxColumn";
            this.fecharentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IndexRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 457);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IndexRenta";
            this.Text = "Focus RentCar";
            this.Load += new System.EventHandler(this.IndexRenta_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSetSelectEmpleadoIndexRenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSetRentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewRentas;
        private RentcarDataSetRentas rentcarDataSetRentas;
        private System.Windows.Forms.BindingSource rentasBindingSource;
        private RentcarDataSetRentasTableAdapters.rentasTableAdapter rentasTableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DateTimePicker dtp_fecha_devolucion;
        private System.Windows.Forms.DateTimePicker dtp_fecha_renta;
        private System.Windows.Forms.ComboBox cmb_empleado;
        private System.Windows.Forms.Label label4;
        private RentcarDataSetSelectEmpleadoIndexRenta rentcarDataSetSelectEmpleadoIndexRenta;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private RentcarDataSetSelectEmpleadoIndexRentaTableAdapters.empleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecharentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechadevolucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehiculoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
    }
}