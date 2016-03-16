namespace DecoratorApplication
{
    partial class Paints
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paints));
            this.addWallsLbl = new System.Windows.Forms.Label();
            this.addWallsLbl2 = new System.Windows.Forms.Label();
            this.paintBox = new System.Windows.Forms.ComboBox();
            this.undercoatBox = new System.Windows.Forms.CheckBox();
            this.createInvoiceBtn = new System.Windows.Forms.Button();
            this.areaLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.paintAreaLbl = new System.Windows.Forms.Label();
            this.rateLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addWallsLbl
            // 
            this.addWallsLbl.AutoSize = true;
            this.addWallsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWallsLbl.Location = new System.Drawing.Point(12, 9);
            this.addWallsLbl.Name = "addWallsLbl";
            this.addWallsLbl.Size = new System.Drawing.Size(122, 24);
            this.addWallsLbl.TabIndex = 6;
            this.addWallsLbl.Text = "Choose Paint";
            // 
            // addWallsLbl2
            // 
            this.addWallsLbl2.AutoSize = true;
            this.addWallsLbl2.Location = new System.Drawing.Point(6, 16);
            this.addWallsLbl2.Name = "addWallsLbl2";
            this.addWallsLbl2.Size = new System.Drawing.Size(98, 13);
            this.addWallsLbl2.TabIndex = 5;
            this.addWallsLbl2.Text = "Select a paint type.";
            // 
            // paintBox
            // 
            this.paintBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paintBox.FormattingEnabled = true;
            this.paintBox.Items.AddRange(new object[] {
            "Economy \t(£0.80 per sq m)",
            "Standard \t(£1.00 per sq m)",
            "Luxury \t(£1.75 per sq m)"});
            this.paintBox.Location = new System.Drawing.Point(10, 32);
            this.paintBox.Name = "paintBox";
            this.paintBox.Size = new System.Drawing.Size(155, 21);
            this.paintBox.TabIndex = 0;
            this.paintBox.SelectedIndexChanged += new System.EventHandler(this.paintBox_SelectedIndexChanged);
            // 
            // undercoatBox
            // 
            this.undercoatBox.AutoSize = true;
            this.undercoatBox.Location = new System.Drawing.Point(10, 59);
            this.undercoatBox.Name = "undercoatBox";
            this.undercoatBox.Size = new System.Drawing.Size(155, 17);
            this.undercoatBox.TabIndex = 1;
            this.undercoatBox.Text = "Undercoat (£0.45 per sq m)";
            this.undercoatBox.UseVisualStyleBackColor = true;
            this.undercoatBox.CheckedChanged += new System.EventHandler(this.undercoatBox_CheckedChanged);
            // 
            // createInvoiceBtn
            // 
            this.createInvoiceBtn.Enabled = false;
            this.createInvoiceBtn.Location = new System.Drawing.Point(186, 227);
            this.createInvoiceBtn.Name = "createInvoiceBtn";
            this.createInvoiceBtn.Size = new System.Drawing.Size(86, 23);
            this.createInvoiceBtn.TabIndex = 2;
            this.createInvoiceBtn.Text = "Create Invoice";
            this.createInvoiceBtn.UseVisualStyleBackColor = true;
            this.createInvoiceBtn.Click += new System.EventHandler(this.createInvoiceBtn_Click);
            // 
            // areaLbl
            // 
            this.areaLbl.AutoSize = true;
            this.areaLbl.Location = new System.Drawing.Point(6, 107);
            this.areaLbl.Name = "areaLbl";
            this.areaLbl.Size = new System.Drawing.Size(32, 13);
            this.areaLbl.TabIndex = 10;
            this.areaLbl.Text = "Area:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cost per sq m:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total:";
            // 
            // paintAreaLbl
            // 
            this.paintAreaLbl.Location = new System.Drawing.Point(99, 107);
            this.paintAreaLbl.Name = "paintAreaLbl";
            this.paintAreaLbl.Size = new System.Drawing.Size(75, 13);
            this.paintAreaLbl.TabIndex = 13;
            this.paintAreaLbl.Text = "0";
            this.paintAreaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rateLbl
            // 
            this.rateLbl.Location = new System.Drawing.Point(96, 120);
            this.rateLbl.Name = "rateLbl";
            this.rateLbl.Size = new System.Drawing.Size(78, 13);
            this.rateLbl.TabIndex = 14;
            this.rateLbl.Text = "0";
            this.rateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalLbl
            // 
            this.totalLbl.Location = new System.Drawing.Point(96, 133);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(78, 13);
            this.totalLbl.TabIndex = 15;
            this.totalLbl.Text = "0";
            this.totalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(12, 227);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(74, 23);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addWallsLbl2);
            this.groupBox1.Controls.Add(this.paintBox);
            this.groupBox1.Controls.Add(this.totalLbl);
            this.groupBox1.Controls.Add(this.undercoatBox);
            this.groupBox1.Controls.Add(this.rateLbl);
            this.groupBox1.Controls.Add(this.areaLbl);
            this.groupBox1.Controls.Add(this.paintAreaLbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 160);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // Paints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.createInvoiceBtn);
            this.Controls.Add(this.addWallsLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Paints";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint Calculator - Paint";
            this.Load += new System.EventHandler(this.Paints_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addWallsLbl;
        private System.Windows.Forms.Label addWallsLbl2;
        private System.Windows.Forms.ComboBox paintBox;
        private System.Windows.Forms.CheckBox undercoatBox;
        private System.Windows.Forms.Button createInvoiceBtn;
        private System.Windows.Forms.Label areaLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label paintAreaLbl;
        private System.Windows.Forms.Label rateLbl;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}