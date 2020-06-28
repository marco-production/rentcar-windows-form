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

namespace Rentcar.Views.Renta
{
    public partial class ShowRentaData : Form
    {
        public int? id;
        rentas oRenta = null;
        vehiculos oVehiculo;
        modelos oModelo;
        marcas oMarca;
        inspeccions oInspeccion;
        clientes oCliente;
        empleados oEmpleado, oEmpleadoInspeccion;

        public ShowRentaData(int? renta_id = null)
        {
            this.id = renta_id;
            InitializeComponent();
        }

        private void ShowRentaData_Load(object sender, EventArgs e)
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                oRenta = db.rentas.Find(this.id);
                oVehiculo = db.vehiculos.Find(oRenta.vehiculo_id);
                oCliente = db.clientes.Find(oRenta.cliente_id);
                oModelo = db.modelos.Find(oVehiculo.modelo_id);
                oMarca = db.marcas.Find(oVehiculo.marca_id);
                oInspeccion = db.inspeccions.Where(c => c.renta_id == oRenta.id).First();
                oEmpleado = db.empleados.Find(oRenta.empleado_id);
                oEmpleadoInspeccion = db.empleados.Find(oInspeccion.empleado_id);
            }
            //Detalles de renta
            label19.Text = oRenta.fecha_renta.Value.ToString("dd/MM/yyyy");
            label20.Text = oRenta.fecha_devolucion.Value.ToString("dd/MM/yyyy");
            label21.Text = oMarca.nombre + " " + oModelo.nombre + " " + oVehiculo.anio;
            label22.Text = oCliente.full_name + " ( " + oCliente.cedula + " )";
            label23.Text = oEmpleado.full_name + " ( " + oEmpleado.email + " )";
            label24.Text = "RD$" + oRenta.monto.ToString();
            label25.Text = oRenta.dias.ToString();
            label26.Text = "RD$" + (oRenta.monto * oRenta.dias).ToString();

            if (oRenta.estado == true)
            {
                label27.Text = "En renta";
            }
            else
            {
                label27.Text = "Devuelto";
            }

            label28.Text = oRenta.comentario;

            //Detalles de inspeccion
            label29.Text = oInspeccion.fecha_inspeccion.Value.ToString("dd/MM/yyyy");
            label30.Text = getValueOfBoolean(oInspeccion.ralladura.Value);
            label31.Text = getValueOfBoolean(oInspeccion.gato.Value);
            label32.Text = getValueOfBoolean(oInspeccion.goma_repuesto.Value);
            label33.Text = getValueOfBoolean(oInspeccion.rotura_cristal.Value);
            label34.Text =  oEmpleadoInspeccion.full_name + " ( " + oEmpleado.email + " )";
            label39.Text = oInspeccion.combustible;

            if (oInspeccion.goma_superior_derecha == true)
            {
                label35.Text = "Goma superior derecha";
            }
            if(oInspeccion.goma_superior_izquierda == true && oInspeccion.goma_superior_derecha == true)
            {
                label35.Text += ", Goma superior izquierda";
            }
            else
            {
                label35.Text += "Goma superior izquierda";
            }

            if (oInspeccion.goma_inferior_derecha == true)
            {
                label36.Text = "Goma inferior derecha";
            }
            if (oInspeccion.goma_inferior_izquierda == true && oInspeccion.goma_inferior_derecha == true)
            {
                label36.Text += ", Goma inferior izquierda";
            }
            else
            {
                label36.Text += "Goma inferior izquierda";
            }

            if (oInspeccion.estado == true)
            {
                label40.Text = "Activo";
            }
            else
            {
                label40.Text = "Inactivo";
            }
        }

        private string getValueOfBoolean(bool data)
        {
            if (data == true)
            {
                return "Si";
            }
            else
            {
                return "No";
            }
        }

        private void Vehiculo_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmInspeccion c = new FrmInspeccion(oRenta.id, "Edit");
            c.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("¿Seguro que deseas eliminar esta inspeccion?",
            "Inspeccion", MessageBoxButtons.YesNo);

            if (msg == DialogResult.Yes)
            {
                using (RentcarEntities db = new RentcarEntities())
                {
                    inspeccions oDeleteInspeccion = db.inspeccions.Find(oInspeccion.id);
                    db.inspeccions.Remove(oDeleteInspeccion);
                    db.SaveChanges();
                    this.Hide();
                    this.Close();
                }
            }
        }
    }
}
