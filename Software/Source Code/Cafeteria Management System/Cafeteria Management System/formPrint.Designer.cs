namespace Cafeteria_Management_System
{
    partial class formPrint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMax = new Guna.UI2.WinForms.Guna2ControlBox();
            this.formmainClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.formmainmin = new Guna.UI2.WinForms.Guna2ControlBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMax);
            this.panel1.Controls.Add(this.formmainClose);
            this.panel1.Controls.Add(this.formmainmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 56);
            this.panel1.TabIndex = 0;
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.btnMax.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnMax.IconColor = System.Drawing.Color.White;
            this.btnMax.Location = new System.Drawing.Point(927, 12);
            this.btnMax.Name = "btnMax";
            this.btnMax.PressedColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMax.Size = new System.Drawing.Size(35, 35);
            this.btnMax.TabIndex = 31;
            // 
            // formmainClose
            // 
            this.formmainClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.formmainClose.FillColor = System.Drawing.SystemColors.Highlight;
            this.formmainClose.IconColor = System.Drawing.Color.White;
            this.formmainClose.Location = new System.Drawing.Point(971, 12);
            this.formmainClose.Name = "formmainClose";
            this.formmainClose.PressedColor = System.Drawing.Color.Red;
            this.formmainClose.Size = new System.Drawing.Size(35, 35);
            this.formmainClose.TabIndex = 30;
            // 
            // formmainmin
            // 
            this.formmainmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.formmainmin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.formmainmin.FillColor = System.Drawing.SystemColors.Highlight;
            this.formmainmin.IconColor = System.Drawing.Color.White;
            this.formmainmin.Location = new System.Drawing.Point(883, 12);
            this.formmainmin.Name = "formmainmin";
            this.formmainmin.PressedColor = System.Drawing.Color.DeepSkyBlue;
            this.formmainmin.Size = new System.Drawing.Size(35, 35);
            this.formmainmin.TabIndex = 32;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 56);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1025, 574);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = -1;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer2.Location = new System.Drawing.Point(0, 56);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.Size = new System.Drawing.Size(1025, 574);
            this.crystalReportViewer2.TabIndex = 2;
            // 
            // formPrint
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1025, 630);
            this.Controls.Add(this.crystalReportViewer2);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formPrint";
            this.Load += new System.EventHandler(this.formPrint_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Guna.UI2.WinForms.Guna2ControlBox btnMax;
        private Guna.UI2.WinForms.Guna2ControlBox formmainClose;
        private Guna.UI2.WinForms.Guna2ControlBox formmainmin;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
    }
}