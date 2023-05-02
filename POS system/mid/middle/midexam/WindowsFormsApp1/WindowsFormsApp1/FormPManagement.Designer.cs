namespace WindowsFormsApp1
{
    partial class FormPManagement
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
            this.btnPicMode = new Guna.UI2.WinForms.Guna2Button();
            this.btnListMode = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewP = new Guna.UI2.WinForms.Guna2Button();
            this.panelUse = new Guna.UI2.WinForms.Guna2Panel();
            this.lvProductDisplay = new System.Windows.Forms.ListView();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.ilProductPic = new System.Windows.Forms.ImageList(this.components);
            this.panelUse.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPicMode
            // 
            this.btnPicMode.AutoRoundedCorners = true;
            this.btnPicMode.BorderRadius = 21;
            this.btnPicMode.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPicMode.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPicMode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPicMode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPicMode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(160)))), ((int)(((byte)(151)))));
            this.btnPicMode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPicMode.ForeColor = System.Drawing.Color.White;
            this.btnPicMode.Location = new System.Drawing.Point(443, 28);
            this.btnPicMode.Name = "btnPicMode";
            this.btnPicMode.Size = new System.Drawing.Size(180, 45);
            this.btnPicMode.TabIndex = 0;
            this.btnPicMode.Text = "PICTURE MODE";
            this.btnPicMode.Click += new System.EventHandler(this.btnPicMode_Click);
            // 
            // btnListMode
            // 
            this.btnListMode.AutoRoundedCorners = true;
            this.btnListMode.BorderRadius = 21;
            this.btnListMode.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnListMode.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnListMode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnListMode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnListMode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(160)))), ((int)(((byte)(151)))));
            this.btnListMode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnListMode.ForeColor = System.Drawing.Color.White;
            this.btnListMode.Location = new System.Drawing.Point(228, 28);
            this.btnListMode.Name = "btnListMode";
            this.btnListMode.Size = new System.Drawing.Size(180, 45);
            this.btnListMode.TabIndex = 0;
            this.btnListMode.Text = "LIST MODE";
            this.btnListMode.Click += new System.EventHandler(this.btnListMode_Click);
            // 
            // btnAddNewP
            // 
            this.btnAddNewP.AutoRoundedCorners = true;
            this.btnAddNewP.BorderRadius = 21;
            this.btnAddNewP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(160)))), ((int)(((byte)(151)))));
            this.btnAddNewP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewP.ForeColor = System.Drawing.Color.White;
            this.btnAddNewP.Location = new System.Drawing.Point(18, 28);
            this.btnAddNewP.Name = "btnAddNewP";
            this.btnAddNewP.Size = new System.Drawing.Size(180, 45);
            this.btnAddNewP.TabIndex = 0;
            this.btnAddNewP.Text = "ADD NEW PRODUCT";
            this.btnAddNewP.Click += new System.EventHandler(this.btnAddNewP_Click);
            // 
            // panelUse
            // 
            this.panelUse.Controls.Add(this.lvProductDisplay);
            this.panelUse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUse.Location = new System.Drawing.Point(0, -22);
            this.panelUse.Name = "panelUse";
            this.panelUse.Size = new System.Drawing.Size(646, 552);
            this.panelUse.TabIndex = 0;
            // 
            // lvProductDisplay
            // 
            this.lvProductDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvProductDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(160)))), ((int)(((byte)(151)))));
            this.lvProductDisplay.HideSelection = false;
            this.lvProductDisplay.Location = new System.Drawing.Point(0, 128);
            this.lvProductDisplay.Name = "lvProductDisplay";
            this.lvProductDisplay.Size = new System.Drawing.Size(648, 424);
            this.lvProductDisplay.TabIndex = 0;
            this.lvProductDisplay.UseCompatibleStateImageBehavior = false;
            this.lvProductDisplay.ItemActivate += new System.EventHandler(this.lvProductDisplay_ItemActivate);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnPicMode);
            this.panelTop.Controls.Add(this.btnAddNewP);
            this.panelTop.Controls.Add(this.btnListMode);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(646, 100);
            this.panelTop.TabIndex = 0;
            // 
            // ilProductPic
            // 
            this.ilProductPic.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilProductPic.ImageSize = new System.Drawing.Size(256, 256);
            this.ilProductPic.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormPManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(67)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(646, 530);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelUse);
            this.Name = "FormPManagement";
            this.Text = "FormPManagement";
            this.Load += new System.EventHandler(this.FormPManagement_Load);
            this.panelUse.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelUse;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private System.Windows.Forms.ListView lvProductDisplay;
        private System.Windows.Forms.ImageList ilProductPic;
        private Guna.UI2.WinForms.Guna2Button btnAddNewP;
        private Guna.UI2.WinForms.Guna2Button btnPicMode;
        private Guna.UI2.WinForms.Guna2Button btnListMode;
    }
}