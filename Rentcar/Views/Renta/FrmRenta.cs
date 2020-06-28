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
    public partial class FrmRenta : Form
    {
        public int? id;
        rentas oRenta = null;
        public FrmRenta(int? id = null)
        {
            this.id = id;
            InitializeComponent();
            if (id != null)
            {
                loadData();
            }
        }

        private void FrmRenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSetClientesSelect.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.FillByRealEstado(this.rentcarDataSetClientesSelect.clientes);
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSetEmpleadoselect.empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.FillByRealEstado(this.rentcarDataSetEmpleadoselect.empleados);
            if (id == null)
            {
                this.vehiculosTableAdapter.FillByEstado(this.rentcarDataSetVehiculosSelect.vehiculos);
                label_estado.Hide();
                radioButton1.Hide();
                radioButton2.Hide();
            }
            else
            {
                this.vehiculosTableAdapter.Fill(this.rentcarDataSetVehiculosSelect.vehiculos);
                cmb_empleado.SelectedValue = oRenta.empleado_id;
                cmb_vehiculo.SelectedValue = oRenta.vehiculo_id;
                cmb_cliente.SelectedValue = oRenta.cliente_id;
            }
        }

        private void loadData()
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                oRenta = db.rentas.Find(this.id);

                dtp_fecha_renta.Value = oRenta.fecha_renta.Value;
                dtp_fecha_devolucion.Value = oRenta.fecha_devolucion.Value;
                txt_monto.Value = int.Parse(oRenta.monto.ToString());
                txt_dias.Value = int.Parse(oRenta.dias.ToString());
                txt_comentario.Text = oRenta.comentario;

                if (oRenta.estado == true)
                {
                    radioButton1.Checked = Convert.ToBoolean(1);
                }
                else
                {
                    radioButton2.Checked = Convert.ToBoolean(1);
                }
            }
        }

        /*private void fillByEstadoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.empleadosTableAdapter.FillByEstado(this.rentcarDataSetEmpleadoselect.empleados);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }*/

        /*private void fillByEstadoToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.vehiculosTableAdapter.FillByEstado(this.rentcarDataSetVehiculosSelect.vehiculos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }*/

        private void clientesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fillByRealEstadoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientesTableAdapter.FillByRealEstado(this.rentcarDataSetClientesSelect.clientes);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByRealEstadoToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.empleadosTableAdapter.FillByRealEstado(this.rentcarDataSetEmpleadoselect.empleados);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                if (string.IsNullOrEmpty(cmb_empleado.Text) || string.IsNullOrEmpty(cmb_vehiculo.Text) || string.IsNullOrEmpty(cmb_cliente.Text) || int.Parse(txt_monto.Text) == 0 || int.Parse(txt_dias.Text) == 0 || !radioButton1.Checked && !radioButton2.Checked && this.id != null)
                {
                    MessageBox.Show("Completar los campos que son obligatorios.");
                }
                else if (dtp_fecha_renta.Value > dtp_fecha_devolucion.Value)
                {
                    MessageBox.Show("La fecha de renta no puede ser mayor a la fecha de devolucion.");
                }
                else
                {
                    int vehiculo_id = int.Parse(cmb_vehiculo.SelectedValue.ToString());
                    vehiculos oVehiculo = db.vehiculos.Find(vehiculo_id);

                    if (this.id == null)
                    {
                        rentas oRenta = new rentas();
                        oRenta.fecha_renta = dtp_fecha_renta.Value;
                        oRenta.fecha_devolucion = dtp_fecha_devolucion.Value;
                        oRenta.monto = int.Parse(txt_monto.Value.ToString());
                        oRenta.dias = int.Parse(txt_dias.Value.ToString());
                        oRenta.comentario = txt_comentario.Text.Trim();
                        oRenta.empleado_id = int.Parse(cmb_empleado.SelectedValue.ToString());
                        oRenta.vehiculo_id = vehiculo_id;
                        oRenta.cliente_id = int.Parse(cmb_cliente.SelectedValue.ToString());
                        oRenta.estado = true;
                        oVehiculo.estado = true;

                        //Cambiar el estado del vehiculo
                        oVehiculo.estado = false;

                        db.rentas.Add(oRenta);
                        db.Entry(oVehiculo).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        this.Close();
                    }
                    else
                    {
                        //Verificar si el vehiculo seleccionado esta en renta
                        oRenta = db.rentas.Find(this.id);
                        int confirmRenta = db.rentas.Where(c => c.vehiculo_id == vehiculo_id).Where(c => c.id != oRenta.id).Count(c => c.estado == true);

                        //Si el vehiculo ya esta en renta
                        if (confirmRenta > 0)
                        {
                            MessageBox.Show("El vehiculo que ha seleccionado ya esta en renta.");
                        }
                        else
                        {
                            //Si el vehiculo de renta es diferente al vehiculo rentado en ese momento
                            if (vehiculo_id != oRenta.vehiculo_id)
                            {
                               vehiculos changeEstado = db.vehiculos.Find(oRenta.vehiculo_id);
                               changeEstado.estado = true;
                               db.Entry(changeEstado).State = System.Data.Entity.EntityState.Modified;
                            }

                            oRenta.fecha_renta = dtp_fecha_renta.Value;
                            oRenta.fecha_devolucion = dtp_fecha_devolucion.Value;
                            oRenta.monto = int.Parse(txt_monto.Value.ToString());
                            oRenta.dias = int.Parse(txt_dias.Value.ToString());
                            oRenta.comentario = txt_comentario.Text.Trim();
                            oRenta.empleado_id = int.Parse(cmb_empleado.SelectedValue.ToString());
                            oRenta.vehiculo_id = vehiculo_id;
                            oRenta.cliente_id = int.Parse(cmb_cliente.SelectedValue.ToString());

                            if (radioButton1.Checked)
                            {
                                oRenta.estado = true;
                                oVehiculo.estado = false;
                            }
                            else if (radioButton2.Checked)
                            {
                                oRenta.estado = false;
                                oVehiculo.estado = true;
                            }

                            db.Entry(oRenta).State = System.Data.Entity.EntityState.Modified;
                            db.Entry(oVehiculo).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                            this.Close();
                        }
                    }
                }
            }
        }

        private void fillByEstadoToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.vehiculosTableAdapter.FillByEstado(this.rentcarDataSetVehiculosSelect.vehiculos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
