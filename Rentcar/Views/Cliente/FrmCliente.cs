using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rentcar.Models;

namespace Rentcar.Views.Cliente
{
    public partial class FrmCliente : Form
    {
        public int? id;
        clientes oClientes = null;
        public FrmCliente(int? id = null)
        {
            this.id = id;
            InitializeComponent();
            if (id != null)
            {
                loadData();
            }
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadData()
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                oClientes = db.clientes.Find(this.id);
                txt_fullname.Text = oClientes.full_name;
                txt_cedula.Text = oClientes.cedula;
                txt_numero_cr.Text = oClientes.numero_cr;
                txt_limite_credito.Text = oClientes.limite_credito;
                cmb_tipo_persona.SelectedItem = oClientes.tipo.ToString();
                if (oClientes.estado == true)
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
                if (txt_fullname.Text.Trim() == "" || txt_cedula.Text.Trim() == "" || txt_numero_cr.Text.Trim() == "" || string.IsNullOrEmpty(cmb_tipo_persona.Text) | txt_limite_credito.Text.Trim() == "" || !radioButton1.Checked && !radioButton2.Checked)
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                }
                else if (!IsValidDrCedula(txt_cedula.Text.Trim()))
                {
                    MessageBox.Show("La cedula no es valida.");
                }
                else
                {
                    if (this.id == null)
                    {
                        clientes oClientes = new clientes();
                        oClientes.full_name = txt_fullname.Text.Trim();
                        oClientes.cedula = txt_cedula.Text.Trim();
                        oClientes.numero_cr = txt_numero_cr.Text.Trim();
                        oClientes.limite_credito = txt_limite_credito.Text.Trim();
                        oClientes.tipo = cmb_tipo_persona.SelectedItem.ToString();
                        if (radioButton1.Checked)
                        {
                            oClientes.estado = true;
                        }
                        else if (radioButton2.Checked)
                        {
                            oClientes.estado = false;
                        }
                        db.clientes.Add(oClientes);
                    }
                    else
                    {
                        oClientes = db.clientes.Find(this.id);
                        oClientes.full_name = txt_fullname.Text.Trim();
                        oClientes.cedula = txt_cedula.Text.Trim();
                        oClientes.numero_cr = txt_numero_cr.Text.Trim();
                        oClientes.limite_credito = txt_limite_credito.Text.Trim();
                        oClientes.tipo = cmb_tipo_persona.SelectedItem.ToString();
                        if (radioButton1.Checked)
                        {
                            oClientes.estado = true;
                        }
                        else if (radioButton2.Checked)
                        {
                            oClientes.estado = false;
                        }
                        db.Entry(oClientes).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                    this.Close();
                }
            }
        }

        //Validar Cedula
        public static bool IsValidDrCedula(string drCedula)
        {
            // Valid format?
            if (drCedula.Equals(null))
            {
                return false;
            }
            else
            {
                drCedula = Regex.Replace(drCedula, "[^0-9]", string.Empty); // Only keep #s.
                if (drCedula.Equals(null) || !drCedula.Length.Equals(11) || long.Parse(drCedula).Equals(0))
                {
                    return false;
                }
            }

            // Validate.
            int sum = 0;
            for (int i = 0; i < 10; ++i)
            {
                int n = ((i + 1) % 2 != 0 ? 1 : 2) * int.Parse(drCedula.Substring(i, 1));
                sum += (n <= 9 ? n : n % 10 + 1);
            }
            int dig = ((10 - sum % 10) % 10);
            return (dig.Equals(int.Parse(drCedula.Substring(10, 1))) ? true : false);
        }
    }
}
