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

namespace Rentcar.Views.Vehiculo
{
    public partial class IndexVehiculo : Form
    {
        public int? id;
        public IndexVehiculo(int? id = null)
        {
            this.id = id;
            InitializeComponent();
        }

        private void IndexVehiculo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSetVehiculos.vehiculos' Puede moverla o quitarla según sea necesario.
            refreshDataGrid();

            //Cambiar nombres de las columnas del DataGridView
            dataGridViewVehiculo.Columns[1].HeaderText = "Tipo de vehiculo";
            dataGridViewVehiculo.Columns[2].HeaderText = "Marca";
            dataGridViewVehiculo.Columns[3].HeaderText = "Modelo";
            dataGridViewVehiculo.Columns[4].HeaderText = "Año";
            dataGridViewVehiculo.Columns[5].HeaderText = "Combustible";
        }

        private void refreshDataGrid()
        {
            this.vehiculosTableAdapter.Fill(this.rentcarDataSetVehiculos.vehiculos);
        }

        private int? getId()
        {
            try
            {
                return int.Parse(dataGridViewVehiculo.Rows[dataGridViewVehiculo.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home c = new Home();
            c.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int? id = getId();

            if (id != null)
            {
                DialogResult msg = MessageBox.Show("¿Seguro que deseas eliminar este vehiculo?",
                "Vehiculos", MessageBoxButtons.YesNo);

                if (msg == DialogResult.Yes)
                {
                    using (RentcarEntities db = new RentcarEntities())
                    {
                        vehiculos oVehiculo = db.vehiculos.Find(id);
                        db.vehiculos.Remove(oVehiculo);

                        db.SaveChanges();
                    }
                    refreshDataGrid();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int? id = getId();

            if (id != null)
            {
                FrmVehiculo c = new FrmVehiculo(id);
                c.ShowDialog();
                refreshDataGrid();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmVehiculo c = new FrmVehiculo(null);
            c.ShowDialog();
            refreshDataGrid();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home c = new Home();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                if (textBox1.Text != string.Empty)
                {
                    var items = db.marcas.Where(c => c.nombre.Contains(textBox1.Text));
                    dataGridViewVehiculo.DataSource = items.ToList();
                }
                else
                {
                    dataGridViewVehiculo.DataSource = db.marcas.ToList();
                }
            }
        }
    }
}
