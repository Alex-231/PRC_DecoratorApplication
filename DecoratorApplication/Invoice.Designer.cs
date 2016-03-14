namespace DecoratorApplication
{
    partial class Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.finishBtn = new System.Windows.Forms.Button();
            this.createInvoiceLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.customerIdBox = new System.Windows.Forms.TextBox();
            this.phoneNumberBox = new System.Windows.Forms.TextBox();
            this.addressline2Box = new System.Windows.Forms.TextBox();
            this.addressline1Box = new System.Windows.Forms.TextBox();
            this.companyNameBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.subtotalBox = new System.Windows.Forms.TextBox();
            this.paymentDueBox = new System.Windows.Forms.TextBox();
            this.invoiceNumberLbl = new System.Windows.Forms.Label();
            this.purchaseOrderBox = new System.Windows.Forms.TextBox();
            this.invoiceNumberBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.saveInvoice = new System.Windows.Forms.SaveFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.vatBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.vatRateBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.discountBox = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.specialInstructionsBox = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountBox)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // finishBtn
            // 
            this.finishBtn.Enabled = false;
            this.finishBtn.Location = new System.Drawing.Point(440, 352);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(75, 23);
            this.finishBtn.TabIndex = 8;
            this.finishBtn.Text = "Finish";
            this.finishBtn.UseVisualStyleBackColor = true;
            this.finishBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // createInvoiceLbl
            // 
            this.createInvoiceLbl.AutoSize = true;
            this.createInvoiceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createInvoiceLbl.Location = new System.Drawing.Point(12, 10);
            this.createInvoiceLbl.Name = "createInvoiceLbl";
            this.createInvoiceLbl.Size = new System.Drawing.Size(130, 24);
            this.createInvoiceLbl.TabIndex = 15;
            this.createInvoiceLbl.Text = "Create Invoice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Company Name:";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(6, 23);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(38, 13);
            this.nameLbl.TabIndex = 8;
            this.nameLbl.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.customerIdBox);
            this.groupBox2.Controls.Add(this.phoneNumberBox);
            this.groupBox2.Controls.Add(this.addressline2Box);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.addressline1Box);
            this.groupBox2.Controls.Add(this.companyNameBox);
            this.groupBox2.Controls.Add(this.nameBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nameLbl);
            this.groupBox2.Location = new System.Drawing.Point(12, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 178);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bill To:";
            // 
            // customerIdBox
            // 
            this.customerIdBox.Location = new System.Drawing.Point(97, 150);
            this.customerIdBox.Name = "customerIdBox";
            this.customerIdBox.Size = new System.Drawing.Size(164, 20);
            this.customerIdBox.TabIndex = 5;
            this.customerIdBox.TextChanged += new System.EventHandler(this.customerIdBox_TextChanged);
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.Location = new System.Drawing.Point(97, 124);
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(164, 20);
            this.phoneNumberBox.TabIndex = 4;
            this.phoneNumberBox.TextChanged += new System.EventHandler(this.phoneNumberBox_TextChanged);
            // 
            // addressline2Box
            // 
            this.addressline2Box.Location = new System.Drawing.Point(97, 98);
            this.addressline2Box.Name = "addressline2Box";
            this.addressline2Box.Size = new System.Drawing.Size(164, 20);
            this.addressline2Box.TabIndex = 3;
            this.addressline2Box.TextChanged += new System.EventHandler(this.addressline2Box_TextChanged);
            // 
            // addressline1Box
            // 
            this.addressline1Box.Location = new System.Drawing.Point(97, 72);
            this.addressline1Box.Name = "addressline1Box";
            this.addressline1Box.Size = new System.Drawing.Size(164, 20);
            this.addressline1Box.TabIndex = 2;
            this.addressline1Box.TextChanged += new System.EventHandler(this.addressline1Box_TextChanged);
            // 
            // companyNameBox
            // 
            this.companyNameBox.Location = new System.Drawing.Point(97, 46);
            this.companyNameBox.Name = "companyNameBox";
            this.companyNameBox.Size = new System.Drawing.Size(164, 20);
            this.companyNameBox.TabIndex = 1;
            this.companyNameBox.TextChanged += new System.EventHandler(this.companyNameBox_TextChanged);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(97, 20);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(164, 20);
            this.nameBox.TabIndex = 0;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 153);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Customer ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Address Line 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Address Line 1:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.subtotalBox);
            this.groupBox1.Controls.Add(this.paymentDueBox);
            this.groupBox1.Controls.Add(this.invoiceNumberLbl);
            this.groupBox1.Controls.Add(this.purchaseOrderBox);
            this.groupBox1.Controls.Add(this.invoiceNumberBox);
            this.groupBox1.Controls.Add(this.dateBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(290, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 178);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // subtotalBox
            // 
            this.subtotalBox.Location = new System.Drawing.Point(97, 124);
            this.subtotalBox.Name = "subtotalBox";
            this.subtotalBox.ReadOnly = true;
            this.subtotalBox.Size = new System.Drawing.Size(120, 20);
            this.subtotalBox.TabIndex = 12;
            // 
            // paymentDueBox
            // 
            this.paymentDueBox.Location = new System.Drawing.Point(97, 98);
            this.paymentDueBox.Name = "paymentDueBox";
            this.paymentDueBox.ReadOnly = true;
            this.paymentDueBox.Size = new System.Drawing.Size(120, 20);
            this.paymentDueBox.TabIndex = 11;
            // 
            // invoiceNumberLbl
            // 
            this.invoiceNumberLbl.AutoSize = true;
            this.invoiceNumberLbl.Location = new System.Drawing.Point(6, 49);
            this.invoiceNumberLbl.Name = "invoiceNumberLbl";
            this.invoiceNumberLbl.Size = new System.Drawing.Size(45, 13);
            this.invoiceNumberLbl.TabIndex = 9;
            this.invoiceNumberLbl.Text = "Invoice:";
            // 
            // purchaseOrderBox
            // 
            this.purchaseOrderBox.Location = new System.Drawing.Point(97, 72);
            this.purchaseOrderBox.Name = "purchaseOrderBox";
            this.purchaseOrderBox.ReadOnly = true;
            this.purchaseOrderBox.Size = new System.Drawing.Size(120, 20);
            this.purchaseOrderBox.TabIndex = 10;
            // 
            // invoiceNumberBox
            // 
            this.invoiceNumberBox.Location = new System.Drawing.Point(97, 46);
            this.invoiceNumberBox.Name = "invoiceNumberBox";
            this.invoiceNumberBox.ReadOnly = true;
            this.invoiceNumberBox.Size = new System.Drawing.Size(120, 20);
            this.invoiceNumberBox.TabIndex = 9;
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(97, 20);
            this.dateBox.Name = "dateBox";
            this.dateBox.ReadOnly = true;
            this.dateBox.Size = new System.Drawing.Size(120, 20);
            this.dateBox.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Subtotal:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Payment Due:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Purchase Order:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Date:";
            // 
            // saveInvoice
            // 
            this.saveInvoice.DefaultExt = "rtf";
            this.saveInvoice.Filter = "Rich Text Format | *.rtf";
            this.saveInvoice.Tag = "Invoice";
            this.saveInvoice.FileOk += new System.ComponentModel.CancelEventHandler(this.saveInvoice_FileOk);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.totalBox);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.vatBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.vatRateBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.discountBox);
            this.groupBox3.Location = new System.Drawing.Point(290, 221);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 124);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(96, 91);
            this.totalBox.Name = "totalBox";
            this.totalBox.ReadOnly = true;
            this.totalBox.Size = new System.Drawing.Size(120, 20);
            this.totalBox.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Total:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(99, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "£";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Discount:";
            // 
            // vatBox
            // 
            this.vatBox.Location = new System.Drawing.Point(96, 41);
            this.vatBox.Name = "vatBox";
            this.vatBox.ReadOnly = true;
            this.vatBox.Size = new System.Drawing.Size(120, 20);
            this.vatBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "VAT:";
            // 
            // vatRateBox
            // 
            this.vatRateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vatRateBox.FormattingEnabled = true;
            this.vatRateBox.Items.AddRange(new object[] {
            "Standard\t(%20)",
            "Reduced\t(%5)",
            "Zero\t(%0)"});
            this.vatRateBox.Location = new System.Drawing.Point(96, 13);
            this.vatRateBox.Name = "vatRateBox";
            this.vatRateBox.Size = new System.Drawing.Size(121, 21);
            this.vatRateBox.TabIndex = 13;
            this.vatRateBox.SelectedIndexChanged += new System.EventHandler(this.vatRateBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "VAT Rate:";
            // 
            // discountBox
            // 
            this.discountBox.DecimalPlaces = 2;
            this.discountBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.discountBox.Location = new System.Drawing.Point(96, 67);
            this.discountBox.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.discountBox.Name = "discountBox";
            this.discountBox.Size = new System.Drawing.Size(120, 20);
            this.discountBox.TabIndex = 7;
            this.discountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.discountBox.ValueChanged += new System.EventHandler(this.discountBox_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.specialInstructionsBox);
            this.groupBox4.Location = new System.Drawing.Point(12, 221);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(261, 124);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Special Instructions";
            // 
            // specialInstructionsBox
            // 
            this.specialInstructionsBox.Location = new System.Drawing.Point(6, 16);
            this.specialInstructionsBox.Multiline = true;
            this.specialInstructionsBox.Name = "specialInstructionsBox";
            this.specialInstructionsBox.Size = new System.Drawing.Size(249, 102);
            this.specialInstructionsBox.TabIndex = 6;
            this.specialInstructionsBox.TextChanged += new System.EventHandler(this.specialInstructionsBox_TextChanged);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(12, 351);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 9;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 386);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.finishBtn);
            this.Controls.Add(this.createInvoiceLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint Calculator - Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountBox)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button finishBtn;
        private System.Windows.Forms.Label createInvoiceLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerIdBox;
        private System.Windows.Forms.TextBox phoneNumberBox;
        private System.Windows.Forms.TextBox addressline2Box;
        private System.Windows.Forms.TextBox addressline1Box;
        private System.Windows.Forms.TextBox companyNameBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox paymentDueBox;
        private System.Windows.Forms.Label invoiceNumberLbl;
        private System.Windows.Forms.TextBox purchaseOrderBox;
        private System.Windows.Forms.TextBox invoiceNumberBox;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.SaveFileDialog saveInvoice;
        private System.Windows.Forms.TextBox subtotalBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox vatRateBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox vatBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown discountBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.TextBox specialInstructionsBox;
        private System.Windows.Forms.Button backBtn;
    }
}