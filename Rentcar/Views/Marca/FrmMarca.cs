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
    public partial class FrmMarca : Form
    {
        public int? id;
        marcas oMarca = null;
        public FrmMarca(int? id = null)
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
                oMarca = db.marcas.Find(this.id);
                txt_nombre.Text = oMarca.nombre;
                txt_descripcion.Text = oMarca.descripcion;
                if (oMarca.estado == true)
                {
                    radioButton1.Checked = Convert.ToBoolean(1);
                }
                else
                {
                    radioButton2.Checked = Convert.ToBoolean(1);
                }
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
                if (txt_nombre.Text.Trim() == "" || txt_descripcion.Text.Trim() == "" || !radioButton1.Checked && !radioButton2.Checked)
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                }
                else
                {
                    if (this.id == null)
                    {
                        marcas oMarca = new marcas();
                        oMarca.nombre = txt_nombre.Text.Trim();
                        oMarca.descripcion = txt_descripcion.Text.Trim();
                        if (radioButton1.Checked)
                        {
                            oMarca.estado = true;
                        }
                        else if (radioButton2.Checked)
                        {
                            oMarca.estado = false;
                        }
                        db.marcas.Add(oMarca);
                    }
                    else
                    {
                        oMarca = db.marcas.Find(this.id);
                        oMarca.nombre = txt_nombre.Text.Trim();
                        oMarca.descripcion = txt_descripcion.Text.Trim();
                        if (radioButton1.Checked)
                        {
                            oMarca.estado = true;
                        }
                        else if (radioButton2.Checked)
                        {
                            oMarca.estado = false;
                        }
                        db.Entry(oMarca).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                    this.Close();
                }
            }
        }
    }
}
