using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria_Management_System
{
    public partial class formHome : Form
    {
        public formHome()
        {
            InitializeComponent();
        }

        public int tCompleted = 0, tHold = 0, tPending = 0, tStaff = 0;
        public double tTotal = 0;

        public static readonly string con_string = "Server=localhost;Database=dbcafeteria;Trusted_Connection=True;";
        public static SqlConnection con = new SqlConnection(con_string);

        public static string qry = "SELECT COUNT(status) FROM tblMain WHERE status = 'Paid'";
        public static SqlCommand cmd = new SqlCommand(qry, con);

        public static string qry2 = "SELECT COUNT(status) FROM tblMain WHERE status = 'Hold'";
        public static SqlCommand cmd2 = new SqlCommand(qry2, con);

        public static string qry3 = "SELECT COUNT(status) FROM tblMain WHERE status = 'Pending'";
        public static SqlCommand cmd3 = new SqlCommand(qry3, con);

        public static string qry4 = "SELECT COUNT(*) FROM staff";
        public static SqlCommand cmd4 = new SqlCommand(qry4, con);

        public static string qry5 = "SELECT SUM(total) FROM tblMain WHERE CAST(aDate AS DATE) = CAST(GETDATE() AS DATE) and status = 'Paid'";
        public  SqlCommand cmd5 = new SqlCommand(qry5, con);


        private System.Windows.Forms.Timer timer;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("T");
        }

        private void formHome_Load(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start(); // Start the timer

            con.Open();

            tCompleted = (int)cmd.ExecuteScalar();
            tHold = (int)cmd2.ExecuteScalar();
            tPending = (int)cmd3.ExecuteScalar();
            tStaff = (int)cmd4.ExecuteScalar();
            object result = cmd5.ExecuteScalar();

            if (result != DBNull.Value)
            {
                tTotal = (double)result;
            }

            con.Close();

            btnTotalOrder.Text = tCompleted.ToString();
            btnTotalHold.Text = tHold.ToString();
            btnTotalPending.Text = tPending.ToString();
            btnTotalStaff.Text = tStaff.ToString();
            btnTotalSales.Text = tTotal.ToString();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("T");
        }

        private void btnTotalOrder_Click(object sender, EventArgs e)
        {
            //btnTotalOrder.Text = tCompleted.ToString();
        }
    }
}
