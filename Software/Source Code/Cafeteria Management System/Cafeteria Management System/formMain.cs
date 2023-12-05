using Cafeteria_Management_System.Model;
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

namespace Cafeteria_Management_System
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        static formMain _obj;

        public static formMain Instance
        {
            get { if (_obj == null) { _obj = new formMain();  } return _obj; }
        }

        //Control Main Form
        public void AddControls(Form f)
        {
            ControlsPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            ControlsPanel.Controls.Add(f);
            f.Show();
        }

        private void formmainClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void formMain_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Welcome: " + MainClass.USER;
            _obj = this;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AddControls(new formHome());
        }

        private void btnCatagory_Click(object sender, EventArgs e)
        {
            AddControls(new formCategoryView());
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            AddControls(new formTableView());
        }

        private void btsStaff_Click(object sender, EventArgs e)
        {
            AddControls(new formStaffView());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            AddControls(new formProductView());
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            formPOS frm = new formPOS();
            frm.Show();
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            AddControls(new formKitchenView());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            AddControls(new formReports());
        }
    }
}
