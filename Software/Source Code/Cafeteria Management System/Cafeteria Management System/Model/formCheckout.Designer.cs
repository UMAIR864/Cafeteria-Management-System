namespace Cafeteria_Management_System.Model
{
    partial class formCheckout
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
            this.formLoginMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.formLoginClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txtBillAmount = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReceived = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChange = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.boxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(143, 42);
            this.label1.Text = "Check Out";
            // 
            // boxImage
            // 
            this.boxImage.BackColor = System.Drawing.Color.Transparent;
            this.boxImage.Image = global::Cafeteria_Management_System.Properties.Resources.Bill_List_chk;
            this.boxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(321, 247);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(497, 247);
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            // 
            // formLoginMinimize
            // 
            this.formLoginMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.formLoginMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.formLoginMinimize.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.formLoginMinimize.IconColor = System.Drawing.Color.Black;
            this.formLoginMinimize.Location = new System.Drawing.Point(498, 31);
            this.formLoginMinimize.Name = "formLoginMinimize";
            this.formLoginMinimize.PressedColor = System.Drawing.Color.DeepSkyBlue;
            this.formLoginMinimize.Size = new System.Drawing.Size(35, 35);
            this.formLoginMinimize.TabIndex = 18;
            // 
            // formLoginClose
            // 
            this.formLoginClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.formLoginClose.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.formLoginClose.IconColor = System.Drawing.Color.Black;
            this.formLoginClose.Location = new System.Drawing.Point(542, 31);
            this.formLoginClose.Name = "formLoginClose";
            this.formLoginClose.PressedColor = System.Drawing.Color.Red;
            this.formLoginClose.Size = new System.Drawing.Size(35, 35);
            this.formLoginClose.TabIndex = 17;
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.BaseColor = System.Drawing.Color.White;
            this.txtBillAmount.BorderColor = System.Drawing.Color.Silver;
            this.txtBillAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBillAmount.Enabled = false;
            this.txtBillAmount.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBillAmount.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBillAmount.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBillAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBillAmount.Location = new System.Drawing.Point(21, 160);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.PasswordChar = '\0';
            this.txtBillAmount.SelectedText = "";
            this.txtBillAmount.Size = new System.Drawing.Size(271, 36);
            this.txtBillAmount.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "Bill Amount";
            // 
            // txtReceived
            // 
            this.txtReceived.BaseColor = System.Drawing.Color.White;
            this.txtReceived.BorderColor = System.Drawing.Color.Silver;
            this.txtReceived.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReceived.FocusedBaseColor = System.Drawing.Color.White;
            this.txtReceived.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtReceived.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtReceived.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReceived.Location = new System.Drawing.Point(321, 160);
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.PasswordChar = '\0';
            this.txtReceived.SelectedText = "";
            this.txtReceived.Size = new System.Drawing.Size(271, 36);
            this.txtReceived.TabIndex = 21;
            this.txtReceived.TextChanged += new System.EventHandler(this.txtReceived_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 26);
            this.label3.TabIndex = 22;
            this.label3.Text = "Payment Received";
            // 
            // txtChange
            // 
            this.txtChange.BaseColor = System.Drawing.Color.White;
            this.txtChange.BorderColor = System.Drawing.Color.Silver;
            this.txtChange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChange.Enabled = false;
            this.txtChange.FocusedBaseColor = System.Drawing.Color.White;
            this.txtChange.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtChange.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtChange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtChange.Location = new System.Drawing.Point(21, 247);
            this.txtChange.Name = "txtChange";
            this.txtChange.PasswordChar = '\0';
            this.txtChange.SelectedText = "";
            this.txtChange.Size = new System.Drawing.Size(271, 36);
            this.txtChange.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 26);
            this.label4.TabIndex = 24;
            this.label4.Text = "Change";
            // 
            // formCheckout
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(610, 363);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReceived);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBillAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formLoginMinimize);
            this.Controls.Add(this.formLoginClose);
            this.Name = "formCheckout";
            this.Text = "formCheckout";
            this.Load += new System.EventHandler(this.formCheckout_Load);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.formLoginClose, 0);
            this.Controls.SetChildIndex(this.formLoginMinimize, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtBillAmount, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtReceived, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtChange, 0);
            ((System.ComponentModel.ISupportInitialize)(this.boxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox formLoginMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox formLoginClose;
        public Guna.UI.WinForms.GunaTextBox txtBillAmount;
        private System.Windows.Forms.Label label2;
        public Guna.UI.WinForms.GunaTextBox txtReceived;
        private System.Windows.Forms.Label label3;
        public Guna.UI.WinForms.GunaTextBox txtChange;
        private System.Windows.Forms.Label label4;
    }
}