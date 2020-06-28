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

namespace Rentcar
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txt_password.PasswordChar = char.Parse("*");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_email.Text.Trim() == "" && txt_password.Text.Trim() == "")
            {
                MessageBox.Show("Todos ambos campos son obligatorios.");
            }
            else if (txt_email.Text.Trim() == "")
            {
                MessageBox.Show("El campo email es obligatorio.");
            }
            else if (txt_password.Text.Trim() == "")
            {
                MessageBox.Show("El campo contraseña es obligatorio.");
            }
            else
            {
                using (RentcarEntities db = new RentcarEntities())
                {
                    var user = db.empleados
                          .Where(c => c.email == txt_email.Text)
                          .Where(c => c.pass == txt_password.Text)
                          .FirstOrDefault();

                    if (user == null)
                    {
                        MessageBox.Show("Estas credenciales no coinciden con nuestros registros.");
                    }
                    else
                    {
                        Data.LoginInfo.user = user;

                        if (user.role_id == 1)
                        {
                            this.Hide();
                            Views.Home_admin c = new Views.Home_admin();
                            c.ShowDialog();
                            this.Close();
                        }
                        else if(user.role_id == 2)
                        {
                            this.Hide();
                            Home c = new Home();
                            c.ShowDialog();
                            this.Close();
                        }
                    }
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
