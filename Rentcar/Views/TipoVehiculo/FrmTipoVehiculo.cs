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
    public partial class FrmTipoVehiculo : Form
    {
        public int? id;
        tipovehiculos oTipoVehiculo = null;
        public FrmTipoVehiculo(int? id = null)
        {
            this.id = id;
            InitializeComponent();
            if (id != null)
            {
                loadData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmTipoVehiculo_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void loadData()
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                oTipoVehiculo = db.tipovehiculos.Find(this.id);
                txt_nombre.Text = oTipoVehiculo.nombre;
                txt_descripcion.Text = oTipoVehiculo.descripcion;
                if (oTipoVehiculo.estado == true)
                {
                   radioButton1.Checked =  Convert.ToBoolean(1);
                }
                else
                {
                    radioButton2.Checked = Convert.ToBoolean(1);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                if (txt_nombre.Text.Trim() == "" || txt_descripcion.Text.Trim() == "" || !radioButton1.Checked && !radioButton2.Checked)
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                }
                else
                {
                    if (this.id == null)
                    {
                        tipovehiculos oTipoVehiculo = new tipovehiculos();
                        oTipoVehiculo.nombre = txt_nombre.Text.Trim();
                        oTipoVehiculo.descripcion = txt_descripcion.Text.Trim();
                        if (radioButton1.Checked)
                        {
                            oTipoVehiculo.estado = true;
                        }
                        else if (radioButton2.Checked)
                        {
                            oTipoVehiculo.estado = false;
                        }
                        db.tipovehiculos.Add(oTipoVehiculo);
                    }
                    else
                    {
                        oTipoVehiculo = db.tipovehiculos.Find(this.id);
                        oTipoVehiculo.nombre = txt_nombre.Text.Trim();
                        oTipoVehiculo.descripcion = txt_descripcion.Text.Trim();
                        if (radioButton1.Checked)
                        {
                            oTipoVehiculo.estado = true;
                        }
                        else if (radioButton2.Checked)
                        {
                            oTipoVehiculo.estado = false;
                        }
                        db.Entry(oTipoVehiculo).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                    this.Close();
                }
            }
        }
    }
}
