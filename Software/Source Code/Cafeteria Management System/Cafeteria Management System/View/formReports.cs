using Cafeteria_Management_System.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Cafeteria_Management_System.View
{
    public partial class formReports : Form
    {
        public formReports()
        {
            InitializeComponent();
        }

        static formReports _obj;

        public static formReports Instance
        {
            get { if (_obj == null) { _obj = new formReports(); } return _obj; }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            string qry = @"Select * from products ";

            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            MainClass.con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            MainClass.con.Close();

            formPrint frm = new formPrint();
            reportMenu cr = new reportMenu();
            //cr.SetDatabaseLogon();
            cr.SetDataSource(dt);
            frm.crystalReportViewer2.ReportSource = cr;
            frm.crystalReportViewer2.Refresh();
            frm.Show();
            btnMenu.Checked = false;
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            string qry = @"Select * from staff ";

            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            MainClass.con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            MainClass.con.Close();

            formPrint frm = new formPrint();
            reportStaff cr = new reportStaff();
            //cr.SetDatabaseLogon();
            cr.SetDataSource(dt);
            frm.crystalReportViewer2.ReportSource = cr;
            frm.crystalReportViewer2.Refresh();
            frm.Show();
            btnStaff.Checked = false;
        }

        private formMain frm;
        private formSaleByCategory frm2;

        private void btnSaleCat_Click(object sender, EventArgs e)
        {
            frm = new formMain();
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Opacity = 0.5d;
            frm.BackColor = Color.Black;
            frm.Size = formMain.Instance.Size;
            frm.Location = formMain.Instance.Location;
            frm.ShowInTaskbar = false;

            frm2 = new formSaleByCategory();
            frm2.FormClosed += frm2_FormClosed; // Attach the event handler

            frm.Show();
            frm2.Show();
        }

        private void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // This event is triggered when frm2 is closed
            // Close frm as well
            frm.Close();
            //btnSaleCat.Checked = false;
        }
    }
}