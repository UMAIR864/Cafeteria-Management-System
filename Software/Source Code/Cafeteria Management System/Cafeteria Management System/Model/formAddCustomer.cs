using System;
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
    public partial class formAddCustomer : Form
    {
        public formAddCustomer()
        {
            InitializeComponent();
        }

        public string orderType = "";
        public int raiderID = 0;
        public string cusName = "";
        public string cusPhone = "";
        public int mainID = 0; 

        private void formAddCustomer_Load(object sender, EventArgs e)
        {
            if(orderType == "Take Away")
            {
                lblRaider.Visible = false;
                cbRaider.Visible = false;
                txtAddress.Visible = false;
                label4.Visible = false;
            }

            string qry = "Select staffID 'id', sName 'name' from staff where sRole = 'Rider'";
            MainClass.CBFill(qry, cbRaider);

            if(mainID >0)
            {
                cbRaider.SelectedValue = raiderID;
            }
        }

        private void cbRaider_SelectedIndexChanged(object sender, EventArgs e)
        {
            raiderID = Convert.ToInt32(cbRaider.SelectedValue);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
