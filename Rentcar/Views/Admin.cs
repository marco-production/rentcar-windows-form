using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rentcar.Models;
using Rentcar.Data;

namespace Rentcar.Views
{
    public partial class Home_admin : Form
    {
        public Home_admin()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Views.Empleado.IndexEmpleado c = new Views.Empleado.IndexEmpleado();
            c.ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Home_admin_Load(object sender, EventArgs e)
        {
            label1.Text = Data.LoginInfo.user.full_name.ToString();
            label3.Text = Data.LoginInfo.user.email.ToString();
            this.button9.Image = (Image)(new Bitmap(Rentcar.Properties.Resources.Logo2, new Size(50, 50)));
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("¿Deseas abandonar la sesión?",
            "Administrador", MessageBoxButtons.YesNo);

            if (msg == DialogResult.Yes)
            {
                Data.LoginInfo.user = null;
                this.Hide();
                Login c = new Login();
                c.ShowDialog();
                this.Close();
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Views.Empleado.IndexEmpleado c = new Views.Empleado.IndexEmpleado();
            c.ShowDialog();
            this.Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
