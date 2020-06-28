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

namespace Rentcar.Views.TipoVehiculo
{
    public partial class IndexTipoVehiculo : Form
    {
        public int? id;
        public IndexTipoVehiculo(int? id = null)
        {
            this.id = id;
            InitializeComponent();
        }

        private void IndexTipoVehiculo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSetTipoVehiculo.tipovehiculos' Puede moverla o quitarla según sea necesario.
            refreshDataGrid();

        }

        private void refreshDataGrid()
        {
            this.tipovehiculosTableAdapter.Fill(this.rentcarDataSetTipoVehiculo.tipovehiculos);
        }

        private int? getId()
        {
            try
            {
                return int.Parse(dataGridViewTipoVehiculo.Rows[dataGridViewTipoVehiculo.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTipoVehiculo c = new FrmTipoVehiculo(null);
            c.ShowDialog();
            refreshDataGrid();
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
                DialogResult msg =  MessageBox.Show("¿Seguro que deseas eliminar este tipo de vehiculo?",
                "Tipos de vehiculos", MessageBoxButtons.YesNo);

                if (msg == DialogResult.Yes)
                {
                    using (RentcarEntities db = new RentcarEntities())
                    {
                        tipovehiculos oTipovehiculo = db.tipovehiculos.Find(id);
                        db.tipovehiculos.Remove(oTipovehiculo);

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
                FrmTipoVehiculo c = new FrmTipoVehiculo(id);
                c.ShowDialog();
                refreshDataGrid();
            }
        }

        private void dataGridViewTipoVehiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Views.Cliente.IndexCliente c = new Views.Cliente.IndexCliente();
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

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home c = new Home();
            c.ShowDialog();
            this.Close();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                if (textBox1.Text != string.Empty)
                {
                    var items = db.tipovehiculos.Where(c => c.nombre.Contains(textBox1.Text));
                    dataGridViewTipoVehiculo.DataSource = items.ToList();
                }
                else
                {
                    dataGridViewTipoVehiculo.DataSource = db.tipovehiculos.ToList();
                }
            }
        }
    }
}
