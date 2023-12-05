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
    public partial class SampleView : Form
    {
        public SampleView()
        {
            InitializeComponent();
        }

        private void SampleView_Load(object sender, EventArgs e)
        {

        }

        public virtual void btnAdd_Click(object sender, EventArgs e)
        {

        }

        public virtual void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
        }

        public virtual void txtSearch_Enter(object sender, EventArgs e)
        {

        }

        public virtual void txtSearch_Leave(object sender, EventArgs e)
        {

        }
    }
}
