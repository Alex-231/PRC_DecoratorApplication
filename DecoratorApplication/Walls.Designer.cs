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
            this.addWallBtn = new System.Windows.Forms.Button();
            this.widthLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.removeWallBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.currentWallsLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PaintAreaLbl = new System.Windows.Forms.Label();
            this.WallsCountLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextBtn
            // 
            this.nextBtn.Enabled = false;
            this.nextBtn.Location = new System.Drawing.Point(197, 227);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 4;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // addWallsLbl2
            // 
            this.addWallsLbl2.AutoSize = true;
            this.addWallsLbl2.Location = new System.Drawing.Point(12, 33);
            this.addWallsLbl2.Name = "addWallsLbl2";
            this.addWallsLbl2.Size = new System.Drawing.Size(207, 13);
            this.addWallsLbl2.TabIndex = 3;
            this.addWallsLbl2.Text = "Enter the dimensions and click \"Add Wall\"";
            // 
            // addWallsLbl
            // 
            this.addWallsLbl.AutoSize = true;
            this.addWallsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWallsLbl.Location = new System.Drawing.Point(12, 9);
            this.addWallsLbl.Name = "addWallsLbl";
            this.addWallsLbl.Size = new System.Drawing.Size(95, 24);
            this.addWallsLbl.TabIndex = 4;
            this.addWallsLbl.Text = "Add Walls";
            // 
            // heightLbl
            // 
            this.heightLbl.AutoSize = true;
            this.heightLbl.Location = new System.Drawing.Point(6, 65);
            this.heightLbl.Name = "heightLbl";
            this.heightLbl.Size = new System.Drawing.Size(38, 13);
            this.heightLbl.TabIndex = 7;
            this.heightLbl.Text = "Height";
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(10, 82);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(100, 20);
            this.heightBox.TabIndex = 1;
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(9, 39);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(100, 20);
            this.widthBox.TabIndex = 0;
            // 
            // addWallBtn
            // 
            this.addWallBtn.Location = new System.Drawing.Point(9, 116);
            this.addWallBtn.Name = "addWallBtn";
            this.addWallBtn.Size = new System.Drawing.Size(100, 23);
            this.addWallBtn.TabIndex = 2;
            this.addWallBtn.Text = "Add Wall";
            this.addWallBtn.UseVisualStyleBackColor = true;
            this.addWallBtn.Click += new System.EventHandler(this.addWallBtn_Click);
            // 
            // widthLbl
            // 
            this.widthLbl.AutoSize = true;
            this.widthLbl.Location = new System.Drawing.Point(6, 23);
            this.widthLbl.Name = "widthLbl";
            this.widthLbl.Size = new System.Drawing.Size(35, 13);
            this.widthLbl.TabIndex = 6;
            this.widthLbl.Text = "Width";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.widthLbl);
            this.groupBox1.Controls.Add(this.addWallBtn);
            this.groupBox1.Controls.Add(this.widthBox);
            this.groupBox1.Controls.Add(this.heightBox);
            this.groupBox1.Controls.Add(this.heightLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 148);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Walls";
            // 
            // removeWallBtn
            // 
            this.removeWallBtn.Location = new System.Drawing.Point(8, 70);
            this.removeWallBtn.Name = "removeWallBtn";
            this.removeWallBtn.Size = new System.Drawing.Size(109, 23);
            this.removeWallBtn.TabIndex = 3;
            this.removeWallBtn.Text = "Remove Last Wall";
            this.removeWallBtn.UseVisualStyleBackColor = true;
            this.removeWallBtn.Click += new System.EventHandler(this.removeWallBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Paint Area:";
            // 
            // currentWallsLbl
            // 
            this.currentWallsLbl.AutoSize = true;
            this.currentWallsLbl.Location = new System.Drawing.Point(3, 23);
            this.currentWallsLbl.Name = "currentWallsLbl";
            this.currentWallsLbl.Size = new System.Drawing.Size(67, 13);
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
            this.groupBox2.Location = new System.Drawing.Point(148, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 101);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Data";
            // 
            // PaintAreaLbl
            // 
            this.PaintAreaLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PaintAreaLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PaintAreaLbl.Location = new System.Drawing.Point(77, 46);
            this.PaintAreaLbl.Name = "PaintAreaLbl";
            this.PaintAreaLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PaintAreaLbl.Size = new System.Drawing.Size(40, 13);
            this.PaintAreaLbl.TabIndex = 12;
            this.PaintAreaLbl.Text = "0";
            this.PaintAreaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WallsCountLbl
            // 
            this.WallsCountLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WallsCountLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WallsCountLbl.Location = new System.Drawing.Point(76, 23);
            this.WallsCountLbl.Name = "WallsCountLbl";
            this.WallsCountLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WallsCountLbl.Size = new System.Drawing.Size(41, 13);
            this.WallsCountLbl.TabIndex = 8;
            this.WallsCountLbl.Text = "0";
            this.WallsCountLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // Walls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.addWallsLbl);
            this.Controls.Add(this.addWallsLbl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button addWallBtn;
        private System.Windows.Forms.Label widthLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button removeWallBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentWallsLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label PaintAreaLbl;
        private System.Windows.Forms.Label WallsCountLbl;
        private System.Windows.Forms.Button backBtn;
    }
}