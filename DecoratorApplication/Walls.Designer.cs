namespace DecoratorApplication
{
    partial class Walls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Walls));
            this.nextBtn = new System.Windows.Forms.Button();
            this.addWallsLbl2 = new System.Windows.Forms.Label();
            this.addWallsLbl = new System.Windows.Forms.Label();
            this.heightLbl = new System.Windows.Forms.Label();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.widthLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.removeWallBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.currentWallsLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PaintAreaLbl = new System.Windows.Forms.Label();
            this.WallsCountLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.addWallBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextBtn
            // 
            this.nextBtn.Enabled = false;
            this.nextBtn.Location = new System.Drawing.Point(296, 349);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(112, 35);
            this.nextBtn.TabIndex = 4;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // addWallsLbl2
            // 
            this.addWallsLbl2.AutoSize = true;
            this.addWallsLbl2.Location = new System.Drawing.Point(18, 51);
            this.addWallsLbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addWallsLbl2.Name = "addWallsLbl2";
            this.addWallsLbl2.Size = new System.Drawing.Size(303, 20);
            this.addWallsLbl2.TabIndex = 3;
            this.addWallsLbl2.Text = "Enter the dimensions and click \"Add Wall\"";
            // 
            // addWallsLbl
            // 
            this.addWallsLbl.AutoSize = true;
            this.addWallsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWallsLbl.Location = new System.Drawing.Point(18, 14);
            this.addWallsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addWallsLbl.Name = "addWallsLbl";
            this.addWallsLbl.Size = new System.Drawing.Size(143, 32);
            this.addWallsLbl.TabIndex = 4;
            this.addWallsLbl.Text = "Add Walls";
            // 
            // heightLbl
            // 
            this.heightLbl.AutoSize = true;
            this.heightLbl.Location = new System.Drawing.Point(8, 108);
            this.heightLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heightLbl.Name = "heightLbl";
            this.heightLbl.Size = new System.Drawing.Size(119, 20);
            this.heightLbl.TabIndex = 7;
            this.heightLbl.Text = "Height (meters)";
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(12, 133);
            this.heightBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(148, 26);
            this.heightBox.TabIndex = 1;
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(12, 65);
            this.widthBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(148, 26);
            this.widthBox.TabIndex = 0;
            // 
            // widthLbl
            // 
            this.widthLbl.AutoSize = true;
            this.widthLbl.Location = new System.Drawing.Point(8, 35);
            this.widthLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.widthLbl.Name = "widthLbl";
            this.widthLbl.Size = new System.Drawing.Size(113, 20);
            this.widthLbl.TabIndex = 6;
            this.widthLbl.Text = "Width (meters)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addWallBtn);
            this.groupBox1.Controls.Add(this.widthLbl);
            this.groupBox1.Controls.Add(this.widthBox);
            this.groupBox1.Controls.Add(this.heightBox);
            this.groupBox1.Controls.Add(this.heightLbl);
            this.groupBox1.Location = new System.Drawing.Point(18, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(173, 231);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Walls";
            // 
            // removeWallBtn
            // 
            this.removeWallBtn.Location = new System.Drawing.Point(12, 108);
            this.removeWallBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeWallBtn.Name = "removeWallBtn";
            this.removeWallBtn.Size = new System.Drawing.Size(164, 35);
            this.removeWallBtn.TabIndex = 3;
            this.removeWallBtn.Text = "Remove Last Wall";
            this.removeWallBtn.UseVisualStyleBackColor = true;
            this.removeWallBtn.Click += new System.EventHandler(this.removeWallBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Paint Area (m²):";
            // 
            // currentWallsLbl
            // 
            this.currentWallsLbl.AutoSize = true;
            this.currentWallsLbl.Location = new System.Drawing.Point(4, 35);
            this.currentWallsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentWallsLbl.Name = "currentWallsLbl";
            this.currentWallsLbl.Size = new System.Drawing.Size(98, 20);
            this.currentWallsLbl.TabIndex = 8;
            this.currentWallsLbl.Text = "Walls Count:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PaintAreaLbl);
            this.groupBox2.Controls.Add(this.WallsCountLbl);
            this.groupBox2.Controls.Add(this.currentWallsLbl);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.removeWallBtn);
            this.groupBox2.Location = new System.Drawing.Point(222, 98);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(186, 155);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Data";
            // 
            // PaintAreaLbl
            // 
            this.PaintAreaLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PaintAreaLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PaintAreaLbl.Location = new System.Drawing.Point(116, 71);
            this.PaintAreaLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PaintAreaLbl.Name = "PaintAreaLbl";
            this.PaintAreaLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PaintAreaLbl.Size = new System.Drawing.Size(60, 20);
            this.PaintAreaLbl.TabIndex = 12;
            this.PaintAreaLbl.Text = "0";
            this.PaintAreaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WallsCountLbl
            // 
            this.WallsCountLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WallsCountLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WallsCountLbl.Location = new System.Drawing.Point(114, 35);
            this.WallsCountLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WallsCountLbl.Name = "WallsCountLbl";
            this.WallsCountLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WallsCountLbl.Size = new System.Drawing.Size(62, 20);
            this.WallsCountLbl.TabIndex = 8;
            this.WallsCountLbl.Text = "0";
            this.WallsCountLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(18, 349);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(112, 35);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // addWallBtn
            // 
            this.addWallBtn.Location = new System.Drawing.Point(15, 186);
            this.addWallBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addWallBtn.Name = "addWallBtn";
            this.addWallBtn.Size = new System.Drawing.Size(150, 35);
            this.addWallBtn.TabIndex = 14;
            this.addWallBtn.Text = "Add Wall";
            this.addWallBtn.UseVisualStyleBackColor = true;
            this.addWallBtn.Click += new System.EventHandler(this.addWallBtn_Click);
            // 
            // Walls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.addWallsLbl);
            this.Controls.Add(this.addWallsLbl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Walls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint Calculator - Walls";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label addWallsLbl2;
        private System.Windows.Forms.Label addWallsLbl;
        private System.Windows.Forms.Label heightLbl;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.Label widthLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button removeWallBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentWallsLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label PaintAreaLbl;
        private System.Windows.Forms.Label WallsCountLbl;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button addWallBtn;
    }
}