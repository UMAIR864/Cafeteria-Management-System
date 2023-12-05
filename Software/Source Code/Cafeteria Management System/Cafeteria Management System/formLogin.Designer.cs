namespace Cafeteria_Management_System
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.passwordBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.msgLogin = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.formLoginClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.formLoginMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblUserLogin = new System.Windows.Forms.Label();
            this.usernameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.loginElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.loginimgBack = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loginIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginimgBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsername.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblUsername.Location = new System.Drawing.Point(51, 301);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 30);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            this.lblUsername.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPassword.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPassword.Location = new System.Drawing.Point(52, 379);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(97, 30);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password";
            // 
            // passwordBox
            // 
            this.passwordBox.AutoRoundedCorners = true;
            this.passwordBox.BackColor = System.Drawing.Color.White;
            this.passwordBox.BorderRadius = 19;
            this.passwordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordBox.DefaultText = "";
            this.passwordBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordBox.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.passwordBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordBox.IconLeft = global::Cafeteria_Management_System.Properties.Resources.passwordicon;
            this.passwordBox.Location = new System.Drawing.Point(56, 411);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '●';
            this.passwordBox.PlaceholderText = "";
            this.passwordBox.SelectedText = "";
            this.passwordBox.Size = new System.Drawing.Size(319, 40);
            this.passwordBox.TabIndex = 2;
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            this.loginButton.AutoRoundedCorners = true;
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.BorderRadius = 19;
            this.loginButton.FillColor = System.Drawing.SystemColors.HotTrack;
            this.loginButton.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.loginButton.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(165, 472);
            this.loginButton.Margin = new System.Windows.Forms.Padding(0);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(108, 40);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // msgLogin
            // 
            this.msgLogin.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msgLogin.Caption = "MYCAFETERIA";
            this.msgLogin.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.msgLogin.Parent = this;
            this.msgLogin.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.msgLogin.Text = null;
            // 
            // formLoginClose
            // 
            this.formLoginClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.formLoginClose.FillColor = System.Drawing.SystemColors.Highlight;
            this.formLoginClose.IconColor = System.Drawing.Color.White;
            this.formLoginClose.Location = new System.Drawing.Point(405, 17);
            this.formLoginClose.Name = "formLoginClose";
            this.formLoginClose.PressedColor = System.Drawing.Color.Red;
            this.formLoginClose.Size = new System.Drawing.Size(35, 35);
            this.formLoginClose.TabIndex = 5;
            this.formLoginClose.Click += new System.EventHandler(this.formLoginClose_Click);
            // 
            // formLoginMinimize
            // 
            this.formLoginMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.formLoginMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.formLoginMinimize.FillColor = System.Drawing.SystemColors.Highlight;
            this.formLoginMinimize.IconColor = System.Drawing.Color.White;
            this.formLoginMinimize.Location = new System.Drawing.Point(361, 17);
            this.formLoginMinimize.Name = "formLoginMinimize";
            this.formLoginMinimize.PressedColor = System.Drawing.Color.DeepSkyBlue;
            this.formLoginMinimize.Size = new System.Drawing.Size(35, 35);
            this.formLoginMinimize.TabIndex = 6;
            this.formLoginMinimize.Click += new System.EventHandler(this.formLoginMinimize_Click);
            // 
            // lblUserLogin
            // 
            this.lblUserLogin.AutoSize = true;
            this.lblUserLogin.BackColor = System.Drawing.Color.White;
            this.lblUserLogin.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLogin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblUserLogin.Location = new System.Drawing.Point(159, 251);
            this.lblUserLogin.Name = "lblUserLogin";
            this.lblUserLogin.Size = new System.Drawing.Size(141, 41);
            this.lblUserLogin.TabIndex = 7;
            this.lblUserLogin.Text = "User Login";
            // 
            // usernameBox
            // 
            this.usernameBox.AutoRoundedCorners = true;
            this.usernameBox.BackColor = System.Drawing.Color.White;
            this.usernameBox.BorderRadius = 19;
            this.usernameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameBox.DefaultText = "";
            this.usernameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameBox.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usernameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameBox.IconLeft = global::Cafeteria_Management_System.Properties.Resources.usernameicon;
            this.usernameBox.Location = new System.Drawing.Point(57, 333);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.PasswordChar = '\0';
            this.usernameBox.PlaceholderText = "";
            this.usernameBox.SelectedText = "";
            this.usernameBox.Size = new System.Drawing.Size(319, 40);
            this.usernameBox.TabIndex = 8;
            this.usernameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usernameBox.TextChanged += new System.EventHandler(this.usernameBox_TextChanged);
            // 
            // loginIcon
            // 
            this.loginIcon.BackColor = System.Drawing.Color.Transparent;
            this.loginIcon.Image = global::Cafeteria_Management_System.Properties.Resources.Logo;
            this.loginIcon.ImageRotate = 0F;
            this.loginIcon.Location = new System.Drawing.Point(89, 113);
            this.loginIcon.Margin = new System.Windows.Forms.Padding(0);
            this.loginIcon.Name = "loginIcon";
            this.loginIcon.Size = new System.Drawing.Size(260, 120);
            this.loginIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginIcon.TabIndex = 4;
            this.loginIcon.TabStop = false;
            this.loginIcon.UseTransparentBackground = true;
            // 
            // loginElipse
            // 
            this.loginElipse.BorderRadius = 10;
            this.loginElipse.TargetControl = this;
            // 
            // loginimgBack
            // 
            this.loginimgBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginimgBack.Image = global::Cafeteria_Management_System.Properties.Resources.loginimgBack;
            this.loginimgBack.ImageRotate = 0F;
            this.loginimgBack.Location = new System.Drawing.Point(0, 0);
            this.loginimgBack.Margin = new System.Windows.Forms.Padding(0);
            this.loginimgBack.Name = "loginimgBack";
            this.loginimgBack.Size = new System.Drawing.Size(450, 600);
            this.loginimgBack.TabIndex = 10;
            this.loginimgBack.TabStop = false;
            // 
            // formLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.lblUserLogin);
            this.Controls.Add(this.formLoginMinimize);
            this.Controls.Add(this.formLoginClose);
            this.Controls.Add(this.loginIcon);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.loginimgBack);
            this.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyCafeteria";
            ((System.ComponentModel.ISupportInitialize)(this.loginIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginimgBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private Guna.UI2.WinForms.Guna2TextBox passwordBox;
        private Guna.UI2.WinForms.Guna2GradientButton loginButton;
        private Guna.UI2.WinForms.Guna2MessageDialog msgLogin;
        private Guna.UI2.WinForms.Guna2PictureBox loginIcon;
        private Guna.UI2.WinForms.Guna2ControlBox formLoginMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox formLoginClose;
        private System.Windows.Forms.Label lblUserLogin;
        private Guna.UI2.WinForms.Guna2TextBox usernameBox;
        private Guna.UI2.WinForms.Guna2Elipse loginElipse;
        private Guna.UI2.WinForms.Guna2PictureBox loginimgBack;
    }
}

