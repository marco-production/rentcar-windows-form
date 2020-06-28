namespace Rentcar.Views.Renta
{
    partial class FrmInspeccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInspeccion));
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_empleado = new System.Windows.Forms.ComboBox();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentcarDataSetEmpleadoInspeccionSelect = new Rentcar.RentcarDataSetEmpleadoInspeccionSelect();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radio_ralladura_si = new System.Windows.Forms.RadioButton();
            this.radio_ralladura_no = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radio_goma_repuesta_no = new System.Windows.Forms.RadioButton();
            this.radio_goma_repuesta_si = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.radio_gato_no = new System.Windows.Forms.RadioButton();
            this.radio_gato_si = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.radio_cristal_no = new System.Windows.Forms.RadioButton();
            this.radio_cristal_si = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.check_i_izquierda = new System.Windows.Forms.CheckBox();
            this.check_i_derecha = new System.Windows.Forms.CheckBox();
            this.check_s_derecha = new System.Windows.Forms.CheckBox();
            this.check_s_izquierda = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.radio_inactivo = new System.Windows.Forms.RadioButton();
            this.radio_activo = new System.Windows.Forms.RadioButton();
            this.label_estado = new System.Windows.Forms.Label();
            this.cmb_combustible = new System.Windows.Forms.ComboBox();
            this.dtp_fecha_inspeccion = new System.Windows.Forms.DateTimePicker();
            this.empleadosTableAdapter = new Rentcar.RentcarDataSetEmpleadoInspeccionSelectTableAdapters.empleadosTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSetEmpleadoInspeccionSelect)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(339, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "*";
            // 
            // cmb_empleado
            // 
            this.cmb_empleado.DataSource = this.empleadosBindingSource;
            this.cmb_empleado.DisplayMember = "full_name";
            this.cmb_empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_empleado.FormattingEnabled = true;
            this.cmb_empleado.Location = new System.Drawing.Point(293, 52);
            this.cmb_empleado.Name = "cmb_empleado";
            this.cmb_empleado.Size = new System.Drawing.Size(250, 21);
            this.cmb_empleado.TabIndex = 61;
            this.cmb_empleado.ValueMember = "id";
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "empleados";
            this.empleadosBindingSource.DataSource = this.rentcarDataSetEmpleadoInspeccionSelect;
            // 
            // rentcarDataSetEmpleadoInspeccionSelect
            // 
            this.rentcarDataSetEmpleadoInspeccionSelect.DataSetName = "RentcarDataSetEmpleadoInspeccionSelect";
            this.rentcarDataSetEmpleadoInspeccionSelect.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(290, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 60;
            this.label1.Text = "Empleado";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(23, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 15);
            this.label4.TabIndex = 64;
            this.label4.Text = "Fecha de inspección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(124, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "*";
            // 
            // radio_ralladura_si
            // 
            this.radio_ralladura_si.AutoSize = true;
            this.radio_ralladura_si.Location = new System.Drawing.Point(20, 25);
            this.radio_ralladura_si.Name = "radio_ralladura_si";
            this.radio_ralladura_si.Size = new System.Drawing.Size(34, 17);
            this.radio_ralladura_si.TabIndex = 67;
            this.radio_ralladura_si.TabStop = true;
            this.radio_ralladura_si.Text = "Si";
            this.radio_ralladura_si.UseVisualStyleBackColor = true;
            // 
            // radio_ralladura_no
            // 
            this.radio_ralladura_no.AutoSize = true;
            this.radio_ralladura_no.Location = new System.Drawing.Point(20, 48);
            this.radio_ralladura_no.Name = "radio_ralladura_no";
            this.radio_ralladura_no.Size = new System.Drawing.Size(39, 17);
            this.radio_ralladura_no.TabIndex = 68;
            this.radio_ralladura_no.TabStop = true;
            this.radio_ralladura_no.Text = "No";
            this.radio_ralladura_no.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(84, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(113, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 73;
            this.label6.Text = "*";
            // 
            // radio_goma_repuesta_no
            // 
            this.radio_goma_repuesta_no.AutoSize = true;
            this.radio_goma_repuesta_no.Location = new System.Drawing.Point(6, 42);
            this.radio_goma_repuesta_no.Name = "radio_goma_repuesta_no";
            this.radio_goma_repuesta_no.Size = new System.Drawing.Size(39, 17);
            this.radio_goma_repuesta_no.TabIndex = 72;
            this.radio_goma_repuesta_no.TabStop = true;
            this.radio_goma_repuesta_no.Text = "No";
            this.radio_goma_repuesta_no.UseVisualStyleBackColor = true;
            // 
            // radio_goma_repuesta_si
            // 
            this.radio_goma_repuesta_si.AutoSize = true;
            this.radio_goma_repuesta_si.Location = new System.Drawing.Point(6, 19);
            this.radio_goma_repuesta_si.Name = "radio_goma_repuesta_si";
            this.radio_goma_repuesta_si.Size = new System.Drawing.Size(34, 17);
            this.radio_goma_repuesta_si.TabIndex = 71;
            this.radio_goma_repuesta_si.TabStop = true;
            this.radio_goma_repuesta_si.Text = "Si";
            this.radio_goma_repuesta_si.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(59, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 13);
            this.label9.TabIndex = 77;
            this.label9.Text = "*";
            // 
            // radio_gato_no
            // 
            this.radio_gato_no.AutoSize = true;
            this.radio_gato_no.Location = new System.Drawing.Point(12, 41);
            this.radio_gato_no.Name = "radio_gato_no";
            this.radio_gato_no.Size = new System.Drawing.Size(39, 17);
            this.radio_gato_no.TabIndex = 76;
            this.radio_gato_no.TabStop = true;
            this.radio_gato_no.Text = "No";
            this.radio_gato_no.UseVisualStyleBackColor = true;
            // 
            // radio_gato_si
            // 
            this.radio_gato_si.AutoSize = true;
            this.radio_gato_si.Location = new System.Drawing.Point(12, 18);
            this.radio_gato_si.Name = "radio_gato_si";
            this.radio_gato_si.Size = new System.Drawing.Size(34, 17);
            this.radio_gato_si.TabIndex = 75;
            this.radio_gato_si.TabStop = true;
            this.radio_gato_si.Text = "Si";
            this.radio_gato_si.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(100, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 13);
            this.label11.TabIndex = 81;
            this.label11.Text = "*";
            // 
            // radio_cristal_no
            // 
            this.radio_cristal_no.AutoSize = true;
            this.radio_cristal_no.Location = new System.Drawing.Point(8, 43);
            this.radio_cristal_no.Name = "radio_cristal_no";
            this.radio_cristal_no.Size = new System.Drawing.Size(39, 17);
            this.radio_cristal_no.TabIndex = 80;
            this.radio_cristal_no.TabStop = true;
            this.radio_cristal_no.Text = "No";
            this.radio_cristal_no.UseVisualStyleBackColor = true;
            // 
            // radio_cristal_si
            // 
            this.radio_cristal_si.AutoSize = true;
            this.radio_cristal_si.Location = new System.Drawing.Point(8, 20);
            this.radio_cristal_si.Name = "radio_cristal_si";
            this.radio_cristal_si.Size = new System.Drawing.Size(34, 17);
            this.radio_cristal_si.TabIndex = 79;
            this.radio_cristal_si.TabStop = true;
            this.radio_cristal_si.Text = "Si";
            this.radio_cristal_si.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.check_i_izquierda);
            this.groupBox1.Controls.Add(this.check_i_derecha);
            this.groupBox1.Controls.Add(this.check_s_derecha);
            this.groupBox1.Controls.Add(this.check_s_izquierda);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(26, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 85);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado de gomas";
            // 
            // check_i_izquierda
            // 
            this.check_i_izquierda.AutoSize = true;
            this.check_i_izquierda.Location = new System.Drawing.Point(6, 50);
            this.check_i_izquierda.Name = "check_i_izquierda";
            this.check_i_izquierda.Size = new System.Drawing.Size(133, 17);
            this.check_i_izquierda.TabIndex = 85;
            this.check_i_izquierda.Text = "Goma inferior izquierda";
            this.check_i_izquierda.UseVisualStyleBackColor = true;
            // 
            // check_i_derecha
            // 
            this.check_i_derecha.AutoSize = true;
            this.check_i_derecha.Location = new System.Drawing.Point(151, 50);
            this.check_i_derecha.Name = "check_i_derecha";
            this.check_i_derecha.Size = new System.Drawing.Size(130, 17);
            this.check_i_derecha.TabIndex = 86;
            this.check_i_derecha.Text = "Goma inferior derecha";
            this.check_i_derecha.UseVisualStyleBackColor = true;
            // 
            // check_s_derecha
            // 
            this.check_s_derecha.AutoSize = true;
            this.check_s_derecha.Location = new System.Drawing.Point(151, 27);
            this.check_s_derecha.Name = "check_s_derecha";
            this.check_s_derecha.Size = new System.Drawing.Size(136, 17);
            this.check_s_derecha.TabIndex = 85;
            this.check_s_derecha.Text = "Goma superior derecha";
            this.check_s_derecha.UseVisualStyleBackColor = true;
            // 
            // check_s_izquierda
            // 
            this.check_s_izquierda.AutoSize = true;
            this.check_s_izquierda.Location = new System.Drawing.Point(6, 27);
            this.check_s_izquierda.Name = "check_s_izquierda";
            this.check_s_izquierda.Size = new System.Drawing.Size(139, 17);
            this.check_s_izquierda.TabIndex = 84;
            this.check_s_izquierda.Text = "Goma superior izquierda";
            this.check_s_izquierda.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(91, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(373, 13);
            this.label13.TabIndex = 83;
            this.label13.Text = " (Marca las gomas que tienen algun problema o se encuentran en mal estado)";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(23, 294);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(253, 16);
            this.label14.TabIndex = 83;
            this.label14.Text = "Cantidad de combustible";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(141, 294);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 13);
            this.label15.TabIndex = 85;
            this.label15.Text = "*";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 46);
            this.button2.TabIndex = 87;
            this.button2.Text = "❌ Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 46);
            this.button1.TabIndex = 86;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radio_inactivo
            // 
            this.radio_inactivo.AutoSize = true;
            this.radio_inactivo.Location = new System.Drawing.Point(439, 317);
            this.radio_inactivo.Name = "radio_inactivo";
            this.radio_inactivo.Size = new System.Drawing.Size(63, 17);
            this.radio_inactivo.TabIndex = 90;
            this.radio_inactivo.TabStop = true;
            this.radio_inactivo.Text = "Inactivo";
            this.radio_inactivo.UseVisualStyleBackColor = true;
            // 
            // radio_activo
            // 
            this.radio_activo.AutoSize = true;
            this.radio_activo.Location = new System.Drawing.Point(321, 317);
            this.radio_activo.Name = "radio_activo";
            this.radio_activo.Size = new System.Drawing.Size(55, 17);
            this.radio_activo.TabIndex = 89;
            this.radio_activo.Text = "Activo";
            this.radio_activo.UseVisualStyleBackColor = true;
            // 
            // label_estado
            // 
            this.label_estado.AutoSize = true;
            this.label_estado.Location = new System.Drawing.Point(318, 297);
            this.label_estado.Name = "label_estado";
            this.label_estado.Size = new System.Drawing.Size(40, 13);
            this.label_estado.TabIndex = 88;
            this.label_estado.Text = "Estado";
            // 
            // cmb_combustible
            // 
            this.cmb_combustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_combustible.FormattingEnabled = true;
            this.cmb_combustible.Items.AddRange(new object[] {
            "1/4",
            "½",
            "¾",
            "Tanque lleno"});
            this.cmb_combustible.Location = new System.Drawing.Point(26, 316);
            this.cmb_combustible.Name = "cmb_combustible";
            this.cmb_combustible.Size = new System.Drawing.Size(250, 21);
            this.cmb_combustible.TabIndex = 91;
            // 
            // dtp_fecha_inspeccion
            // 
            this.dtp_fecha_inspeccion.Location = new System.Drawing.Point(26, 51);
            this.dtp_fecha_inspeccion.Name = "dtp_fecha_inspeccion";
            this.dtp_fecha_inspeccion.Size = new System.Drawing.Size(250, 20);
            this.dtp_fecha_inspeccion.TabIndex = 92;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_ralladura_si);
            this.groupBox2.Controls.Add(this.radio_ralladura_no);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(26, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(109, 78);
            this.groupBox2.TabIndex = 93;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiene ralladuras";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radio_goma_repuesta_si);
            this.groupBox3.Controls.Add(this.radio_goma_repuesta_no);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(144, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(132, 78);
            this.groupBox3.TabIndex = 94;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tiene goma respuesta";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radio_gato_no);
            this.groupBox4.Controls.Add(this.radio_gato_si);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(293, 95);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(109, 78);
            this.groupBox4.TabIndex = 95;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tiene gato";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radio_cristal_si);
            this.groupBox5.Controls.Add(this.radio_cristal_no);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(408, 95);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(135, 78);
            this.groupBox5.TabIndex = 96;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tiene roturas cristal";
            // 
            // FrmInspeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 465);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtp_fecha_inspeccion);
            this.Controls.Add(this.cmb_combustible);
            this.Controls.Add(this.radio_inactivo);
            this.Controls.Add(this.radio_activo);
            this.Controls.Add(this.label_estado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_empleado);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmInspeccion";
            this.Text = "Focus RentCar";
            this.Load += new System.EventHandler(this.FrmInspeccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSetEmpleadoInspeccionSelect)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_empleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radio_ralladura_si;
        private System.Windows.Forms.RadioButton radio_ralladura_no;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radio_goma_repuesta_no;
        private System.Windows.Forms.RadioButton radio_goma_repuesta_si;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radio_gato_no;
        private System.Windows.Forms.RadioButton radio_gato_si;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radio_cristal_no;
        private System.Windows.Forms.RadioButton radio_cristal_si;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox check_i_izquierda;
        private System.Windows.Forms.CheckBox check_i_derecha;
        private System.Windows.Forms.CheckBox check_s_derecha;
        private System.Windows.Forms.CheckBox check_s_izquierda;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radio_inactivo;
        private System.Windows.Forms.RadioButton radio_activo;
        private System.Windows.Forms.Label label_estado;
        private System.Windows.Forms.ComboBox cmb_combustible;
        private System.Windows.Forms.DateTimePicker dtp_fecha_inspeccion;
        private RentcarDataSetEmpleadoInspeccionSelect rentcarDataSetEmpleadoInspeccionSelect;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private RentcarDataSetEmpleadoInspeccionSelectTableAdapters.empleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}