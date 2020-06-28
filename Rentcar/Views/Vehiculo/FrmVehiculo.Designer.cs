namespace Rentcar.Views.Vehiculo
{
    partial class FrmVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVehiculo));
            this.label10 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_combustible = new System.Windows.Forms.ComboBox();
            this.combustiblesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentcarDataSetCombustiblesSelect = new Rentcar.RentcarDataSetCombustiblesSelect();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_motor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_chasis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_anio = new System.Windows.Forms.NumericUpDown();
            this.cmb_modelo = new System.Windows.Forms.ComboBox();
            this.modelosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentcarDataSetModelosSelect = new Rentcar.RentcarDataSetModelosSelect();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_marca = new System.Windows.Forms.ComboBox();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentcarDataSetMarcaRealSelect = new Rentcar.RentcarDataSetMarcaRealSelect();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_tipo_vehiculo = new System.Windows.Forms.ComboBox();
            this.tipovehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentcarDataSetTipoSelect = new Rentcar.RentcarDataSetTipoSelect();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tipovehiculosTableAdapter = new Rentcar.RentcarDataSetTipoSelectTableAdapters.tipovehiculosTableAdapter();
            this.marcasTableAdapter = new Rentcar.RentcarDataSetMarcaRealSelectTableAdapters.marcasTableAdapter();
            this.modelosTableAdapter = new Rentcar.RentcarDataSetModelosSelectTableAdapters.modelosTableAdapter();
            this.combustiblesTableAdapter = new Rentcar.RentcarDataSetCombustiblesSelectTableAdapters.combustiblesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.combustiblesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSetCombustiblesSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_anio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSetModelosSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSetMarcaRealSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipovehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSetTipoSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(218, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 15);
            this.label10.TabIndex = 49;
            this.label10.Text = "Descripcion";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(221, 193);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(364, 20);
            this.txt_descripcion.TabIndex = 48;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(677, 194);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 17);
            this.radioButton2.TabIndex = 47;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Inactivo";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(616, 194);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 46;
            this.radioButton1.Text = "Activo";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(613, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Estado";
            // 
            // cmb_combustible
            // 
            this.cmb_combustible.DataSource = this.combustiblesBindingSource;
            this.cmb_combustible.DisplayMember = "nombre";
            this.cmb_combustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_combustible.FormattingEnabled = true;
            this.cmb_combustible.Location = new System.Drawing.Point(26, 193);
            this.cmb_combustible.Name = "cmb_combustible";
            this.cmb_combustible.Size = new System.Drawing.Size(164, 21);
            this.cmb_combustible.TabIndex = 44;
            this.cmb_combustible.ValueMember = "id";
            // 
            // combustiblesBindingSource
            // 
            this.combustiblesBindingSource.DataMember = "combustibles";
            this.combustiblesBindingSource.DataSource = this.rentcarDataSetCombustiblesSelect;
            // 
            // rentcarDataSetCombustiblesSelect
            // 
            this.rentcarDataSetCombustiblesSelect.DataSetName = "RentcarDataSetCombustiblesSelect";
            this.rentcarDataSetCombustiblesSelect.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(23, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 43;
            this.label8.Text = "Combustible";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(418, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 15);
            this.label7.TabIndex = 42;
            this.label7.Text = "No. Placa";
            // 
            // txt_placa
            // 
            this.txt_placa.Location = new System.Drawing.Point(421, 130);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(164, 20);
            this.txt_placa.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(218, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "No. Motor";
            // 
            // txt_motor
            // 
            this.txt_motor.Location = new System.Drawing.Point(221, 130);
            this.txt_motor.Name = "txt_motor";
            this.txt_motor.Size = new System.Drawing.Size(164, 20);
            this.txt_motor.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(23, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "No. Chasis";
            // 
            // txt_chasis
            // 
            this.txt_chasis.Location = new System.Drawing.Point(26, 130);
            this.txt_chasis.Name = "txt_chasis";
            this.txt_chasis.Size = new System.Drawing.Size(164, 20);
            this.txt_chasis.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(613, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "Año";
            // 
            // txt_anio
            // 
            this.txt_anio.Location = new System.Drawing.Point(616, 56);
            this.txt_anio.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.txt_anio.Name = "txt_anio";
            this.txt_anio.Size = new System.Drawing.Size(97, 20);
            this.txt_anio.TabIndex = 35;
            this.txt_anio.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // cmb_modelo
            // 
            this.cmb_modelo.DataSource = this.modelosBindingSource;
            this.cmb_modelo.DisplayMember = "nombre";
            this.cmb_modelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_modelo.FormattingEnabled = true;
            this.cmb_modelo.Location = new System.Drawing.Point(421, 55);
            this.cmb_modelo.Name = "cmb_modelo";
            this.cmb_modelo.Size = new System.Drawing.Size(164, 21);
            this.cmb_modelo.TabIndex = 34;
            this.cmb_modelo.ValueMember = "id";
            // 
            // modelosBindingSource
            // 
            this.modelosBindingSource.DataMember = "modelos";
            this.modelosBindingSource.DataSource = this.rentcarDataSetModelosSelect;
            // 
            // rentcarDataSetModelosSelect
            // 
            this.rentcarDataSetModelosSelect.DataSetName = "RentcarDataSetModelosSelect";
            this.rentcarDataSetModelosSelect.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(418, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Modelo";
            // 
            // cmb_marca
            // 
            this.cmb_marca.DataSource = this.marcasBindingSource;
            this.cmb_marca.DisplayMember = "nombre";
            this.cmb_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_marca.FormattingEnabled = true;
            this.cmb_marca.Location = new System.Drawing.Point(221, 55);
            this.cmb_marca.Name = "cmb_marca";
            this.cmb_marca.Size = new System.Drawing.Size(164, 21);
            this.cmb_marca.TabIndex = 32;
            this.cmb_marca.ValueMember = "id";
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "marcas";
            this.marcasBindingSource.DataSource = this.rentcarDataSetMarcaRealSelect;
            // 
            // rentcarDataSetMarcaRealSelect
            // 
            this.rentcarDataSetMarcaRealSelect.DataSetName = "RentcarDataSetMarcaRealSelect";
            this.rentcarDataSetMarcaRealSelect.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(218, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Marca";
            // 
            // cmb_tipo_vehiculo
            // 
            this.cmb_tipo_vehiculo.DataSource = this.tipovehiculosBindingSource;
            this.cmb_tipo_vehiculo.DisplayMember = "nombre";
            this.cmb_tipo_vehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_vehiculo.FormattingEnabled = true;
            this.cmb_tipo_vehiculo.Location = new System.Drawing.Point(26, 55);
            this.cmb_tipo_vehiculo.Name = "cmb_tipo_vehiculo";
            this.cmb_tipo_vehiculo.Size = new System.Drawing.Size(164, 21);
            this.cmb_tipo_vehiculo.TabIndex = 30;
            this.cmb_tipo_vehiculo.ValueMember = "id";
            // 
            // tipovehiculosBindingSource
            // 
            this.tipovehiculosBindingSource.DataMember = "tipovehiculos";
            this.tipovehiculosBindingSource.DataSource = this.rentcarDataSetTipoSelect;
            // 
            // rentcarDataSetTipoSelect
            // 
            this.rentcarDataSetTipoSelect.DataSetName = "RentcarDataSetTipoSelect";
            this.rentcarDataSetTipoSelect.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tipo de vehiculo";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 46);
            this.button2.TabIndex = 29;
            this.button2.Text = "❌ Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(639, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 46);
            this.button1.TabIndex = 28;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tipovehiculosTableAdapter
            // 
            this.tipovehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // modelosTableAdapter
            // 
            this.modelosTableAdapter.ClearBeforeFill = true;
            // 
            // combustiblesTableAdapter
            // 
            this.combustiblesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 350);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmb_combustible);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_placa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_motor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_chasis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_anio);
            this.Controls.Add(this.cmb_modelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_marca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_tipo_vehiculo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmVehiculo";
            this.Text = "Focus RentCar";
            this.Load += new System.EventHandler(this.FrmVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.combustiblesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSetCombustiblesSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_anio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSetModelosSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSetMarcaRealSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipovehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSetTipoSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_combustible;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_placa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_motor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_chasis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txt_anio;
        private System.Windows.Forms.ComboBox cmb_modelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_marca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_tipo_vehiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private RentcarDataSetTipoSelect rentcarDataSetTipoSelect;
        private System.Windows.Forms.BindingSource tipovehiculosBindingSource;
        private RentcarDataSetTipoSelectTableAdapters.tipovehiculosTableAdapter tipovehiculosTableAdapter;
        private RentcarDataSetMarcaRealSelect rentcarDataSetMarcaRealSelect;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private RentcarDataSetMarcaRealSelectTableAdapters.marcasTableAdapter marcasTableAdapter;
        private RentcarDataSetModelosSelect rentcarDataSetModelosSelect;
        private System.Windows.Forms.BindingSource modelosBindingSource;
        private RentcarDataSetModelosSelectTableAdapters.modelosTableAdapter modelosTableAdapter;
        private RentcarDataSetCombustiblesSelect rentcarDataSetCombustiblesSelect;
        private System.Windows.Forms.BindingSource combustiblesBindingSource;
        private RentcarDataSetCombustiblesSelectTableAdapters.combustiblesTableAdapter combustiblesTableAdapter;
    }
}