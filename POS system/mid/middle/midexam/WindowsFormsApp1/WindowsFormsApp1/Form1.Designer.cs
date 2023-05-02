namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.numericQuan = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPriceTotal = new System.Windows.Forms.Label();
            this.btnCheckOrder = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.txtContactNum = new System.Windows.Forms.TextBox();
            this.tabCDesserts = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvDessert = new System.Windows.Forms.ListView();
            this.ilProductPic = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericQuan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabCDesserts.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(102, 46);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(32, 17);
            this.lblUnitPrice.TabIndex = 1;
            this.lblUnitPrice.Text = "000";
            // 
            // numericQuan
            // 
            this.numericQuan.Location = new System.Drawing.Point(100, 140);
            this.numericQuan.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.numericQuan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQuan.Name = "numericQuan";
            this.numericQuan.Size = new System.Drawing.Size(55, 24);
            this.numericQuan.TabIndex = 2;
            this.numericQuan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQuan.ValueChanged += new System.EventHandler(this.numericQuan_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnCheckOrder);
            this.groupBox1.Controls.Add(this.btnAddOrder);
            this.groupBox1.Location = new System.Drawing.Point(509, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox1.Size = new System.Drawing.Size(296, 589);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numericQuan);
            this.groupBox2.Controls.Add(this.lblUnitPrice);
            this.groupBox2.Controls.Add(this.lblPriceTotal);
            this.groupBox2.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox2.Size = new System.Drawing.Size(222, 174);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sub Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantity";
            // 
            // lblPriceTotal
            // 
            this.lblPriceTotal.AutoSize = true;
            this.lblPriceTotal.Location = new System.Drawing.Point(102, 98);
            this.lblPriceTotal.Name = "lblPriceTotal";
            this.lblPriceTotal.Size = new System.Drawing.Size(48, 17);
            this.lblPriceTotal.TabIndex = 1;
            this.lblPriceTotal.Text = "00000";
            // 
            // btnCheckOrder
            // 
            this.btnCheckOrder.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOrder.Location = new System.Drawing.Point(156, 491);
            this.btnCheckOrder.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnCheckOrder.Name = "btnCheckOrder";
            this.btnCheckOrder.Size = new System.Drawing.Size(138, 82);
            this.btnCheckOrder.TabIndex = 4;
            this.btnCheckOrder.Text = "Check";
            this.btnCheckOrder.UseVisualStyleBackColor = true;
            this.btnCheckOrder.Click += new System.EventHandler(this.btnCheckOrder_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.Location = new System.Drawing.Point(14, 488);
            this.btnAddOrder.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(138, 88);
            this.btnAddOrder.TabIndex = 3;
            this.btnAddOrder.Text = "Add";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtCusName);
            this.groupBox3.Controls.Add(this.txtContactNum);
            this.groupBox3.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(22, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox3.Size = new System.Drawing.Size(474, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Contact Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Customer Name";
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(21, 54);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtCusName.Multiline = true;
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(114, 28);
            this.txtCusName.TabIndex = 0;
            // 
            // txtContactNum
            // 
            this.txtContactNum.Location = new System.Drawing.Point(163, 54);
            this.txtContactNum.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtContactNum.Multiline = true;
            this.txtContactNum.Name = "txtContactNum";
            this.txtContactNum.Size = new System.Drawing.Size(114, 28);
            this.txtContactNum.TabIndex = 0;
            // 
            // tabCDesserts
            // 
            this.tabCDesserts.Controls.Add(this.tabPage1);
            this.tabCDesserts.Controls.Add(this.tabPage2);
            this.tabCDesserts.Location = new System.Drawing.Point(22, 128);
            this.tabCDesserts.Name = "tabCDesserts";
            this.tabCDesserts.SelectedIndex = 0;
            this.tabCDesserts.Size = new System.Drawing.Size(478, 477);
            this.tabCDesserts.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.LemonChiffon;
            this.tabPage1.Controls.Add(this.lvDessert);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(470, 451);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "DESSERTS";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(470, 451);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvDessert
            // 
            this.lvDessert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDessert.HideSelection = false;
            this.lvDessert.Location = new System.Drawing.Point(3, 3);
            this.lvDessert.Name = "lvDessert";
            this.lvDessert.Size = new System.Drawing.Size(464, 445);
            this.lvDessert.TabIndex = 0;
            this.lvDessert.UseCompatibleStateImageBehavior = false;
            this.lvDessert.ItemActivate += new System.EventHandler(this.lvDessert_ItemActivate);
            // 
            // ilProductPic
            // 
            this.ilProductPic.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilProductPic.ImageSize = new System.Drawing.Size(256, 256);
            this.ilProductPic.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(816, 675);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabCDesserts);
            this.Name = "Form1";
            this.Text = "Post Of Sale";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericQuan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabCDesserts.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.NumericUpDown numericQuan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCheckOrder;
        private System.Windows.Forms.Button btnAddOrder;
        public System.Windows.Forms.Label lblPriceTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.TextBox txtContactNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabCDesserts;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lvDessert;
        private System.Windows.Forms.ImageList ilProductPic;
    }
}

