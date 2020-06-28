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

namespace Rentcar.Views.Empleado
{
    public partial class IndexEmpleado : Form
    {
        public int? id;
        public IndexEmpleado(int? id = null)
        {
            this.id = id;
            InitializeComponent();
        }

        private void IndexEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSetEmpleados.empleados' Puede moverla o quitarla según sea necesario.
            refreshDataGrid();
            dataGridViewEmpleados.Columns[1].HeaderText = "Full name";
            dataGridViewEmpleados.Columns[6].HeaderText = "Fecha de ingreso";
            dataGridViewEmpleados.Columns[7].HeaderText = "Tipo de usuario";
        }

        private void refreshDataGrid()
        {
            this.empleadosTableAdapter.Fill(this.rentcarDataSetEmpleados.empleados);
        }

        private int? getId()
        {
            try
            {
                return int.Parse(dataGridViewEmpleados.Rows[dataGridViewEmpleados.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Views.Home_admin c = new Views.Home_admin();
            c.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int? id = getId();

            if (id != null)
            {
                DialogResult msg = MessageBox.Show("¿Seguro que deseas eliminar este empleado?",
                "Empleados", MessageBoxButtons.YesNo);

                if (msg == DialogResult.Yes)
                {
                    using (RentcarEntities db = new RentcarEntities())
                    {
                        empleados oEmpleado = db.empleados.Find(id);
                        db.empleados.Remove(oEmpleado);

                        db.SaveChanges();
                    }
                    refreshDataGrid();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEmpleado c = new FrmEmpleado(null);
            c.ShowDialog();

            refreshDataGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int? id = getId();

            if (id != null)
            {
                FrmEmpleado c = new FrmEmpleado(id);
                c.ShowDialog();

                refreshDataGrid();
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Views.Home_admin c = new Views.Home_admin();
            c.ShowDialog();
            this.Close();
        }

        private void empleadosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
