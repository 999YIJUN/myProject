namespace WindowsFormsApp1
{
    partial class FormOrderList
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
            this.listboxOrderDetail = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCusInfo = new System.Windows.Forms.Label();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAfterDiscount = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnVIP = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnBirth = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listboxOrderDetail
            // 
            this.listboxOrderDetail.Cursor = System.Windows.Forms.Cursors.Default;
            this.listboxOrderDetail.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxOrderDetail.FormattingEnabled = true;
            this.listboxOrderDetail.ItemHeight = 15;
            this.listboxOrderDetail.Location = new System.Drawing.Point(53, 136);
            this.listboxOrderDetail.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.listboxOrderDetail.Name = "listboxOrderDetail";
            this.listboxOrderDetail.Size = new System.Drawing.Size(502, 94);
            this.listboxOrderDetail.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCusInfo);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(79, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox1.Size = new System.Drawing.Size(416, 104);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // lblCusInfo
            // 
            this.lblCusInfo.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusInfo.Location = new System.Drawing.Point(15, 20);
            this.lblCusInfo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCusInfo.Name = "lblCusInfo";
            this.lblCusInfo.Size = new System.Drawing.Size(202, 44);
            this.lblCusInfo.TabIndex = 0;
            this.lblCusInfo.Text = "label1";
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(24, 64);
            this.btnremove.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(78, 36);
            this.btnremove.TabIndex = 2;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(24, 118);
            this.btnclear.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(78, 24);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAfterDiscount);
            this.groupBox2.Controls.Add(this.lblTotalPrice);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnremove);
            this.groupBox2.Controls.Add(this.btnclear);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(221, 260);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox2.Size = new System.Drawing.Size(435, 158);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // lblAfterDiscount
            // 
            this.lblAfterDiscount.AutoSize = true;
            this.lblAfterDiscount.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfterDiscount.Location = new System.Drawing.Point(212, 26);
            this.lblAfterDiscount.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAfterDiscount.Name = "lblAfterDiscount";
            this.lblAfterDiscount.Size = new System.Drawing.Size(0, 17);
            this.lblAfterDiscount.TabIndex = 5;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(21, 26);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(80, 17);
            this.lblTotalPrice.TabIndex = 5;
            this.lblTotalPrice.Text = "Total Price";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(121, 118);
            this.btnClose.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 24);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMember
            // 
            this.btnMember.Location = new System.Drawing.Point(0, 33);
            this.btnMember.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(190, 35);
            this.btnMember.TabIndex = 5;
            this.btnMember.Text = "Member Discount           10%";
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.btnVIP);
            this.groupBox3.Controls.Add(this.btnStaff);
            this.groupBox3.Controls.Add(this.btnBirth);
            this.groupBox3.Controls.Add(this.btnMember);
            this.groupBox3.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(7, 248);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(195, 257);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Discount Option";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(0, 196);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(190, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnVIP
            // 
            this.btnVIP.Location = new System.Drawing.Point(0, 155);
            this.btnVIP.Name = "btnVIP";
            this.btnVIP.Size = new System.Drawing.Size(190, 35);
            this.btnVIP.TabIndex = 6;
            this.btnVIP.Text = "VIP---ON THE HOUSE";
            this.btnVIP.UseVisualStyleBackColor = true;
            this.btnVIP.Click += new System.EventHandler(this.btnVIP_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Location = new System.Drawing.Point(0, 114);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(190, 35);
            this.btnStaff.TabIndex = 6;
            this.btnStaff.Text = "Staff Discount                   15%";
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnBirth
            // 
            this.btnBirth.Location = new System.Drawing.Point(0, 73);
            this.btnBirth.Name = "btnBirth";
            this.btnBirth.Size = new System.Drawing.Size(190, 35);
            this.btnBirth.TabIndex = 6;
            this.btnBirth.Text = "Birthday Of The Day      20%";
            this.btnBirth.UseVisualStyleBackColor = true;
            this.btnBirth.Click += new System.EventHandler(this.btnBirth_Click);
            // 
            // FormOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 530);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listboxOrderDetail);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "FormOrderList";
            this.Text = "FormOrderList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOrderList_FormClosing);
            this.Load += new System.EventHandler(this.FormOrderList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listboxOrderDetail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCusInfo;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Label lblAfterDiscount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBirth;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnVIP;
        private System.Windows.Forms.Button btnCancel;
    }
}