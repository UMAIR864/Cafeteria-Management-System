using Cafeteria_Management_System.View;
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

namespace Cafeteria_Management_System.Reports
{
    public partial class formSaleByCategory : Form
    {
        public formSaleByCategory()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            string qry = @"Select * from tblMain m
                        inner join tblDetails d on m.MainID = d.MainID
                        inner join products p on p.pID = d.proID
                        inner join category c on c.catID = p.CategoryID
                        where m.aDate between @sdate and @edate ";

            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            cmd.Parameters.AddWithValue("@sdate", Convert.ToDateTime(sdate.Value).Date);
            cmd.Parameters.AddWithValue("@edate", Convert.ToDateTime(edate.Value).Date);
            MainClass.con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            MainClass.con.Close();

            formPrint frm = new formPrint();
            reportSaleByCategory cr = new reportSaleByCategory();
            //cr.SetDatabaseLogon();
            cr.SetDataSource(dt);
            frm.crystalReportViewer2.ReportSource = cr;
            frm.crystalReportViewer2.Refresh();
            frm.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
