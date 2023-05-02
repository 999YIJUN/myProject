namespace WindowsFormsApp1
{
    partial class FormMember
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
            this.dgvCustomerInfo = new System.Windows.Forms.DataGridView();
            this.gbFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.lbSearch = new System.Windows.Forms.ListBox();
            this.dtpEndD = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpStartD = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnMemberAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnEditer = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInfo)).BeginInit();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomerInfo
            // 
            this.dgvCustomerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerInfo.Location = new System.Drawing.Point(432, 70);
            this.dgvCustomerInfo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dgvCustomerInfo.Name = "dgvCustomerInfo";
            this.dgvCustomerInfo.RowHeadersWidth = 82;
            this.dgvCustomerInfo.RowTemplate.Height = 38;
            this.dgvCustomerInfo.Size = new System.Drawing.Size(782, 586);
            this.dgvCustomerInfo.TabIndex = 1;
            this.dgvCustomerInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerInfo_CellClick);
            // 
            // gbFilter
            // 
            this.gbFilter.BackColor = System.Drawing.Color.Transparent;
            this.gbFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(187)))), ((int)(((byte)(169)))));
            this.gbFilter.BorderRadius = 50;
            this.gbFilter.BorderThickness = 5;
            this.gbFilter.Controls.Add(this.btnSearch);
            this.gbFilter.Controls.Add(this.lbSearch);
            this.gbFilter.Controls.Add(this.dtpEndD);
            this.gbFilter.Controls.Add(this.dtpStartD);
            this.gbFilter.Controls.Add(this.cbFilter);
            this.gbFilter.Controls.Add(this.txtFilter);
            this.gbFilter.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(187)))), ((int)(((byte)(169)))));
            this.gbFilter.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.gbFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(100)))), ((int)(((byte)(83)))));
            this.gbFilter.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.ForeColor = System.Drawing.Color.White;
            this.gbFilter.Location = new System.Drawing.Point(28, 70);
            this.gbFilter.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(378, 603);
            this.gbFilter.TabIndex = 6;
            this.gbFilter.Text = "FILTER";
            this.gbFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbFilter.TextOffset = new System.Drawing.Point(0, 10);
            // 
            // btnSearch
            // 
            this.btnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(211)))), ((int)(((byte)(195)))));
            this.btnSearch.BorderThickness = 2;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(187)))), ((int)(((byte)(169)))));
            this.btnSearch.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(31, 522);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(187)))), ((int)(((byte)(169)))));
            this.btnSearch.ShadowDecoration.Depth = 255;
            this.btnSearch.ShadowDecoration.Enabled = true;
            this.btnSearch.Size = new System.Drawing.Size(318, 64);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbSearch
            // 
            this.lbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(100)))), ((int)(((byte)(83)))));
            this.lbSearch.ForeColor = System.Drawing.Color.White;
            this.lbSearch.FormattingEnabled = true;
            this.lbSearch.HorizontalScrollbar = true;
            this.lbSearch.ItemHeight = 24;
            this.lbSearch.Location = new System.Drawing.Point(31, 184);
            this.lbSearch.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(320, 316);
            this.lbSearch.TabIndex = 3;
            this.lbSearch.SelectedIndexChanged += new System.EventHandler(this.lbSearch_SelectedIndexChanged);
            // 
            // dtpEndD
            // 
            this.dtpEndD.Checked = true;
            this.dtpEndD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(100)))), ((int)(((byte)(83)))));
            this.dtpEndD.Font = new System.Drawing.Font("Segoe UI Emoji", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndD.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpEndD.Location = new System.Drawing.Point(31, 140);
            this.dtpEndD.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dtpEndD.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndD.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndD.Name = "dtpEndD";
            this.dtpEndD.Size = new System.Drawing.Size(318, 28);
            this.dtpEndD.TabIndex = 2;
            this.dtpEndD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpEndD.Value = new System.DateTime(2023, 2, 18, 12, 31, 43, 682);
            // 
            // dtpStartD
            // 
            this.dtpStartD.Checked = true;
            this.dtpStartD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(100)))), ((int)(((byte)(83)))));
            this.dtpStartD.Font = new System.Drawing.Font("Segoe UI Emoji", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartD.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStartD.Location = new System.Drawing.Point(31, 95);
            this.dtpStartD.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dtpStartD.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartD.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartD.Name = "dtpStartD";
            this.dtpStartD.Size = new System.Drawing.Size(318, 30);
            this.dtpStartD.TabIndex = 2;
            this.dtpStartD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpStartD.Value = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(211)))), ((int)(((byte)(195)))));
            this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilter.DropDownHeight = 100;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(187)))), ((int)(((byte)(169)))));
            this.cbFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.Font = new System.Drawing.Font("Constantia", 10.125F);
            this.cbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilter.IntegralHeight = false;
            this.cbFilter.ItemHeight = 25;
            this.cbFilter.Location = new System.Drawing.Point(201, 47);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(187)))), ((int)(((byte)(169)))));
            this.cbFilter.ShadowDecoration.Depth = 255;
            this.cbFilter.ShadowDecoration.Enabled = true;
            this.cbFilter.Size = new System.Drawing.Size(150, 31);
            this.cbFilter.TabIndex = 1;
            // 
            // txtFilter
            // 
            this.txtFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(211)))), ((int)(((byte)(195)))));
            this.txtFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilter.DefaultText = "";
            this.txtFilter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(187)))), ((int)(((byte)(169)))));
            this.txtFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilter.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilter.Location = new System.Drawing.Point(31, 47);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PasswordChar = '\0';
            this.txtFilter.PlaceholderText = "";
            this.txtFilter.SelectedText = "";
            this.txtFilter.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(187)))), ((int)(((byte)(169)))));
            this.txtFilter.ShadowDecoration.Depth = 255;
            this.txtFilter.ShadowDecoration.Enabled = true;
            this.txtFilter.Size = new System.Drawing.Size(148, 31);
            this.txtFilter.TabIndex = 0;
            // 
            // btnMemberAdd
            // 
            this.btnMemberAdd.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnMemberAdd.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnMemberAdd.Image = global::WindowsFormsApp1.Properties.Resources.add;
            this.btnMemberAdd.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnMemberAdd.ImageRotate = 0F;
            this.btnMemberAdd.ImageSize = new System.Drawing.Size(50, 50);
            this.btnMemberAdd.IndicateFocus = true;
            this.btnMemberAdd.Location = new System.Drawing.Point(276, 11);
            this.btnMemberAdd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnMemberAdd.Name = "btnMemberAdd";
            this.btnMemberAdd.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnMemberAdd.Size = new System.Drawing.Size(56, 55);
            this.btnMemberAdd.TabIndex = 7;
            this.btnMemberAdd.Click += new System.EventHandler(this.btnMemberAdd_Click);
            // 
            // btnEditer
            // 
            this.btnEditer.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnEditer.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnEditer.Image = global::WindowsFormsApp1.Properties.Resources.document_editor;
            this.btnEditer.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnEditer.ImageRotate = 0F;
            this.btnEditer.ImageSize = new System.Drawing.Size(50, 50);
            this.btnEditer.Location = new System.Drawing.Point(330, 12);
            this.btnEditer.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnEditer.Name = "btnEditer";
            this.btnEditer.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnEditer.Size = new System.Drawing.Size(62, 56);
            this.btnEditer.TabIndex = 8;
            this.btnEditer.Click += new System.EventHandler(this.btnEditer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Member Information";
            // 
            // FormMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(100)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1224, 684);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditer);
            this.Controls.Add(this.btnMemberAdd);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.dgvCustomerInfo);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "FormMember";
            this.Text = "FormMember";
            this.Load += new System.EventHandler(this.FormMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInfo)).EndInit();
            this.gbFilter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomerInfo;
        private Guna.UI2.WinForms.Guna2GroupBox gbFilter;
        private System.Windows.Forms.ListBox lbSearch;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndD;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartD;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Guna.UI2.WinForms.Guna2TextBox txtFilter;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2ImageButton btnMemberAdd;
        private Guna.UI2.WinForms.Guna2ImageButton btnEditer;
        private System.Windows.Forms.Label label1;
    }
}