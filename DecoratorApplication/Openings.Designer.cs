namespace DecoratorApplication
{
    partial class Openings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Openings));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PaintAreaLbl = new System.Windows.Forms.Label();
            this.currentWallsLbl = new System.Windows.Forms.Label();
            this.OpeningsCountLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.removeOpeningBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.widthLbl = new System.Windows.Forms.Label();
            this.addOpeningBtn = new System.Windows.Forms.Button();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.heightLbl = new System.Windows.Forms.Label();
            this.addOpeningsLbl = new System.Windows.Forms.Label();
            this.addWallsLbl2 = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PaintAreaLbl);
            this.groupBox2.Controls.Add(this.currentWallsLbl);
            this.groupBox2.Controls.Add(this.OpeningsCountLbl);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.removeOpeningBtn);
            this.groupBox2.Location = new System.Drawing.Point(148, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 101);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Data";
            // 
            // PaintAreaLbl
            // 
            this.PaintAreaLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PaintAreaLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PaintAreaLbl.Location = new System.Drawing.Point(78, 46);
            this.PaintAreaLbl.Name = "PaintAreaLbl";
            this.PaintAreaLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PaintAreaLbl.Size = new System.Drawing.Size(40, 13);
            this.PaintAreaLbl.TabIndex = 14;
            this.PaintAreaLbl.Text = "0";
            this.PaintAreaLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // currentWallsLbl
            // 
            this.currentWallsLbl.AutoSize = true;
            this.currentWallsLbl.Location = new System.Drawing.Point(3, 23);
            this.currentWallsLbl.Name = "currentWallsLbl";
            this.currentWallsLbl.Size = new System.Drawing.Size(86, 13);
            this.currentWallsLbl.TabIndex = 8;
            this.currentWallsLbl.Text = "Openings Count:";
            // 
            // OpeningsCountLbl
            // 
            this.OpeningsCountLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpeningsCountLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OpeningsCountLbl.Location = new System.Drawing.Point(86, 23);
            this.OpeningsCountLbl.Name = "OpeningsCountLbl";
            this.OpeningsCountLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OpeningsCountLbl.Size = new System.Drawing.Size(32, 13);
            this.OpeningsCountLbl.TabIndex = 13;
            this.OpeningsCountLbl.Text = "0";
            this.OpeningsCountLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Paint Area (m²):";
            // 
            // removeOpeningBtn
            // 
            this.removeOpeningBtn.Location = new System.Drawing.Point(0, 70);
            this.removeOpeningBtn.Name = "removeOpeningBtn";
            this.removeOpeningBtn.Size = new System.Drawing.Size(124, 23);
            this.removeOpeningBtn.TabIndex = 3;
            this.removeOpeningBtn.Text = "Remove Last Opening";
            this.removeOpeningBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.widthLbl);
            this.groupBox1.Controls.Add(this.addOpeningBtn);
            this.groupBox1.Controls.Add(this.widthBox);
            this.groupBox1.Controls.Add(this.heightBox);
            this.groupBox1.Controls.Add(this.heightLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 148);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Openings";
            // 
            // widthLbl
            // 
            this.widthLbl.AutoSize = true;
            this.widthLbl.Location = new System.Drawing.Point(6, 23);
            this.widthLbl.Name = "widthLbl";
            this.widthLbl.Size = new System.Drawing.Size(75, 13);
            this.widthLbl.TabIndex = 6;
            this.widthLbl.Text = "Width (meters)";
            // 
            // addOpeningBtn
            // 
            this.addOpeningBtn.Location = new System.Drawing.Point(9, 116);
            this.addOpeningBtn.Name = "addOpeningBtn";
            this.addOpeningBtn.Size = new System.Drawing.Size(100, 23);
            this.addOpeningBtn.TabIndex = 2;
            this.addOpeningBtn.Text = "Add Opening";
            this.addOpeningBtn.UseVisualStyleBackColor = true;
            this.addOpeningBtn.Click += new System.EventHandler(this.addOpeningBtn_Click);
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(9, 39);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(100, 20);
            this.widthBox.TabIndex = 0;
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(10, 82);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(100, 20);
            this.heightBox.TabIndex = 1;
            // 
            // heightLbl
            // 
            this.heightLbl.AutoSize = true;
            this.heightLbl.Location = new System.Drawing.Point(6, 65);
            this.heightLbl.Name = "heightLbl";
            this.heightLbl.Size = new System.Drawing.Size(78, 13);
            this.heightLbl.TabIndex = 7;
            this.heightLbl.Text = "Height (meters)";
            // 
            // addOpeningsLbl
            // 
            this.addOpeningsLbl.AutoSize = true;
            this.addOpeningsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOpeningsLbl.Location = new System.Drawing.Point(12, 9);
            this.addOpeningsLbl.Name = "addOpeningsLbl";
            this.addOpeningsLbl.Size = new System.Drawing.Size(133, 24);
            this.addOpeningsLbl.TabIndex = 15;
            this.addOpeningsLbl.Text = "Add Openings";
            // 
            // addWallsLbl2
            // 
            this.addWallsLbl2.AutoSize = true;
            this.addWallsLbl2.Location = new System.Drawing.Point(12, 33);
            this.addWallsLbl2.Name = "addWallsLbl2";
            this.addWallsLbl2.Size = new System.Drawing.Size(231, 13);
            this.addWallsLbl2.TabIndex = 14;
            this.addWallsLbl2.Text = "Enter the dimensions and click \"Add Openings\"";
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(197, 227);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 4;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(12, 227);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Openings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addOpeningsLbl);
            this.Controls.Add(this.addWallsLbl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Openings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint Calculator - Openings";
            this.Load += new System.EventHandler(this.Openings_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label currentWallsLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeOpeningBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label widthLbl;
        private System.Windows.Forms.Button addOpeningBtn;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.Label heightLbl;
        private System.Windows.Forms.Label addOpeningsLbl;
        private System.Windows.Forms.Label addWallsLbl2;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label PaintAreaLbl;
        private System.Windows.Forms.Label OpeningsCountLbl;
        private System.Windows.Forms.Button backBtn;
    }
}