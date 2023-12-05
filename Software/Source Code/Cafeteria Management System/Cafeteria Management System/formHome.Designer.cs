namespace Cafeteria_Management_System
{
    partial class formHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHome));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblClock = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTotalOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnTotalHold = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTotalPending = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTotalSales = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTotalStaff = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblClock
            // 
            this.lblClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Poppins", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(312, 16);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(418, 141);
            this.lblClock.TabIndex = 0;
            this.lblClock.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 70);
            this.label1.TabIndex = 2;
            this.label1.Text = "COMPLETED";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTotalOrder
            // 
            this.btnTotalOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTotalOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTotalOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTotalOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTotalOrder.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTotalOrder.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalOrder.ForeColor = System.Drawing.Color.White;
            this.btnTotalOrder.Location = new System.Drawing.Point(67, 241);
            this.btnTotalOrder.Name = "btnTotalOrder";
            this.btnTotalOrder.Size = new System.Drawing.Size(241, 98);
            this.btnTotalOrder.TabIndex = 3;
            this.btnTotalOrder.Text = "000";
            this.btnTotalOrder.Click += new System.EventHandler(this.btnTotalOrder_Click);
            // 
            // btnTotalHold
            // 
            this.btnTotalHold.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTotalHold.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTotalHold.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTotalHold.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTotalHold.FillColor = System.Drawing.Color.Crimson;
            this.btnTotalHold.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalHold.ForeColor = System.Drawing.Color.White;
            this.btnTotalHold.Location = new System.Drawing.Point(388, 241);
            this.btnTotalHold.Name = "btnTotalHold";
            this.btnTotalHold.Size = new System.Drawing.Size(241, 98);
            this.btnTotalHold.TabIndex = 5;
            this.btnTotalHold.Text = "000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(404, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 70);
            this.label2.TabIndex = 4;
            this.label2.Text = "ON HOLD";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTotalPending
            // 
            this.btnTotalPending.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTotalPending.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTotalPending.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTotalPending.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTotalPending.FillColor = System.Drawing.Color.DarkGoldenrod;
            this.btnTotalPending.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalPending.ForeColor = System.Drawing.Color.White;
            this.btnTotalPending.Location = new System.Drawing.Point(711, 241);
            this.btnTotalPending.Name = "btnTotalPending";
            this.btnTotalPending.Size = new System.Drawing.Size(241, 98);
            this.btnTotalPending.TabIndex = 7;
            this.btnTotalPending.Text = "000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(728, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 70);
            this.label3.TabIndex = 6;
            this.label3.Text = "PENDING";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTotalSales
            // 
            this.btnTotalSales.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTotalSales.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTotalSales.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTotalSales.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTotalSales.FillColor = System.Drawing.Color.Indigo;
            this.btnTotalSales.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalSales.ForeColor = System.Drawing.Color.White;
            this.btnTotalSales.Location = new System.Drawing.Point(556, 437);
            this.btnTotalSales.Name = "btnTotalSales";
            this.btnTotalSales.Size = new System.Drawing.Size(241, 98);
            this.btnTotalSales.TabIndex = 11;
            this.btnTotalSales.Text = "000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(598, 373);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 70);
            this.label5.TabIndex = 10;
            this.label5.Text = "SALES";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTotalStaff
            // 
            this.btnTotalStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTotalStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTotalStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTotalStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTotalStaff.FillColor = System.Drawing.Color.SlateBlue;
            this.btnTotalStaff.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalStaff.ForeColor = System.Drawing.Color.White;
            this.btnTotalStaff.Location = new System.Drawing.Point(235, 437);
            this.btnTotalStaff.Name = "btnTotalStaff";
            this.btnTotalStaff.Size = new System.Drawing.Size(241, 98);
            this.btnTotalStaff.TabIndex = 9;
            this.btnTotalStaff.Text = "000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(276, 373);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 70);
            this.label6.TabIndex = 8;
            this.label6.Text = "STAFF";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Cafeteria_Management_System.Properties.Resources.loginimgbackadmin1;
            this.ClientSize = new System.Drawing.Size(1025, 636);
            this.Controls.Add(this.btnTotalSales);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTotalStaff);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTotalPending);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTotalHold);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTotalOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblClock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formHome";
            this.Load += new System.EventHandler(this.formHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnTotalOrder;
        private Guna.UI2.WinForms.Guna2Button btnTotalHold;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnTotalPending;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnTotalSales;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnTotalStaff;
        private System.Windows.Forms.Label label6;
    }
}