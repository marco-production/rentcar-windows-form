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
    public partial class FrmModelo : Form
    {
        public int? id;
        modelos oModelo = null;
        public FrmModelo(int? id = null)
        {
            this.id = id;
            InitializeComponent();
            if (id != null)
            {
                loadData();
            }
        }

        private void FrmModelo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSetMarcaSelect.marcas' Puede moverla o quitarla según sea necesario.
            this.marcasTableAdapter.FillBy(this.rentcarDataSetMarcaSelect.marcas);

            if (this.id != null)
            {
                cmb_marca.SelectedValue = oModelo.marca_id;
            }
        }

        private void loadData()
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                oModelo = db.modelos.Find(this.id);
                txt_nombre.Text = oModelo.nombre;
                txt_descripcion.Text = oModelo.descripcion;
                if (oModelo.estado == true)
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
                if (txt_nombre.Text.Trim() == "" || txt_descripcion.Text.Trim() == "" || cmb_marca.SelectedValue.ToString() == "" || string.IsNullOrEmpty(cmb_marca.Text) || !radioButton1.Checked && !radioButton2.Checked)
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                }
                else
                {
                    if (this.id == null)
                    {
                        modelos oModelo = new modelos();
                        oModelo.nombre = txt_nombre.Text.Trim();
                        oModelo.descripcion = txt_descripcion.Text.Trim();
                        oModelo.marca_id = int.Parse(cmb_marca.SelectedValue.ToString());
                        if (radioButton1.Checked)
                        {
                            oModelo.estado = true;
                        }
                        else if (radioButton2.Checked)
                        {
                            oModelo.estado = false;
                        }
                        db.modelos.Add(oModelo);
                    }
                    else
                    {
                        oModelo = db.modelos.Find(this.id);
                        oModelo.nombre = txt_nombre.Text.Trim();
                        oModelo.descripcion = txt_descripcion.Text.Trim();
                        oModelo.marca_id = int.Parse(cmb_marca.SelectedValue.ToString());
                        if (radioButton1.Checked)
                        {
                            oModelo.estado = true;
                        }
                        else if (radioButton2.Checked)
                        {
                            oModelo.estado = false;
                        }
                        db.Entry(oModelo).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                    this.Close();
                }
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.marcasTableAdapter.FillBy(this.rentcarDataSetMarcaSelect.marcas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.marcasTableAdapter.FillBy1(this.rentcarDataSetMarcaSelect.marcas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.marcasTableAdapter.FillBy(this.rentcarDataSetMarcaSelect.marcas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.marcasTableAdapter.FillBy(this.rentcarDataSetMarcaSelect.marcas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
