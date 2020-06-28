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

namespace Rentcar.Views.Empleado
{
    public partial class FrmEmpleado : Form
    {
        public int? id;
        empleados oEmpleado = null;
        public FrmEmpleado(int? id = null)
        {
            this.id = id;
            InitializeComponent();
            if (id != null)
            {
                loadData();
            }
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rentcarDataSetRoles.roles' Puede moverla o quitarla según sea necesario.
            this.rolesTableAdapter.Fill(this.rentcarDataSetRoles.roles);
            txt_password.PasswordChar = char.Parse("*");
            txt_confirm_password.PasswordChar = char.Parse("*");

            /*if (this.id != null)
            {
                cmb_role.SelectedValue = oEmpleado.role_id;
            }*/
            //.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadData()
        {
            label11.Text = "Editar Usuario";
            using (RentcarEntities db = new RentcarEntities())
            {
                oEmpleado = db.empleados.Find(this.id);
                txt_fullname.Text = oEmpleado.full_name;
                txt_email.Text = oEmpleado.email;
                txt_cedula.Text = oEmpleado.cedula;
                cmb_tanda.SelectedItem = oEmpleado.tanda;
                cmb_comision.SelectedItem = oEmpleado.comision;
                dtp_fecha_ingreso.Value = oEmpleado.fecha_ingreso.Value;
                txt_pass.Hide();
                txt_password.Hide();
                txt_confirm_pass.Hide();
                txt_confirm_password.Hide();
                cmb_role.Enabled = false;
                if (oEmpleado.estado == true)
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
                if (txt_fullname.Text.Trim() == "" || txt_email.Text.Trim() == "" || txt_cedula.Text.Trim() == "" || string.IsNullOrEmpty(cmb_tanda.Text) || string.IsNullOrEmpty(cmb_comision.Text) || dtp_fecha_ingreso.Text == "" || txt_password.Text == "" && this.id == null || txt_confirm_password.Text == "" && this.id == null || !radioButton1.Checked && !radioButton2.Checked)
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                }
                else if (!IsValidDrCedula(txt_cedula.Text.Trim()))
                {
                    MessageBox.Show("La cedula no es valida.");
                }
                else if(this.id == null && txt_password.Text.Trim() != txt_confirm_password.Text.Trim())
                {
                    MessageBox.Show("La contraseña no coincide");
                }
                else
                {
                    if (this.id == null)
                    {
                        if (db.empleados.Count(c => c.email == txt_email.Text) > 0)
                        {
                            MessageBox.Show("El Email ingresado ya ha sido registrado");
                        }
                        else
                        {
                            empleados oEmpleado = new empleados();
                            oEmpleado.full_name = txt_fullname.Text.Trim();
                            oEmpleado.email = txt_email.Text.Trim();
                            oEmpleado.cedula = txt_cedula.Text.Trim();
                            oEmpleado.tanda = cmb_tanda.SelectedItem.ToString();
                            oEmpleado.comision = cmb_comision.SelectedItem.ToString();
                            oEmpleado.fecha_ingreso = dtp_fecha_ingreso.Value;
                            oEmpleado.role_id = int.Parse(cmb_role.SelectedValue.ToString());
                            oEmpleado.pass = txt_password.Text.Trim();

                            if (radioButton1.Checked)
                            {
                                oEmpleado.estado = true;
                            }
                            else if (radioButton2.Checked)
                            {
                                oEmpleado.estado = false;
                            }
                            db.empleados.Add(oEmpleado);
                            db.SaveChanges();
                            this.Close();
                        }
                    }
                    else
                    {
                        oEmpleado = db.empleados.Find(this.id);

                        if (db.empleados.Where(c => c.email != oEmpleado.email).Count(c => c.email == txt_email.Text) > 0)
                        {
                            MessageBox.Show("El Email ingresado ya ha sido registrado.");
                        }
                        else
                        {
                            oEmpleado.full_name = txt_fullname.Text.Trim();
                            oEmpleado.email = txt_email.Text.Trim();
                            oEmpleado.cedula = txt_cedula.Text.Trim();
                            oEmpleado.tanda = cmb_tanda.SelectedItem.ToString();
                            oEmpleado.comision = cmb_comision.SelectedItem.ToString();
                            oEmpleado.fecha_ingreso = dtp_fecha_ingreso.Value;
                            oEmpleado.role_id = int.Parse(cmb_role.SelectedValue.ToString());
                            if (radioButton1.Checked)
                            {
                                oEmpleado.estado = true;
                            }
                            else if (radioButton2.Checked)
                            {
                                oEmpleado.estado = false;
                            }
                            db.Entry(oEmpleado).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                            this.Close();
                        }
                    }
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
