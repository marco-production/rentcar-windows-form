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

namespace Rentcar.Views.Combustible
{
    public partial class FrmCombustible : Form
    {

        public int? id;
        combustibles oCombustible = null;
        public FrmCombustible(int? id = null)
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
                oCombustible = db.combustibles.Find(this.id);
                txt_nombre.Text = oCombustible.nombre;
                txt_descripcion.Text = oCombustible.descripcion;
                if (oCombustible.estado == true)
                {
                    radioButton1.Checked = Convert.ToBoolean(1);
                }
                else
                {
                    radioButton2.Checked = Convert.ToBoolean(1);
                }
            }
        }

        private void FrmCombustible_Load(object sender, EventArgs e)
        {

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
                        combustibles oCombustible = new combustibles();
                        oCombustible.nombre = txt_nombre.Text.Trim();
                        oCombustible.descripcion = txt_descripcion.Text.Trim();
                        if (radioButton1.Checked)
                        {
                            oCombustible.estado = true;
                        }
                        else if (radioButton2.Checked)
                        {
                            oCombustible.estado = false;
                        }
                        db.combustibles.Add(oCombustible);
                    }
                    else
                    {
                        oCombustible = db.combustibles.Find(this.id);
                        oCombustible.nombre = txt_nombre.Text.Trim();
                        oCombustible.descripcion = txt_descripcion.Text.Trim();
                        if (radioButton1.Checked)
                        {
                            oCombustible.estado = true;
                        }
                        else if (radioButton2.Checked)
                        {
                            oCombustible.estado = false;
                        }
                        db.Entry(oCombustible).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
