using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria_Management_System.Model
{
    public partial class formUserAdd : SampleAdd
    {
        public formUserAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        private void formUserAdd_Load(object sender, EventArgs e)
        {

        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0) //Insert
            {
                qry = "Insert into users Values(@Name ,@pass, @role, @phone)";
            }
            else //Update
            {
                qry = "Update users Set username = @Name,upass = @pass, userRole = @role, uphone = @phone  where userID = @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);
            ht.Add("@pass", txtPass.Text);
            ht.Add("@phone", txtPhone.Text);
            ht.Add("@role", cbRole.Text);

            if (MainClass.SQl(qry, ht) > 0)
            {
                MessageBox.Show("Saved Successfully.");
                id = 0;
                txtName.Text = "";
                txtPass.Text = "";
                txtPhone.Text = "";
                cbRole.SelectedIndex = -1;
                txtName.Focus();
            }
        }

    }
}
