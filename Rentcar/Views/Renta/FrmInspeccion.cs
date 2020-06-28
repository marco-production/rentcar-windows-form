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
    public partial class FrmInspeccion : Form
    {
        public int? id;
        public string action;

        inspeccions oInspeccion = null;
        rentas oRenta = null;

        public FrmInspeccion(int? renta_id = null, string action_frm = null)
        {
            this.id = renta_id;
            this.action = action_frm;
            InitializeComponent();
            if (action_frm == "Edit")
            {
                loadData();
            }
        }

        private void FrmInspeccion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSetEmpleadoInspeccionSelect.empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.FillByEstado(this.rentcarDataSetEmpleadoInspeccionSelect.empleados);
            using (RentcarEntities db = new RentcarEntities())
            {
                if (this.action == "New")
                {
                    oRenta = db.rentas.Find(this.id);
                }
                else
                {
                    oRenta = db.rentas.Find(oInspeccion.renta_id);
                    cmb_empleado.SelectedValue = oInspeccion.empleado_id;
                }

                dtp_fecha_inspeccion.MinDate = oRenta.fecha_renta.Value;
            }
        }

        private void loadData()
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                oInspeccion = db.inspeccions.Where(c => c.renta_id == this.id).First();

                dtp_fecha_inspeccion.Value = oInspeccion.fecha_inspeccion.Value;
                cmb_combustible.SelectedItem = oInspeccion.combustible;

                //Tiene ralladuras
                if (oInspeccion.ralladura == true)
                {
                    radio_ralladura_si.Checked = Convert.ToBoolean(1);
                }
                else if (oInspeccion.ralladura == false)
                {
                    radio_ralladura_no.Checked = Convert.ToBoolean(1);
                }

                //Tiene goma de repuesta
                if (oInspeccion.goma_repuesto == true)
                {
                    radio_goma_repuesta_si.Checked = Convert.ToBoolean(1);
                }
                else if (oInspeccion.goma_repuesto == false)
                {
                    radio_goma_repuesta_no.Checked = Convert.ToBoolean(1);
                }

                //Tiene gato
                if (oInspeccion.gato == true)
                {
                    radio_gato_si.Checked = Convert.ToBoolean(1);
                }
                else if (oInspeccion.gato == false)
                {
                    radio_gato_no.Checked = Convert.ToBoolean(1);
                }

                // Tiene rotura de cristal
                if (oInspeccion.rotura_cristal == true)
                {
                    radio_cristal_si.Checked = Convert.ToBoolean(1);
                }
                else if (oInspeccion.rotura_cristal == false)
                {
                    radio_cristal_no.Checked = Convert.ToBoolean(1);
                }

                //Goma superior derecha
                if (oInspeccion.goma_superior_derecha == true)
                {
                    check_s_derecha.Checked = Convert.ToBoolean(1);
                }

                //Goma inferior derecha
                if (oInspeccion.goma_inferior_derecha == true)
                {
                    check_i_derecha.Checked = Convert.ToBoolean(1);
                }

                //Goma superior izquierda
                if (oInspeccion.goma_superior_izquierda == true)
                {
                    check_s_izquierda.Checked = Convert.ToBoolean(1);
                }

                //Goma inferior izquierda
                if (oInspeccion.goma_inferior_izquierda == true)
                {
                    check_i_izquierda.Checked = Convert.ToBoolean(1);
                }

                //Estado de Inspeccion
                if (oInspeccion.estado == true)
                {
                    radio_activo.Checked = Convert.ToBoolean(1);
                }
                else
                {
                    radio_inactivo.Checked = Convert.ToBoolean(1);
                }
            }
        }

        private void fillByEstadoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.empleadosTableAdapter.FillByEstado(this.rentcarDataSetEmpleadoInspeccionSelect.empleados);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                if (string.IsNullOrEmpty(cmb_empleado.Text) || string.IsNullOrEmpty(cmb_combustible.Text) || !radio_ralladura_si.Checked && !radio_ralladura_no.Checked || !radio_goma_repuesta_si.Checked && !radio_goma_repuesta_no.Checked || !radio_gato_si.Checked && !radio_gato_no.Checked || !radio_cristal_si.Checked && !radio_cristal_no.Checked || !radio_activo.Checked && !radio_inactivo.Checked)
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                }
                else
                {
                    if (this.action == "New")
                    {
                        inspeccions oInspeccion = new inspeccions();

                        oInspeccion.renta_id = this.id;
                        oInspeccion.fecha_inspeccion = dtp_fecha_inspeccion.Value;
                        oInspeccion.empleado_id = int.Parse(cmb_empleado.SelectedValue.ToString());
                        oInspeccion.combustible = cmb_combustible.SelectedItem.ToString();

                        //Tiene ralladuras
                        if (radio_ralladura_si.Checked)
                        {
                            oInspeccion.ralladura = true;
                        }
                        else if (radio_ralladura_no.Checked)
                        {
                            oInspeccion.ralladura = false;
                        }

                        //Tiene goma de repuesta
                        if (radio_goma_repuesta_si.Checked)
                        {
                            oInspeccion.goma_repuesto = true;
                        }
                        else if (radio_goma_repuesta_no.Checked)
                        {
                            oInspeccion.goma_repuesto = false;
                        }

                        //Tiene gato
                        if (radio_gato_si.Checked)
                        {
                            oInspeccion.gato = true;
                        }
                        else if (radio_gato_no.Checked)
                        {
                            oInspeccion.gato = false;
                        }

                        // Tiene rotura de cristal
                        if (radio_cristal_si.Checked)
                        {
                            oInspeccion.rotura_cristal = true;
                        }
                        else if (radio_cristal_no.Checked)
                        {
                            oInspeccion.rotura_cristal = false;
                        }

                        //Estado de Inspeccion
                        if (radio_activo.Checked)
                        {
                            oInspeccion.estado = true;
                        }
                        else if (radio_inactivo.Checked)
                        {
                            oInspeccion.estado = false;
                        }

                        //Goma superior derecha
                        if (check_s_derecha.Checked)
                        {
                            oInspeccion.goma_superior_derecha = true;
                        }

                        //Goma inferior derecha
                        if (check_i_derecha.Checked)
                        {
                            oInspeccion.goma_inferior_derecha = true;
                        }

                        //Goma superior izquierda
                        if (check_s_izquierda.Checked)
                        {
                            oInspeccion.goma_superior_izquierda = true;
                        }

                        //Goma inferior izquierda
                        if (check_i_izquierda.Checked)
                        {
                            oInspeccion.goma_inferior_izquierda = true;
                        }

                        db.inspeccions.Add(oInspeccion);
                        db.SaveChanges();
                        this.Close();
                    }
                    else if (this.action == "Edit")
                    {
                        //ESTO NO ESTA GUARDANDO
                        oInspeccion = db.inspeccions.Where(c => c.renta_id == this.id).First();

                        oInspeccion.fecha_inspeccion = dtp_fecha_inspeccion.Value;
                        oInspeccion.empleado_id = int.Parse(cmb_empleado.SelectedValue.ToString());
                        oInspeccion.combustible = cmb_combustible.SelectedItem.ToString();

                        //Tiene ralladuras
                        if (radio_ralladura_si.Checked)
                        {
                            oInspeccion.ralladura = true;
                        }
                        else if (radio_ralladura_no.Checked)
                        {
                            oInspeccion.ralladura = false;
                        }

                        //Tiene goma de repuesta
                        if (radio_goma_repuesta_si.Checked)
                        {
                            oInspeccion.goma_repuesto = true;
                        }
                        else if (radio_goma_repuesta_no.Checked)
                        {
                            oInspeccion.goma_repuesto = false;
                        }

                        //Tiene gato
                        if (radio_gato_si.Checked)
                        {
                            oInspeccion.gato = true;
                        }
                        else if (radio_gato_no.Checked)
                        {
                            oInspeccion.gato = false;
                        }

                        // Tiene rotura de cristal
                        if (radio_cristal_si.Checked)
                        {
                            oInspeccion.rotura_cristal = true;
                        }
                        else if (radio_cristal_no.Checked)
                        {
                            oInspeccion.rotura_cristal = false;
                        }

                        //Goma superior derecha
                        if (check_s_derecha.Checked)
                        {
                            oInspeccion.goma_superior_derecha = true;
                        }

                        //Goma inferior derecha
                        if (check_i_derecha.Checked)
                        {
                            oInspeccion.goma_inferior_derecha = true;
                        }

                        //Goma superior izquierda
                        if (check_s_izquierda.Checked)
                        {
                            oInspeccion.goma_superior_izquierda = true;
                        }

                        //Goma inferior izquierda
                        if (check_i_izquierda.Checked)
                        {
                            oInspeccion.goma_inferior_izquierda = true;
                        }

                        //Estado de Inspeccion
                        if (radio_activo.Checked)
                        {
                            oInspeccion.estado = true;
                        }
                        else if (radio_inactivo.Checked)
                        {
                            oInspeccion.estado = false;
                        }

                        db.Entry(oInspeccion).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        this.Hide();
                        Views.Renta.IndexRenta a = new Views.Renta.IndexRenta();
                        a.ShowDialog();
                        this.Close();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
