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
using Microsoft.Office.Interop.Excel;

namespace Rentcar.Views.Renta
{
    public partial class IndexRenta : Form
    {
        public int? id;
        inspeccions oInspeccion = null;
        public IndexRenta(int? id = null)
        {
            this.id = id;
            InitializeComponent();
        }

        private void IndexRenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSetSelectEmpleadoIndexRenta.empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.rentcarDataSetSelectEmpleadoIndexRenta.empleados);
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSetRentas.rentas' Puede moverla o quitarla según sea necesario.
            refreshDataGrid();
            //Cambiar nombres de las columnas del DataGridView
            dataGridViewRentas.Columns[1].HeaderText = "Fecha renta";
            dataGridViewRentas.Columns[2].HeaderText = "Fecha devolución";
            dataGridViewRentas.Columns[4].HeaderText = "Vehiculo";
            dataGridViewRentas.Columns[5].HeaderText = "Cliente";
            dataGridViewRentas.Columns[6].HeaderText = "Empleado";

            //El 1er valor del select en blanco
            cmb_empleado.Text = "-- Seleccione un empleado --";
            // cmb_empleado.SelectedIndex = -1;

            ArrangeGrid(dataGridViewRentas);

        }

        //Ajuntar el ancho del texto de la columna del DataGridView - Para que no alla santo de linea de por ejemplo fecha de renta
        public static void ArrangeGrid(DataGridView Grid)
        {
            int twidth = 0;
            if (Grid.Rows.Count > 0)
            {
                twidth = (Grid.Width * Grid.Columns.Count) / 100;
                for (int i = 0; i < Grid.Columns.Count; i++)
                {
                    Grid.Columns[i].Width = twidth;
                }

            }
        }

        //refrescar el DataFridView
        private void refreshDataGrid(string consult = null, int? empleado_id = null, string fecha_renta = null, string fecha_devolucion = null)
        {
            //Se determina el tipo de consulta
            switch (consult)
            {
                case "FillAll":
                    this.rentasTableAdapter.FillByAllFilter(this.rentcarDataSetRentas.rentas, empleado_id, fecha_renta, fecha_devolucion);
                break;

                case "FillByDate":
                    this.rentasTableAdapter.FillByDate(this.rentcarDataSetRentas.rentas, fecha_renta, fecha_devolucion);
                break;

                default:
                    this.rentasTableAdapter.Fill(this.rentcarDataSetRentas.rentas);
                break;
            }

            
        }

        private int? getId()
        {
            try
            {
                return int.Parse(dataGridViewRentas.Rows[dataGridViewRentas.CurrentRow.Index].Cells[0].Value.ToString());
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
                DialogResult msg = MessageBox.Show("¿Seguro que deseas eliminar esta renta?",
                "Rentas", MessageBoxButtons.YesNo);

                if (msg == DialogResult.Yes)
                {
                    using (RentcarEntities db = new RentcarEntities())
                    {
                        rentas oRenta = db.rentas.Find(id);
                        db.rentas.Remove(oRenta);

                        db.SaveChanges();
                    }
                    refreshDataGrid();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRenta c = new FrmRenta(null);
            c.ShowDialog();
            refreshDataGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int? id = getId();

            if (id != null)
            {
                FrmRenta c = new FrmRenta(id);
                c.ShowDialog();
                refreshDataGrid();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home c = new Home();
            c.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int? id = getId();
            int? countInspeccion = null;

            if (id != null)
                {
                    using (RentcarEntities db = new RentcarEntities())
                    {
                        countInspeccion = db.inspeccions.Count(a => a.renta_id == id);
                    }

                    if(countInspeccion > 0)
                    {
                        ShowRentaData c = new ShowRentaData(id);
                        c.ShowDialog();
                        refreshDataGrid();
                    }
                    else
                    {
                        FrmInspeccion c = new FrmInspeccion(id,"New");
                        c.ShowDialog();
                        refreshDataGrid();
                    }
                }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewRentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByAllFilterToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.rentasTableAdapter.FillByAllFilter(this.rentcarDataSetRentas.rentas, new System.Nullable<int>(((int)(System.Convert.ChangeType(parameterEmpleadoToolStripTextBox.Text, typeof(int))))), parameterFechaRentaToolStripTextBox.Text, parameterFechaDevolucionToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            //Verificar si el select de empleados tiene un valor seleccionado o no.
            int empleado_id = cmb_empleado.SelectedItem != null ? int.Parse(cmb_empleado.SelectedValue.ToString()) : 0;
            string fecha_renta = dtp_fecha_renta.Value.ToString("yyyy-MM-dd");
            string fecha_devolucion = dtp_fecha_devolucion.Value.ToString("yyyy-MM-dd");

            //If existe un valor en empleados se filtra por 3 valores
            if (empleado_id != 0)
            {
                refreshDataGrid("FillAll", empleado_id, fecha_renta, fecha_devolucion);
            }
            else
            {
                refreshDataGrid("FillByDate", empleado_id, fecha_renta, fecha_devolucion);
            }
        }

        //Exportal a excel
        public void exportaraexcel(DataGridView tabla)
        {

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns) // Columnas
            {

                IndiceColumna++;

                excel.Cells[1, IndiceColumna] = col.Name;

            }

            int IndeceFila = 0;

            foreach (DataGridViewRow row in tabla.Rows) // Filas
            {

                IndeceFila++;

                IndiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {

                    IndiceColumna++;

                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;

                }

            }

            excel.Visible = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            exportaraexcel(dataGridViewRentas);
        }

        private void fillByDateToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.rentasTableAdapter.FillByDate(this.rentcarDataSetRentas.rentas, parameterFechaRentaToolStripTextBox.Text, parameterFechaDevolucionToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

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

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home c = new Home();
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

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Views.TipoVehiculo.IndexTipoVehiculo c = new Views.TipoVehiculo.IndexTipoVehiculo();
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

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Views.Vehiculo.IndexVehiculo c = new Views.Vehiculo.IndexVehiculo();
            c.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            refreshDataGrid();
            cmb_empleado.SelectedIndex = -1;
            cmb_empleado.Text = "-- Seleccione un empleado --";
        }
    }
}
