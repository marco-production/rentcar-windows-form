using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rentcar.Data;

namespace Rentcar
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Views.TipoVehiculo.IndexTipoVehiculo c = new Views.TipoVehiculo.IndexTipoVehiculo();
            c.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Views.Marca.IndexMarca c = new Views.Marca.IndexMarca();
            c.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Views.Combustible.IndexCombustible c = new Views.Combustible.IndexCombustible();
            c.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Views.Modelo.IndexModelo c = new Views.Modelo.IndexModelo();
            c.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Views.Cliente.IndexCliente c = new Views.Cliente.IndexCliente();
            c.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Views.Vehiculo.IndexVehiculo c = new Views.Vehiculo.IndexVehiculo();
            c.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Views.Empleado.IndexEmpleado c = new Views.Empleado.IndexEmpleado();
            c.ShowDialog();
        }

        private void rentasYDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("¿Deseas abandonar la sesión?",
            "Empleado", MessageBoxButtons.YesNo);

            if (msg == DialogResult.Yes)
            {
                Data.LoginInfo.user = null;
                this.Hide();
                Login c = new Login();
                c.ShowDialog();
                this.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Views.Renta.IndexRenta c = new Views.Renta.IndexRenta();
            c.ShowDialog();
            this.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            label1.Text = Data.LoginInfo.user.full_name.ToString();
            label3.Text = Data.LoginInfo.user.email.ToString();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Views.Renta.IndexRenta c = new Views.Renta.IndexRenta();
            c.ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Views.TipoVehiculo.IndexTipoVehiculo c = new Views.TipoVehiculo.IndexTipoVehiculo();
            c.ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Views.Marca.IndexMarca c = new Views.Marca.IndexMarca();
            c.ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Views.Modelo.IndexModelo c = new Views.Modelo.IndexModelo();
            c.ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Views.Combustible.IndexCombustible c = new Views.Combustible.IndexCombustible();
            c.ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Views.Vehiculo.IndexVehiculo c = new Views.Vehiculo.IndexVehiculo();
            c.ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Views.Cliente.IndexCliente c = new Views.Cliente.IndexCliente();
            c.ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("¿Deseas abandonar la sesión?",
            "Empleado", MessageBoxButtons.YesNo);

            if (msg == DialogResult.Yes)
            {
                Data.LoginInfo.user = null;
                this.Hide();
                Login c = new Login();
                c.ShowDialog();
                this.Close();
            }
        }
    }
}
