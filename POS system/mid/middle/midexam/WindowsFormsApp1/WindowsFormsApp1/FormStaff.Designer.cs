namespace WindowsFormsApp1
{
    partial class FormStaff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSInfo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvSenq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvJtitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSpassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvDel = new System.Windows.Forms.DataGridViewImageColumn();
            this.messageDel = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSInfo)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSInfo
            // 
            this.dgvSInfo.AllowUserToAddRows = false;
            this.dgvSInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvSInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(200)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(84)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(84)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSInfo.ColumnHeadersHeight = 40;
            this.dgvSInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSenq,
            this.dgvSID,
            this.dgvJtitle,
            this.dgvSName,
            this.dgvSContact,
            this.dgvSpassword,
            this.dgvEdit,
            this.dgvDel});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSInfo.Location = new System.Drawing.Point(0, 79);
            this.dgvSInfo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dgvSInfo.Name = "dgvSInfo";
            this.dgvSInfo.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(84)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(84)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSInfo.RowHeadersVisible = false;
            this.dgvSInfo.RowHeadersWidth = 82;
            this.dgvSInfo.RowTemplate.Height = 38;
            this.dgvSInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvSInfo.Size = new System.Drawing.Size(584, 372);
            this.dgvSInfo.TabIndex = 0;
            this.dgvSInfo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSInfo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSInfo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSInfo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSInfo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSInfo.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(200)))), ((int)(((byte)(189)))));
            this.dgvSInfo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSInfo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(84)))), ((int)(((byte)(75)))));
            this.dgvSInfo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSInfo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSInfo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(84)))), ((int)(((byte)(75)))));
            this.dgvSInfo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSInfo.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvSInfo.ThemeStyle.ReadOnly = true;
            this.dgvSInfo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSInfo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSInfo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dgvSInfo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSInfo.ThemeStyle.RowsStyle.Height = 38;
            this.dgvSInfo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSInfo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSInfo_CellClick);
            // 
            // dgvSenq
            // 
            this.dgvSenq.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvSenq.FillWeight = 50F;
            this.dgvSenq.HeaderText = "Seq";
            this.dgvSenq.MinimumWidth = 50;
            this.dgvSenq.Name = "dgvSenq";
            this.dgvSenq.ReadOnly = true;
            this.dgvSenq.Width = 50;
            // 
            // dgvSID
            // 
            this.dgvSID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvSID.FillWeight = 200F;
            this.dgvSID.HeaderText = "Staff ID";
            this.dgvSID.MinimumWidth = 200;
            this.dgvSID.Name = "dgvSID";
            this.dgvSID.ReadOnly = true;
            this.dgvSID.Visible = false;
            this.dgvSID.Width = 200;
            // 
            // dgvJtitle
            // 
            this.dgvJtitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvJtitle.FillWeight = 150F;
            this.dgvJtitle.HeaderText = "Job Title";
            this.dgvJtitle.MinimumWidth = 150;
            this.dgvJtitle.Name = "dgvJtitle";
            this.dgvJtitle.ReadOnly = true;
            this.dgvJtitle.Width = 150;
            // 
            // dgvSName
            // 
            this.dgvSName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvSName.FillWeight = 150F;
            this.dgvSName.HeaderText = "Staff Name";
            this.dgvSName.MinimumWidth = 150;
            this.dgvSName.Name = "dgvSName";
            this.dgvSName.ReadOnly = true;
            this.dgvSName.Width = 150;
            // 
            // dgvSContact
            // 
            this.dgvSContact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvSContact.FillWeight = 150F;
            this.dgvSContact.HeaderText = "Contact Number";
            this.dgvSContact.MinimumWidth = 150;
            this.dgvSContact.Name = "dgvSContact";
            this.dgvSContact.ReadOnly = true;
            this.dgvSContact.Width = 150;
            // 
            // dgvSpassword
            // 
            this.dgvSpassword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvSpassword.HeaderText = "password";
            this.dgvSpassword.MinimumWidth = 100;
            this.dgvSpassword.Name = "dgvSpassword";
            this.dgvSpassword.ReadOnly = true;
            this.dgvSpassword.Visible = false;
            // 
            // dgvEdit
            // 
            this.dgvEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvEdit.FillWeight = 50F;
            this.dgvEdit.HeaderText = "";
            this.dgvEdit.Image = global::WindowsFormsApp1.Properties.Resources.edit_Staff;
            this.dgvEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvEdit.MinimumWidth = 50;
            this.dgvEdit.Name = "dgvEdit";
            this.dgvEdit.ReadOnly = true;
            this.dgvEdit.Width = 50;
            // 
            // dgvDel
            // 
            this.dgvDel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvDel.FillWeight = 50F;
            this.dgvDel.HeaderText = "";
            this.dgvDel.Image = global::WindowsFormsApp1.Properties.Resources.delete_Staff;
            this.dgvDel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvDel.MinimumWidth = 50;
            this.dgvDel.Name = "dgvDel";
            this.dgvDel.ReadOnly = true;
            this.dgvDel.Width = 50;
            // 
            // messageDel
            // 
            this.messageDel.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.messageDel.Caption = null;
            this.messageDel.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.messageDel.Parent = null;
            this.messageDel.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.messageDel.Text = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(200)))), ((int)(((byte)(189)))));
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search For Staff";
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = global::WindowsFormsApp1.Properties.Resources.search_Staff;
            this.txtSearch.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtSearch.Location = new System.Drawing.Point(400, 31);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(171, 38);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextOffset = new System.Drawing.Point(10, 0);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSAdd
            // 
            this.btnSAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(200)))), ((int)(((byte)(189)))));
            this.btnSAdd.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSAdd.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSAdd.Image = global::WindowsFormsApp1.Properties.Resources.Staff_Add;
            this.btnSAdd.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSAdd.ImageRotate = 0F;
            this.btnSAdd.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSAdd.IndicateFocus = true;
            this.btnSAdd.Location = new System.Drawing.Point(16, 11);
            this.btnSAdd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnSAdd.Name = "btnSAdd";
            this.btnSAdd.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSAdd.Size = new System.Drawing.Size(59, 58);
            this.btnSAdd.TabIndex = 1;
            this.btnSAdd.Click += new System.EventHandler(this.btnSAdd_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(200)))), ((int)(((byte)(189)))));
            this.guna2Panel1.Controls.Add(this.txtSearch);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(584, 79);
            this.guna2Panel1.TabIndex = 4;
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(584, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSAdd);
            this.Controls.Add(this.dgvSInfo);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "FormStaff";
            this.Text = "FormStaff";
            this.Load += new System.EventHandler(this.FormStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSInfo)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvSInfo;
        private Guna.UI2.WinForms.Guna2ImageButton btnSAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2MessageDialog messageDel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSenq;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvJtitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSpassword;
        private System.Windows.Forms.DataGridViewImageColumn dgvEdit;
        private System.Windows.Forms.DataGridViewImageColumn dgvDel;
    }
}