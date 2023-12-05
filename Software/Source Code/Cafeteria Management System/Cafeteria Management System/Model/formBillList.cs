using Cafeteria_Management_System.Reports;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria_Management_System.Model
{
    public partial class formBillList : SampleAdd
    {
        public formBillList()
        {
            InitializeComponent();
        }
        public int MainID = 0;
        private void formBillList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string qry = "SELECT MainID, TableName, WaiterName, orderType, status, total FROM tblMain WHERE status <> 'Pending' ORDER BY MainID DESC";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvtable);
            lb.Items.Add(dgvWaiter);
            lb.Items.Add(dgvType);
            lb.Items.Add(dgvStatus);
            lb.Items.Add(dgvTotal);

            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }

        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //for serial no

            int count = 0;

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {

                MainID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                this.Close();

            }
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                //Print Bill
                MainID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                string qry = @"Select * from tblMain m inner join 
                        tblDetails d on d.MainID = m.MainID
                        inner join products p on p.PID = d.ProID
                        where m.MainID = "+MainID+"";

                SqlCommand cmd = new SqlCommand(qry,MainClass.con);
                MainClass.con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                MainClass.con.Close();

                formPrint frm = new formPrint();
                reportBill cr = new reportBill();
                //cr.SetDatabaseLogon();
                cr.SetDataSource(dt);
                frm.crystalReportViewer2.ReportSource = cr;
                frm.crystalReportViewer2.Refresh();
                frm.Show();
            }

        }

    }
}
