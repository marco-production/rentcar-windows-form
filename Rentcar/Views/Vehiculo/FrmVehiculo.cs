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
    public partial class FrmVehiculo : Form
    {
        public int? id;
        vehiculos oVehiculos = null;
        public FrmVehiculo(int? id = null)
        {
            this.id = id;
            InitializeComponent();
            if (id != null)
            {
                loadData();
            }
        }

        private void loadData()
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                oVehiculos = db.vehiculos.Find(this.id);
                txt_anio.Value = int.Parse(oVehiculos.anio.ToString());
                txt_chasis.Text = oVehiculos.chasis;
                txt_placa.Text = oVehiculos.placa;
                txt_motor.Text = oVehiculos.motor;
                txt_descripcion.Text = oVehiculos.descripcion;
                if (oVehiculos.estado == true)
                {
                    radioButton1.Checked = Convert.ToBoolean(1);
                }
                else
                {
                    radioButton2.Checked = Convert.ToBoolean(1);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                if (txt_chasis.Text.Trim() == "" || txt_motor.Text.Trim() == "" || txt_placa.Text.Trim() == "" || txt_anio.Text.Trim() == "" || txt_descripcion.Text.Trim() == "" || !radioButton1.Checked && !radioButton2.Checked)
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                }
                else
                {
                    int marca_id = int.Parse(cmb_marca.SelectedValue.ToString());
                    int modelo_id = int.Parse(cmb_modelo.SelectedValue.ToString());

                    var marca = db.marcas.Find(marca_id);
                    var modelo = db.modelos.Find(modelo_id);

                    if (this.id == null)
                    {
                        vehiculos oVehiculos = new vehiculos();
                        oVehiculos.tipo_vehiculo_id = int.Parse(cmb_tipo_vehiculo.SelectedValue.ToString());
                        oVehiculos.marca_id = marca_id;
                        oVehiculos.modelo_id = modelo_id;
                        oVehiculos.combustible_id = int.Parse(cmb_combustible.SelectedValue.ToString());
                        oVehiculos.anio = int.Parse(txt_anio.Value.ToString());
                        oVehiculos.chasis = txt_chasis.Text.Trim();
                        oVehiculos.placa = txt_placa.Text.Trim();
                        oVehiculos.motor = txt_motor.Text.Trim();
                        oVehiculos.descripcion = txt_descripcion.Text.Trim();
                        oVehiculos.vehiculo = marca.nombre+' '+modelo.nombre+' '+txt_anio.Value.ToString();
                        if (radioButton1.Checked)
                        {
                            oVehiculos.estado = true;
                        }
                        else if (radioButton2.Checked)
                        {
                            oVehiculos.estado = false;
                        }
                        db.vehiculos.Add(oVehiculos);
                    }
                    else
                    {
                        oVehiculos = db.vehiculos.Find(this.id);
                        oVehiculos.tipo_vehiculo_id = int.Parse(cmb_tipo_vehiculo.SelectedValue.ToString());
                        oVehiculos.marca_id = int.Parse(cmb_marca.SelectedValue.ToString());
                        oVehiculos.modelo_id = int.Parse(cmb_modelo.SelectedValue.ToString());
                        oVehiculos.combustible_id = int.Parse(cmb_combustible.SelectedValue.ToString());
                        oVehiculos.anio = int.Parse(txt_anio.Value.ToString());
                        oVehiculos.chasis = txt_chasis.Text.Trim();
                        oVehiculos.placa = txt_placa.Text.Trim();
                        oVehiculos.motor = txt_motor.Text.Trim();
                        oVehiculos.descripcion = txt_descripcion.Text.Trim();
                        oVehiculos.vehiculo = marca.nombre + ' ' + modelo.nombre + ' ' + txt_anio.Value.ToString();
                        if (radioButton1.Checked)
                        {
                            oVehiculos.estado = true;
                        }
                        else if (radioButton2.Checked)
                        {
                            oVehiculos.estado = false;
                        }
                        db.Entry(oVehiculos).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                    this.Close();
                }
            }
        }

        private void FrmVehiculo_Load(object sender, EventArgs e)
        {
            //cmb_marca.

            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSetMarcaRealSelect.marcas' Puede moverla o quitarla según sea necesario.
            this.marcasTableAdapter.FillByEstado(this.rentcarDataSetMarcaRealSelect.marcas);
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSetCombustiblesSelect.combustibles' Puede moverla o quitarla según sea necesario.
            this.combustiblesTableAdapter.FillByEstado(this.rentcarDataSetCombustiblesSelect.combustibles);
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSetModelosSelect.modelos' Puede moverla o quitarla según sea necesario.
            this.modelosTableAdapter.FillByMarca(this.rentcarDataSetModelosSelect.modelos, int.Parse(cmb_marca.SelectedValue.ToString()));
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSetTipoSelect.tipovehiculos' Puede moverla o quitarla según sea necesario.
            this.tipovehiculosTableAdapter.FillByEstado(this.rentcarDataSetTipoSelect.tipovehiculos);

            cmb_marca.SelectedIndexChanged += 
                new System.EventHandler(
                    cmb_marca_SelectedIndexChanged
            );
                
            
            if (this.id != null)
            {
                cmb_tipo_vehiculo.SelectedValue = oVehiculos.tipo_vehiculo_id;
                cmb_marca.SelectedValue = oVehiculos.marca_id;
                cmb_modelo.SelectedValue = oVehiculos.modelo_id;
                cmb_combustible.SelectedValue = oVehiculos.combustible_id;

                using (RentcarEntities db = new RentcarEntities())
                {
                    //Si el vehiculo esta en renta el estado del vehiculo no se puede cambiar.
                    int confirmRenta = db.rentas.Where(c => c.vehiculo_id == this.id).Count(c => c.estado == true);

                    if (confirmRenta > 0)
                    {
                        radioButton1.Enabled = false;
                        radioButton2.Enabled = false;
                    }
                }
            }

        }

        private void cmb_marca_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.modelosTableAdapter.FillByMarca(this.rentcarDataSetModelosSelect.modelos, int.Parse(cmb_marca.SelectedValue.ToString()));
        }

            private void fillByEstadoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tipovehiculosTableAdapter.FillByEstado(this.rentcarDataSetTipoSelect.tipovehiculos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByEstadoToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.marcasTableAdapter.FillByEstado(this.rentcarDataSetMarcaRealSelect.marcas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByEstadoToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.modelosTableAdapter.FillByEstado(this.rentcarDataSetModelosSelect.modelos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByEstadoToolStripButton_Click_3(object sender, EventArgs e)
        {
            try
            {
                this.combustiblesTableAdapter.FillByEstado(this.rentcarDataSetCombustiblesSelect.combustibles);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByMarcaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.modelosTableAdapter.FillByMarca(this.rentcarDataSetModelosSelect.modelos, new System.Nullable<int>(((int)(System.Convert.ChangeType(int.Parse(cmb_marca.SelectedValue.ToString()), typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
