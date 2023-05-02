namespace WindowsFormsApp1
{
    partial class FormDiscount
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbCLose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnVIP = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnBirth = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbCLose);
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.btnVIP);
            this.groupBox3.Controls.Add(this.btnStaff);
            this.groupBox3.Controls.Add(this.btnBirth);
            this.groupBox3.Controls.Add(this.btnMember);
            this.groupBox3.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(7, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 253);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Discount Option";
            // 
            // cbCLose
            // 
            this.cbCLose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCLose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(53)))), ((int)(((byte)(44)))));
            this.cbCLose.IconColor = System.Drawing.Color.White;
            this.cbCLose.Location = new System.Drawing.Point(180, 13);
            this.cbCLose.Name = "cbCLose";
            this.cbCLose.Size = new System.Drawing.Size(24, 24);
            this.cbCLose.TabIndex = 7;
            this.cbCLose.Click += new System.EventHandler(this.cbCLose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(6, 202);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(198, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnVIP
            // 
            this.btnVIP.Location = new System.Drawing.Point(6, 162);
            this.btnVIP.Name = "btnVIP";
            this.btnVIP.Size = new System.Drawing.Size(198, 35);
            this.btnVIP.TabIndex = 6;
            this.btnVIP.Text = "VIP---ON THE HOUSE";
            this.btnVIP.UseVisualStyleBackColor = true;
            this.btnVIP.Click += new System.EventHandler(this.btnVIP_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Location = new System.Drawing.Point(6, 122);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(198, 35);
            this.btnStaff.TabIndex = 6;
            this.btnStaff.Text = "HAPPY HOUR                   30%";
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnBirth
            // 
            this.btnBirth.Location = new System.Drawing.Point(6, 82);
            this.btnBirth.Name = "btnBirth";
            this.btnBirth.Size = new System.Drawing.Size(198, 35);
            this.btnBirth.TabIndex = 6;
            this.btnBirth.Text = "Birthday Of The Day      20%";
            this.btnBirth.UseVisualStyleBackColor = true;
            this.btnBirth.Click += new System.EventHandler(this.btnBirth_Click);
            // 
            // btnMember
            // 
            this.btnMember.Location = new System.Drawing.Point(6, 42);
            this.btnMember.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(198, 35);
            this.btnMember.TabIndex = 5;
            this.btnMember.Text = "Member Discount           10%";
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // FormDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(200)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(224, 268);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDiscount";
            this.Text = "FormDiscount";
            this.Load += new System.EventHandler(this.FormDiscount_Load);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnVIP;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnBirth;
        private System.Windows.Forms.Button btnMember;
        private Guna.UI2.WinForms.Guna2ControlBox cbCLose;
    }
}