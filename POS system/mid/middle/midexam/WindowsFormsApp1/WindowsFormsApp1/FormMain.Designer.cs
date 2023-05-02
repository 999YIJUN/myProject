namespace WindowsFormsApp1
{
    partial class FormMain
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
            this.lblEmployee = new System.Windows.Forms.Label();
            this.btnMenu = new Guna.UI2.WinForms.Guna2Button();
            this.btnMemberInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnProInfo = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSLogin = new Guna.UI2.WinForms.Guna2Button();
            this.btnStaff = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnOUT = new System.Windows.Forms.Button();
            this.cbexit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(12, 9);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(118, 24);
            this.lblEmployee.TabIndex = 2;
            this.lblEmployee.Text = "EMPLOYEE";
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BorderColor = System.Drawing.Color.Transparent;
            this.btnMenu.BorderRadius = 25;
            this.btnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(100)))), ((int)(((byte)(85)))));
            this.btnMenu.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.IndicateFocus = true;
            this.btnMenu.Location = new System.Drawing.Point(16, 65);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnMenu.Size = new System.Drawing.Size(220, 120);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "POS";
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnMemberInfo
            // 
            this.btnMemberInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMemberInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnMemberInfo.BorderColor = System.Drawing.Color.Transparent;
            this.btnMemberInfo.BorderRadius = 25;
            this.btnMemberInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMemberInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMemberInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMemberInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMemberInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(100)))), ((int)(((byte)(85)))));
            this.btnMemberInfo.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold);
            this.btnMemberInfo.ForeColor = System.Drawing.Color.White;
            this.btnMemberInfo.IndicateFocus = true;
            this.btnMemberInfo.Location = new System.Drawing.Point(254, 65);
            this.btnMemberInfo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnMemberInfo.Name = "btnMemberInfo";
            this.btnMemberInfo.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnMemberInfo.Size = new System.Drawing.Size(220, 120);
            this.btnMemberInfo.TabIndex = 3;
            this.btnMemberInfo.Text = "MEMBER MANAGEMENT";
            this.btnMemberInfo.Click += new System.EventHandler(this.btnMenberInfo_Click);
            // 
            // btnProInfo
            // 
            this.btnProInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnProInfo.BorderColor = System.Drawing.Color.Transparent;
            this.btnProInfo.BorderRadius = 25;
            this.btnProInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(100)))), ((int)(((byte)(85)))));
            this.btnProInfo.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold);
            this.btnProInfo.ForeColor = System.Drawing.Color.White;
            this.btnProInfo.IndicateFocus = true;
            this.btnProInfo.Location = new System.Drawing.Point(254, 204);
            this.btnProInfo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnProInfo.Name = "btnProInfo";
            this.btnProInfo.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnProInfo.Size = new System.Drawing.Size(220, 120);
            this.btnProInfo.TabIndex = 3;
            this.btnProInfo.Text = "PRODUCT MANAGEMENT";
            this.btnProInfo.Click += new System.EventHandler(this.btnProInfo_Click);
            // 
            // BtnSLogin
            // 
            this.BtnSLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSLogin.BackColor = System.Drawing.Color.Transparent;
            this.BtnSLogin.BorderColor = System.Drawing.Color.Transparent;
            this.BtnSLogin.BorderRadius = 25;
            this.BtnSLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(53)))), ((int)(((byte)(44)))));
            this.BtnSLogin.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold);
            this.BtnSLogin.ForeColor = System.Drawing.Color.White;
            this.BtnSLogin.IndicateFocus = true;
            this.BtnSLogin.Location = new System.Drawing.Point(501, 65);
            this.BtnSLogin.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.BtnSLogin.Name = "BtnSLogin";
            this.BtnSLogin.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.BtnSLogin.Size = new System.Drawing.Size(120, 259);
            this.BtnSLogin.TabIndex = 3;
            this.BtnSLogin.Text = "LOGIN";
            this.BtnSLogin.Click += new System.EventHandler(this.BtnSLogin_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStaff.BackColor = System.Drawing.Color.Transparent;
            this.btnStaff.BorderColor = System.Drawing.Color.Transparent;
            this.btnStaff.BorderRadius = 25;
            this.btnStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStaff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(100)))), ((int)(((byte)(85)))));
            this.btnStaff.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold);
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.IndicateFocus = true;
            this.btnStaff.Location = new System.Drawing.Point(16, 204);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnStaff.Size = new System.Drawing.Size(222, 120);
            this.btnStaff.TabIndex = 3;
            this.btnStaff.Text = "STAFF MANAGEMENT";
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnOUT);
            this.guna2Panel1.Controls.Add(this.cbexit);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(643, 48);
            this.guna2Panel1.TabIndex = 4;
            // 
            // btnOUT
            // 
            this.btnOUT.BackColor = System.Drawing.Color.Black;
            this.btnOUT.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOUT.ForeColor = System.Drawing.Color.LightGray;
            this.btnOUT.Location = new System.Drawing.Point(519, 9);
            this.btnOUT.Name = "btnOUT";
            this.btnOUT.Size = new System.Drawing.Size(57, 29);
            this.btnOUT.TabIndex = 1;
            this.btnOUT.Text = "out";
            this.btnOUT.UseVisualStyleBackColor = false;
            this.btnOUT.Click += new System.EventHandler(this.btnOUT_Click);
            // 
            // cbexit
            // 
            this.cbexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbexit.FillColor = System.Drawing.Color.Black;
            this.cbexit.IconColor = System.Drawing.Color.White;
            this.cbexit.Location = new System.Drawing.Point(586, 9);
            this.cbexit.Name = "cbexit";
            this.cbexit.Size = new System.Drawing.Size(45, 29);
            this.cbexit.TabIndex = 0;
            this.cbexit.Click += new System.EventHandler(this.cbexit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(200)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(643, 345);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.BtnSLogin);
            this.Controls.Add(this.btnProInfo);
            this.Controls.Add(this.btnMemberInfo);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEmployee;
        private Guna.UI2.WinForms.Guna2Button btnMenu;
        private Guna.UI2.WinForms.Guna2Button btnMemberInfo;
        private Guna.UI2.WinForms.Guna2Button btnProInfo;
        private Guna.UI2.WinForms.Guna2Button BtnSLogin;
        private Guna.UI2.WinForms.Guna2Button btnStaff;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox cbexit;
        private System.Windows.Forms.Button btnOUT;
    }
}