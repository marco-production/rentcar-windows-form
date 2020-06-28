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

namespace Rentcar.Views.Marca
{
    public partial class IndexMarca : Form
    {

        public int? id;
        public IndexMarca(int? id = null)
        {
            this.id = id;
            InitializeComponent();
        }

        private void IndexMarca_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSetMarcas.marcas' Puede moverla o quitarla según sea necesario.
            refreshDataGrid();

        }

        private int? getId()
        {
            try
            {
                return int.Parse(dataGridViewMarca.Rows[dataGridViewMarca.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void refreshDataGrid()
        {
            this.marcasTableAdapter.Fill(this.rentcarDataSetMarcas.marcas);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home c = new Home();
            c.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMarca c = new FrmMarca(null);
            c.ShowDialog();
            refreshDataGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int? id = getId();

            if (id != null)
            {
                DialogResult msg = MessageBox.Show("¿Seguro que deseas eliminar esta marca?",
                "Marca", MessageBoxButtons.YesNo);

                if (msg == DialogResult.Yes)
                {
                    using (RentcarEntities db = new RentcarEntities())
                    {
                        marcas oMarca = db.marcas.Find(id);
                        db.marcas.Remove(oMarca);

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
                FrmMarca c = new FrmMarca(id);
                c.ShowDialog();
                refreshDataGrid();
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                if (textBox1.Text != string.Empty)
                {
                    var items = db.marcas.Where(c => c.nombre.Contains(textBox1.Text));
                    dataGridViewMarca.DataSource = items.ToList();
                }
                else
                {
                    dataGridViewMarca.DataSource = db.marcas.ToList();
                }
            }
        }
    }
}
