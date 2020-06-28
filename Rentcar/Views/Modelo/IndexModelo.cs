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

namespace Rentcar.Views.Modelo
{
    public partial class IndexModelo : Form
    {
        public int? id;
        public IndexModelo(int? id = null)
        {
            this.id = id;
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home c = new Home();
            c.ShowDialog();
            this.Close();
        }

        private void IndexModelo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSetModelos.modelos' Puede moverla o quitarla según sea necesario.
            refreshDataGrid();

            //Cambiar nombres de las columnas del DataGridView
            dataGridViewModelo.Columns[2].HeaderText = "Marca";
        }

        private void refreshDataGrid()
        {
            this.modelosTableAdapter.FillBy(this.rentcarDataSetModelos.modelos);
        }

        private int? getId()
        {
            try
            {
                return int.Parse(dataGridViewModelo.Rows[dataGridViewModelo.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int? id = getId();

            if (id != null)
            {
                DialogResult msg = MessageBox.Show("¿Seguro que deseas eliminar este modelo?",
                "Modelo", MessageBoxButtons.YesNo);

                if (msg == DialogResult.Yes)
                {
                    using (RentcarEntities db = new RentcarEntities())
                    {
                        modelos oModelo = db.modelos.Find(id);
                        db.modelos.Remove(oModelo);

                        db.SaveChanges();
                    }
                    refreshDataGrid();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmModelo c = new FrmModelo(null);
            c.ShowDialog();
            refreshDataGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int? id = getId();

            if (id != null)
            {
                using (RentcarEntities db = new RentcarEntities())
                {
                    var modelo = db.modelos.Find(id);
                    var marca = db.marcas.Find(modelo.marca_id);

                    if (marca.estado == true)
                    {
                        FrmModelo c = new FrmModelo(id);
                        c.ShowDialog();
                        refreshDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Este modelo no puede ser editado \nporque la marca esta inactiva.");
                    }
                }
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.modelosTableAdapter.FillBy(this.rentcarDataSetModelos1.modelos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Views.Combustible.IndexCombustible c = new Views.Combustible.IndexCombustible();
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

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Views.Cliente.IndexCliente c = new Views.Cliente.IndexCliente();
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

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Views.Modelo.IndexModelo c = new Views.Modelo.IndexModelo();
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
                    var items = db.modelos.Where(c => c.nombre.Contains(textBox1.Text));
                    dataGridViewModelo.DataSource = items.ToList();
                }
                else
                {
                    dataGridViewModelo.DataSource = db.modelos.ToList();
                }
            }
        }
    }
}
