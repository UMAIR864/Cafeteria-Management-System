namespace Cafeteria_Management_System
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.mainElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.formmainClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.formmainmax = new Guna.UI2.WinForms.Guna2ControlBox();
            this.mainplnLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.panelControls = new Guna.UI2.WinForms.Guna2Panel();
            this.logolabel = new Guna.UI.WinForms.GunaLabel();
            this.formmainmin = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.btnReports = new Guna.UI2.WinForms.Guna2Button();
            this.btnKitchen = new Guna.UI2.WinForms.Guna2Button();
            this.btnPos = new Guna.UI2.WinForms.Guna2Button();
            this.btsStaff = new Guna.UI2.WinForms.Guna2Button();
            this.btnTables = new Guna.UI2.WinForms.Guna2Button();
            this.btnProducts = new Guna.UI2.WinForms.Guna2Button();
            this.btnCatagory = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.frmmaimimgLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ControlsPanel = new System.Windows.Forms.Panel();
            this.mainplnLeft.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmmaimimgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // mainElipse
            // 
            this.mainElipse.BorderRadius = 10;
            this.mainElipse.TargetControl = this;
            // 
            // formmainClose
            // 
            this.formmainClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.formmainClose.CustomClick = true;
            this.formmainClose.FillColor = System.Drawing.SystemColors.Highlight;
            this.formmainClose.IconColor = System.Drawing.Color.White;
            this.formmainClose.Location = new System.Drawing.Point(1147, 12);
            this.formmainClose.Name = "formmainClose";
            this.formmainClose.PressedColor = System.Drawing.Color.Red;
            this.formmainClose.Size = new System.Drawing.Size(35, 35);
            this.formmainClose.TabIndex = 23;
            this.formmainClose.Click += new System.EventHandler(this.formmainClose_Click);
            // 
            // formmainmax
            // 
            this.formmainmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.formmainmax.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.formmainmax.FillColor = System.Drawing.SystemColors.Highlight;
            this.formmainmax.IconColor = System.Drawing.Color.White;
            this.formmainmax.Location = new System.Drawing.Point(1103, 12);
            this.formmainmax.Name = "formmainmax";
            this.formmainmax.PressedColor = System.Drawing.Color.DeepSkyBlue;
            this.formmainmax.Size = new System.Drawing.Size(35, 35);
            this.formmainmax.TabIndex = 25;
            // 
            // mainplnLeft
            // 
            this.mainplnLeft.BackColor = System.Drawing.Color.DodgerBlue;
            this.mainplnLeft.Controls.Add(this.btnReports);
            this.mainplnLeft.Controls.Add(this.panelControls);
            this.mainplnLeft.Controls.Add(this.btnKitchen);
            this.mainplnLeft.Controls.Add(this.btnPos);
            this.mainplnLeft.Controls.Add(this.btsStaff);
            this.mainplnLeft.Controls.Add(this.btnTables);
            this.mainplnLeft.Controls.Add(this.btnProducts);
            this.mainplnLeft.Controls.Add(this.btnCatagory);
            this.mainplnLeft.Controls.Add(this.btnHome);
            this.mainplnLeft.Controls.Add(this.logolabel);
            this.mainplnLeft.Controls.Add(this.frmmaimimgLogo);
            this.mainplnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainplnLeft.Location = new System.Drawing.Point(0, 0);
            this.mainplnLeft.Name = "mainplnLeft";
            this.mainplnLeft.Size = new System.Drawing.Size(175, 700);
            this.mainplnLeft.TabIndex = 26;
            // 
            // panelControls
            // 
            this.panelControls.Location = new System.Drawing.Point(175, -1);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(900, 600);
            this.panelControls.TabIndex = 29;
            // 
            // logolabel
            // 
            this.logolabel.AutoSize = true;
            this.logolabel.BackColor = System.Drawing.Color.Transparent;
            this.logolabel.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logolabel.ForeColor = System.Drawing.Color.White;
            this.logolabel.Location = new System.Drawing.Point(30, 76);
            this.logolabel.Name = "logolabel";
            this.logolabel.Size = new System.Drawing.Size(128, 32);
            this.logolabel.TabIndex = 30;
            this.logolabel.Text = "MyCafeteria";
            this.logolabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formmainmin
            // 
            this.formmainmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.formmainmin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.formmainmin.FillColor = System.Drawing.SystemColors.Highlight;
            this.formmainmin.IconColor = System.Drawing.Color.White;
            this.formmainmin.Location = new System.Drawing.Point(884, 12);
            this.formmainmin.Name = "formmainmin";
            this.formmainmin.PressedColor = System.Drawing.Color.DeepSkyBlue;
            this.formmainmin.Size = new System.Drawing.Size(35, 35);
            this.formmainmin.TabIndex = 29;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(26, 21);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(64, 30);
            this.lblUser.TabIndex = 29;
            this.lblUser.Text = "label1";
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.lblUser);
            this.panelTop.Controls.Add(this.formmainmin);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(175, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1025, 62);
            this.panelTop.TabIndex = 28;
            // 
            // btnReports
            // 
            this.btnReports.AutoRoundedCorners = true;
            this.btnReports.BorderRadius = 21;
            this.btnReports.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnReports.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnReports.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnReports.CheckedState.Image = global::Cafeteria_Management_System.Properties.Resources.Bill_List;
            this.btnReports.CustomizableEdges.BottomRight = false;
            this.btnReports.CustomizableEdges.TopRight = false;
            this.btnReports.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReports.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReports.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReports.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnReports.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnReports.Image = global::Cafeteria_Management_System.Properties.Resources.Bill_List_chk;
            this.btnReports.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReports.ImageSize = new System.Drawing.Size(25, 25);
            this.btnReports.Location = new System.Drawing.Point(13, 521);
            this.btnReports.Margin = new System.Windows.Forms.Padding(0);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(162, 45);
            this.btnReports.TabIndex = 38;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReports.TextOffset = new System.Drawing.Point(-5, 0);
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnKitchen
            // 
            this.btnKitchen.AutoRoundedCorners = true;
            this.btnKitchen.BorderRadius = 21;
            this.btnKitchen.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnKitchen.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnKitchen.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnKitchen.CheckedState.Image = global::Cafeteria_Management_System.Properties.Resources.kitchenIcon_Chk;
            this.btnKitchen.CustomizableEdges.BottomRight = false;
            this.btnKitchen.CustomizableEdges.TopRight = false;
            this.btnKitchen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKitchen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKitchen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKitchen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKitchen.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnKitchen.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKitchen.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnKitchen.Image = global::Cafeteria_Management_System.Properties.Resources.kitchenIcon;
            this.btnKitchen.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKitchen.ImageSize = new System.Drawing.Size(25, 25);
            this.btnKitchen.Location = new System.Drawing.Point(14, 465);
            this.btnKitchen.Margin = new System.Windows.Forms.Padding(0);
            this.btnKitchen.Name = "btnKitchen";
            this.btnKitchen.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnKitchen.Size = new System.Drawing.Size(162, 45);
            this.btnKitchen.TabIndex = 36;
            this.btnKitchen.Text = "Kitchen";
            this.btnKitchen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKitchen.TextOffset = new System.Drawing.Point(-5, 0);
            this.btnKitchen.Click += new System.EventHandler(this.btnKitchen_Click);
            // 
            // btnPos
            // 
            this.btnPos.AutoRoundedCorners = true;
            this.btnPos.BorderRadius = 21;
            this.btnPos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPos.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnPos.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnPos.CheckedState.Image = global::Cafeteria_Management_System.Properties.Resources.posIcon_Chk;
            this.btnPos.CustomizableEdges.BottomRight = false;
            this.btnPos.CustomizableEdges.TopRight = false;
            this.btnPos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPos.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnPos.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPos.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPos.Image = global::Cafeteria_Management_System.Properties.Resources.posIcon;
            this.btnPos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPos.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPos.Location = new System.Drawing.Point(14, 407);
            this.btnPos.Margin = new System.Windows.Forms.Padding(0);
            this.btnPos.Name = "btnPos";
            this.btnPos.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnPos.Size = new System.Drawing.Size(162, 45);
            this.btnPos.TabIndex = 35;
            this.btnPos.Text = "POS";
            this.btnPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPos.TextOffset = new System.Drawing.Point(-5, 0);
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            // 
            // btsStaff
            // 
            this.btsStaff.AutoRoundedCorners = true;
            this.btsStaff.BorderRadius = 21;
            this.btsStaff.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btsStaff.CheckedState.FillColor = System.Drawing.Color.White;
            this.btsStaff.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btsStaff.CheckedState.Image = global::Cafeteria_Management_System.Properties.Resources.staffIcon_Chk;
            this.btsStaff.CustomizableEdges.BottomRight = false;
            this.btsStaff.CustomizableEdges.TopRight = false;
            this.btsStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btsStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btsStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btsStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btsStaff.FillColor = System.Drawing.Color.DodgerBlue;
            this.btsStaff.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsStaff.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btsStaff.Image = global::Cafeteria_Management_System.Properties.Resources.staffIcon;
            this.btsStaff.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btsStaff.ImageSize = new System.Drawing.Size(25, 25);
            this.btsStaff.Location = new System.Drawing.Point(14, 350);
            this.btsStaff.Margin = new System.Windows.Forms.Padding(0);
            this.btsStaff.Name = "btsStaff";
            this.btsStaff.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btsStaff.Size = new System.Drawing.Size(162, 45);
            this.btsStaff.TabIndex = 34;
            this.btsStaff.Text = "Staff";
            this.btsStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btsStaff.TextOffset = new System.Drawing.Point(-5, 0);
            this.btsStaff.Click += new System.EventHandler(this.btsStaff_Click);
            // 
            // btnTables
            // 
            this.btnTables.AutoRoundedCorners = true;
            this.btnTables.BorderRadius = 21;
            this.btnTables.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTables.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnTables.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnTables.CheckedState.Image = global::Cafeteria_Management_System.Properties.Resources.tabelsIcon_Chk;
            this.btnTables.CustomizableEdges.BottomRight = false;
            this.btnTables.CustomizableEdges.TopRight = false;
            this.btnTables.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTables.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTables.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTables.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTables.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnTables.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTables.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnTables.Image = global::Cafeteria_Management_System.Properties.Resources.tabelsIcon;
            this.btnTables.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTables.ImageSize = new System.Drawing.Size(25, 25);
            this.btnTables.Location = new System.Drawing.Point(14, 292);
            this.btnTables.Margin = new System.Windows.Forms.Padding(0);
            this.btnTables.Name = "btnTables";
            this.btnTables.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnTables.Size = new System.Drawing.Size(162, 45);
            this.btnTables.TabIndex = 33;
            this.btnTables.Text = "Tables";
            this.btnTables.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTables.TextOffset = new System.Drawing.Point(-5, 0);
            this.btnTables.Click += new System.EventHandler(this.btnTables_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.AutoRoundedCorners = true;
            this.btnProducts.BorderRadius = 21;
            this.btnProducts.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnProducts.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnProducts.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnProducts.CheckedState.Image = global::Cafeteria_Management_System.Properties.Resources.productsIcon_Chk;
            this.btnProducts.CustomizableEdges.BottomRight = false;
            this.btnProducts.CustomizableEdges.TopRight = false;
            this.btnProducts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProducts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProducts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProducts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProducts.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnProducts.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnProducts.Image = global::Cafeteria_Management_System.Properties.Resources.productsIcon;
            this.btnProducts.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProducts.ImageSize = new System.Drawing.Size(25, 25);
            this.btnProducts.Location = new System.Drawing.Point(14, 234);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(0);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(162, 45);
            this.btnProducts.TabIndex = 32;
            this.btnProducts.Text = "Products";
            this.btnProducts.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProducts.TextOffset = new System.Drawing.Point(-5, 0);
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnCatagory
            // 
            this.btnCatagory.AutoRoundedCorners = true;
            this.btnCatagory.BorderRadius = 21;
            this.btnCatagory.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCatagory.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCatagory.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCatagory.CheckedState.Image = global::Cafeteria_Management_System.Properties.Resources.catagoryIcon_Chk;
            this.btnCatagory.CustomizableEdges.BottomRight = false;
            this.btnCatagory.CustomizableEdges.TopRight = false;
            this.btnCatagory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCatagory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCatagory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCatagory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCatagory.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnCatagory.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatagory.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCatagory.Image = global::Cafeteria_Management_System.Properties.Resources.catagoryIcon;
            this.btnCatagory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCatagory.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCatagory.Location = new System.Drawing.Point(14, 177);
            this.btnCatagory.Margin = new System.Windows.Forms.Padding(0);
            this.btnCatagory.Name = "btnCatagory";
            this.btnCatagory.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnCatagory.Size = new System.Drawing.Size(162, 45);
            this.btnCatagory.TabIndex = 31;
            this.btnCatagory.Text = "Catagories";
            this.btnCatagory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCatagory.TextOffset = new System.Drawing.Point(-5, 0);
            this.btnCatagory.Click += new System.EventHandler(this.btnCatagory_Click);
            // 
            // btnHome
            // 
            this.btnHome.AutoRoundedCorners = true;
            this.btnHome.BorderRadius = 21;
            this.btnHome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHome.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnHome.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnHome.CheckedState.Image = global::Cafeteria_Management_System.Properties.Resources.homeIcon_Chk;
            this.btnHome.CustomizableEdges.BottomRight = false;
            this.btnHome.CustomizableEdges.TopRight = false;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnHome.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnHome.Image = global::Cafeteria_Management_System.Properties.Resources.homeIcon;
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.ImageSize = new System.Drawing.Size(25, 25);
            this.btnHome.Location = new System.Drawing.Point(14, 119);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(162, 45);
            this.btnHome.TabIndex = 29;
            this.btnHome.Text = "Dashboard";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.TextOffset = new System.Drawing.Point(-5, 0);
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmmaimimgLogo
            // 
            this.frmmaimimgLogo.Image = global::Cafeteria_Management_System.Properties.Resources.ICON;
            this.frmmaimimgLogo.ImageRotate = 0F;
            this.frmmaimimgLogo.Location = new System.Drawing.Point(46, 6);
            this.frmmaimimgLogo.Name = "frmmaimimgLogo";
            this.frmmaimimgLogo.Size = new System.Drawing.Size(85, 69);
            this.frmmaimimgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frmmaimimgLogo.TabIndex = 29;
            this.frmmaimimgLogo.TabStop = false;
            // 
            // ControlsPanel
            // 
            this.ControlsPanel.BackgroundImage = global::Cafeteria_Management_System.Properties.Resources.Background_formMain;
            this.ControlsPanel.Location = new System.Drawing.Point(175, 68);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(1025, 630);
            this.ControlsPanel.TabIndex = 29;
            // 
            // formMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.formmainmax);
            this.Controls.Add(this.formmainClose);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.mainplnLeft);
            this.Controls.Add(this.ControlsPanel);
            this.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyCafeteria";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.mainplnLeft.ResumeLayout(false);
            this.mainplnLeft.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmmaimimgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse mainElipse;
        private Guna.UI2.WinForms.Guna2ControlBox formmainClose;
        private Guna.UI2.WinForms.Guna2ControlBox formmainmax;
        private Guna.UI2.WinForms.Guna2Panel mainplnLeft;
        private Guna.UI2.WinForms.Guna2PictureBox frmmaimimgLogo;
        private Guna.UI.WinForms.GunaLabel logolabel;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btsStaff;
        private Guna.UI2.WinForms.Guna2Button btnTables;
        private Guna.UI2.WinForms.Guna2Button btnProducts;
        private Guna.UI2.WinForms.Guna2Button btnCatagory;
        private Guna.UI2.WinForms.Guna2Button btnKitchen;
        private Guna.UI2.WinForms.Guna2Button btnPos;
        private Guna.UI2.WinForms.Guna2Panel panelControls;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private System.Windows.Forms.Label lblUser;
        private Guna.UI2.WinForms.Guna2ControlBox formmainmin;
        private System.Windows.Forms.Panel ControlsPanel;
        private Guna.UI2.WinForms.Guna2Button btnReports;
    }
}