using Cafeteria_Management_System.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using Cafeteria_Management_System;

namespace Cafeteria_Management_System
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            //Database dbcafeteria

            if (MainClass.IsValidUser(usernameBox.Text, passwordBox.Text) == false)
            {
                msgLogin.Show("Invalid Username or Password.");
                return;
            }
            else
            {
                if(MainClass.IsAdmin(usernameBox.Text, passwordBox.Text) == true)
                {
                    formUserView frm = new formUserView();
                    frm.Show();
                }
                else
                {
                    this.Hide();
                    formMain frm = new formMain();
                    frm.Show();
                }
                
            }

        }

        private void formLoginMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void formLoginClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usernameBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
