namespace Rentcar.Views.Empleado
{
    partial class FrmEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleado));
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_confirm_pass = new System.Windows.Forms.Label();
            this.txt_confirm_password = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.cmb_tanda = new System.Windows.Forms.ComboBox();
            this.dtp_fecha_ingreso = new System.Windows.Forms.DateTimePicker();
            this.cmb_role = new System.Windows.Forms.ComboBox();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentcarDataSetRoles = new Rentcar.RentcarDataSetRoles();
            this.rolesTableAdapter = new Rentcar.RentcarDataSetRolesTableAdapters.rolesTableAdapter();
            this.cmb_comision = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_cedula = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSetRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(415, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Cédula";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(218, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre completo";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 46);
            this.button2.TabIndex = 39;
            this.button2.Text = "❌ Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 46);
            this.button1.TabIndex = 38;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(23, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "Fecha Ingreso ";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(218, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Porciento comisión ";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(23, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 40;
            this.label5.Text = "Tanda laboral";
            // 
            // txt_confirm_pass
            // 
            this.txt_confirm_pass.Location = new System.Drawing.Point(220, 253);
            this.txt_confirm_pass.Name = "txt_confirm_pass";
            this.txt_confirm_pass.Size = new System.Drawing.Size(167, 17);
            this.txt_confirm_pass.TabIndex = 51;
            this.txt_confirm_pass.Text = "Confirmar contraseña";
            // 
            // txt_confirm_password
            // 
            this.txt_confirm_password.Location = new System.Drawing.Point(223, 273);
            this.txt_confirm_password.Name = "txt_confirm_password";
            this.txt_confirm_password.Size = new System.Drawing.Size(164, 20);
            this.txt_confirm_password.TabIndex = 50;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(23, 253);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(90, 15);
            this.txt_pass.TabIndex = 48;
            this.txt_pass.Text = "Contraseña";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(415, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 15);
            this.label9.TabIndex = 46;
            this.label9.Text = "Tipo de usuario";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(418, 206);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 53;
            this.radioButton1.Text = "Activo";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(415, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Estado";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(519, 206);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 17);
            this.radioButton2.TabIndex = 54;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Inactivo";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(26, 273);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(164, 20);
            this.txt_password.TabIndex = 55;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(221, 68);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(164, 20);
            this.txt_email.TabIndex = 56;
            // 
            // txt_fullname
            // 
            this.txt_fullname.Location = new System.Drawing.Point(26, 68);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(164, 20);
            this.txt_fullname.TabIndex = 58;
            // 
            // cmb_tanda
            // 
            this.cmb_tanda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tanda.FormattingEnabled = true;
            this.cmb_tanda.Items.AddRange(new object[] {
            "Matutina",
            "Vespertina",
            "Nocturna"});
            this.cmb_tanda.Location = new System.Drawing.Point(26, 135);
            this.cmb_tanda.Name = "cmb_tanda";
            this.cmb_tanda.Size = new System.Drawing.Size(164, 21);
            this.cmb_tanda.TabIndex = 61;
            // 
            // dtp_fecha_ingreso
            // 
            this.dtp_fecha_ingreso.Location = new System.Drawing.Point(26, 202);
            this.dtp_fecha_ingreso.Name = "dtp_fecha_ingreso";
            this.dtp_fecha_ingreso.Size = new System.Drawing.Size(359, 20);
            this.dtp_fecha_ingreso.TabIndex = 0;
            // 
            // cmb_role
            // 
            this.cmb_role.DataSource = this.rolesBindingSource;
            this.cmb_role.DisplayMember = "nombre";
            this.cmb_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_role.FormattingEnabled = true;
            this.cmb_role.Location = new System.Drawing.Point(418, 138);
            this.cmb_role.Name = "cmb_role";
            this.cmb_role.Size = new System.Drawing.Size(164, 21);
            this.cmb_role.TabIndex = 62;
            this.cmb_role.ValueMember = "id";
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "roles";
            this.rolesBindingSource.DataSource = this.rentcarDataSetRoles;
            // 
            // rentcarDataSetRoles
            // 
            this.rentcarDataSetRoles.DataSetName = "RentcarDataSetRoles";
            this.rentcarDataSetRoles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // cmb_comision
            // 
            this.cmb_comision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_comision.FormattingEnabled = true;
            this.cmb_comision.Items.AddRange(new object[] {
            "10%",
            "20%",
            "30%",
            "40%",
            "50%",
            "60%",
            "70%",
            "80%",
            "90%",
            "100%"});
            this.cmb_comision.Location = new System.Drawing.Point(221, 138);
            this.cmb_comision.Name = "cmb_comision";
            this.cmb_comision.Size = new System.Drawing.Size(164, 21);
            this.cmb_comision.TabIndex = 63;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.SteelBlue;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(608, 34);
            this.splitter1.TabIndex = 64;
            this.splitter1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SteelBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(117, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 29);
            this.label7.TabIndex = 67;
            this.label7.Text = "RentCar -";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.SteelBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(41, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 29);
            this.label8.TabIndex = 66;
            this.label8.Text = "Focus";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.SteelBlue;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(227, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 29);
            this.label11.TabIndex = 68;
            this.label11.Text = "Nuevo Usuario";
            // 
            // txt_cedula
            // 
            this.txt_cedula.Location = new System.Drawing.Point(418, 68);
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(164, 20);
            this.txt_cedula.TabIndex = 70;
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 399);
            this.Controls.Add(this.txt_cedula);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.cmb_comision);
            this.Controls.Add(this.cmb_role);
            this.Controls.Add(this.dtp_fecha_ingreso);
            this.Controls.Add(this.cmb_tanda);
            this.Controls.Add(this.txt_fullname);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_confirm_pass);
            this.Controls.Add(this.txt_confirm_password);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmEmpleado";
            this.Text = "Focus RentCar";
            this.Load += new System.EventHandler(this.FrmEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSetRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txt_confirm_pass;
        private System.Windows.Forms.TextBox txt_confirm_password;
        private System.Windows.Forms.Label txt_pass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.ComboBox cmb_tanda;
        private System.Windows.Forms.DateTimePicker dtp_fecha_ingreso;
        private System.Windows.Forms.ComboBox cmb_role;
        private RentcarDataSetRoles rentcarDataSetRoles;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private RentcarDataSetRolesTableAdapters.rolesTableAdapter rolesTableAdapter;
        private System.Windows.Forms.ComboBox cmb_comision;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_cedula;
    }
}