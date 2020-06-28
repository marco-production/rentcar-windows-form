namespace Rentcar.Views.Renta
{
    partial class FrmRenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRenta));
            this.label10 = new System.Windows.Forms.Label();
            this.txt_comentario = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label_estado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentcarDataSetClientesSelect = new Rentcar.RentcarDataSetClientesSelect();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_empleado = new System.Windows.Forms.ComboBox();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentcarDataSetEmpleadoselect = new Rentcar.RentcarDataSetEmpleadoselect();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtp_fecha_renta = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_fecha_devolucion = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_dias = new System.Windows.Forms.NumericUpDown();
            this.txt_monto = new System.Windows.Forms.NumericUpDown();
            this.empleadosTableAdapter = new Rentcar.RentcarDataSetEmpleadoselectTableAdapters.empleadosTableAdapter();
            this.clientesTableAdapter = new Rentcar.RentcarDataSetClientesSelectTableAdapters.clientesTableAdapter();
            this.rentcarDataSetClientes = new Rentcar.RentcarDataSetClientes();
            this.cmb_cliente = new System.Windows.Forms.ComboBox();
            this.cmb_vehiculo = new System.Windows.Forms.ComboBox();
            this.vehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentcarDataSetVehiculosSelect = new Rentcar.RentcarDataSetVehiculosSelect();
            this.vehiculosTableAdapter = new Rentcar.RentcarDataSetVehiculosSelectTableAdapters.vehiculosTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSetClientesSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSetEmpleadoselect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_monto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSetClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSetVehiculosSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(23, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 15);
            this.label10.TabIndex = 49;
            this.label10.Text = "Comentario";
            // 
            // txt_comentario
            // 
            this.txt_comentario.Location = new System.Drawing.Point(26, 316);
            this.txt_comentario.Name = "txt_comentario";
            this.txt_comentario.Size = new System.Drawing.Size(441, 20);
            this.txt_comentario.TabIndex = 48;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(144, 385);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 17);
            this.radioButton2.TabIndex = 47;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Devuelto";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(26, 385);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 17);
            this.radioButton1.TabIndex = 46;
            this.radioButton1.Text = "En renta";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label_estado
            // 
            this.label_estado.AutoSize = true;
            this.label_estado.Location = new System.Drawing.Point(23, 365);
            this.label_estado.Name = "label_estado";
            this.label_estado.Size = new System.Drawing.Size(40, 13);
            this.label_estado.TabIndex = 45;
            this.label_estado.Text = "Estado";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(261, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "Cantidad de días";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(23, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "Monto x día";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.rentcarDataSetClientesSelect;
            this.clientesBindingSource.CurrentChanged += new System.EventHandler(this.clientesBindingSource_CurrentChanged);
            // 
            // rentcarDataSetClientesSelect
            // 
            this.rentcarDataSetClientesSelect.DataSetName = "RentcarDataSetClientesSelect";
            this.rentcarDataSetClientesSelect.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(261, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(23, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Vehiculo";
            // 
            // cmb_empleado
            // 
            this.cmb_empleado.DataSource = this.empleadosBindingSource;
            this.cmb_empleado.DisplayMember = "full_name";
            this.cmb_empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_empleado.FormattingEnabled = true;
            this.cmb_empleado.Location = new System.Drawing.Point(26, 55);
            this.cmb_empleado.Name = "cmb_empleado";
            this.cmb_empleado.Size = new System.Drawing.Size(441, 21);
            this.cmb_empleado.TabIndex = 30;
            this.cmb_empleado.ValueMember = "id";
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "empleados";
            this.empleadosBindingSource.DataSource = this.rentcarDataSetEmpleadoselect;
            // 
            // rentcarDataSetEmpleadoselect
            // 
            this.rentcarDataSetEmpleadoselect.DataSetName = "RentcarDataSetEmpleadoselect";
            this.rentcarDataSetEmpleadoselect.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Empleado";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 46);
            this.button2.TabIndex = 29;
            this.button2.Text = "❌ Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 46);
            this.button1.TabIndex = 28;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtp_fecha_renta
            // 
            this.dtp_fecha_renta.Location = new System.Drawing.Point(26, 185);
            this.dtp_fecha_renta.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtp_fecha_renta.MinDate = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            this.dtp_fecha_renta.Name = "dtp_fecha_renta";
            this.dtp_fecha_renta.Size = new System.Drawing.Size(203, 20);
            this.dtp_fecha_renta.TabIndex = 50;
            this.dtp_fecha_renta.Value = new System.DateTime(2020, 6, 12, 23, 46, 32, 0);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(23, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 15);
            this.label4.TabIndex = 51;
            this.label4.Text = "Fecha de renta";
            // 
            // dtp_fecha_devolucion
            // 
            this.dtp_fecha_devolucion.Location = new System.Drawing.Point(264, 185);
            this.dtp_fecha_devolucion.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtp_fecha_devolucion.MinDate = new System.DateTime(2019, 12, 25, 23, 59, 0, 0);
            this.dtp_fecha_devolucion.Name = "dtp_fecha_devolucion";
            this.dtp_fecha_devolucion.Size = new System.Drawing.Size(203, 20);
            this.dtp_fecha_devolucion.TabIndex = 52;
            this.dtp_fecha_devolucion.Value = new System.DateTime(2020, 6, 12, 23, 46, 38, 0);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(261, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 15);
            this.label11.TabIndex = 53;
            this.label11.Text = "Fecha de devolución";
            // 
            // txt_dias
            // 
            this.txt_dias.Location = new System.Drawing.Point(264, 254);
            this.txt_dias.Name = "txt_dias";
            this.txt_dias.Size = new System.Drawing.Size(203, 20);
            this.txt_dias.TabIndex = 54;
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(26, 254);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(203, 20);
            this.txt_monto.TabIndex = 55;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // rentcarDataSetClientes
            // 
            this.rentcarDataSetClientes.DataSetName = "RentcarDataSetClientes";
            this.rentcarDataSetClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.DataSource = this.clientesBindingSource;
            this.cmb_cliente.DisplayMember = "full_name";
            this.cmb_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cliente.FormattingEnabled = true;
            this.cmb_cliente.Location = new System.Drawing.Point(254, 119);
            this.cmb_cliente.Name = "cmb_cliente";
            this.cmb_cliente.Size = new System.Drawing.Size(213, 21);
            this.cmb_cliente.TabIndex = 57;
            this.cmb_cliente.ValueMember = "id";
            // 
            // cmb_vehiculo
            // 
            this.cmb_vehiculo.DataSource = this.vehiculosBindingSource;
            this.cmb_vehiculo.DisplayMember = "vehiculo";
            this.cmb_vehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_vehiculo.FormattingEnabled = true;
            this.cmb_vehiculo.Location = new System.Drawing.Point(26, 119);
            this.cmb_vehiculo.Name = "cmb_vehiculo";
            this.cmb_vehiculo.Size = new System.Drawing.Size(203, 21);
            this.cmb_vehiculo.TabIndex = 58;
            this.cmb_vehiculo.ValueMember = "id";
            // 
            // vehiculosBindingSource
            // 
            this.vehiculosBindingSource.DataMember = "vehiculos";
            this.vehiculosBindingSource.DataSource = this.rentcarDataSetVehiculosSelect;
            // 
            // rentcarDataSetVehiculosSelect
            // 
            this.rentcarDataSetVehiculosSelect.DataSetName = "RentcarDataSetVehiculosSelect";
            this.rentcarDataSetVehiculosSelect.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehiculosTableAdapter
            // 
            this.vehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(72, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(66, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(296, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 13);
            this.label9.TabIndex = 61;
            this.label9.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(98, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 13);
            this.label12.TabIndex = 62;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(363, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 13);
            this.label13.TabIndex = 63;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(83, 235);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 13);
            this.label14.TabIndex = 64;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(340, 235);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 13);
            this.label15.TabIndex = 65;
            this.label15.Text = "*";
            // 
            // FrmRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 503);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_vehiculo);
            this.Controls.Add(this.cmb_cliente);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.txt_dias);
            this.Controls.Add(this.dtp_fecha_devolucion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtp_fecha_renta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_comentario);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label_estado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_empleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmRenta";
            this.Text = "Focus RentCar";
            this.Load += new System.EventHandler(this.FrmRenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSetClientesSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSetEmpleadoselect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_monto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSetClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSetVehiculosSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_comentario;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label_estado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_empleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtp_fecha_renta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_fecha_devolucion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown txt_dias;
        private System.Windows.Forms.NumericUpDown txt_monto;
        private RentcarDataSetEmpleadoselect rentcarDataSetEmpleadoselect;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private RentcarDataSetEmpleadoselectTableAdapters.empleadosTableAdapter empleadosTableAdapter;
        private RentcarDataSetClientesSelect rentcarDataSetClientesSelect;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private RentcarDataSetClientesSelectTableAdapters.clientesTableAdapter clientesTableAdapter;
        private RentcarDataSetClientes rentcarDataSetClientes;
        private System.Windows.Forms.ComboBox cmb_cliente;
        private System.Windows.Forms.ComboBox cmb_vehiculo;
        private RentcarDataSetVehiculosSelect rentcarDataSetVehiculosSelect;
        private System.Windows.Forms.BindingSource vehiculosBindingSource;
        private RentcarDataSetVehiculosSelectTableAdapters.vehiculosTableAdapter vehiculosTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}