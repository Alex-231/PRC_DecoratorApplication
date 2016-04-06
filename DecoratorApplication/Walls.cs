using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DecoratorApplication
{
    public partial class Walls : Form
    {
        public Walls()
        {
            InitializeComponent();
        }

        private void addWallBtn_Click(object sender, EventArgs e)
        {
            try
            {
                float.Parse(widthBox.Text);
                float.Parse(heightBox.Text);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Please enter both the width and the height.", "Paint Calculator - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("The area entered is too large and has not been added", "Paint Calculator - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (FormatException)
            {
                MessageBox.Show("The area entered is not formatted correctly and has not been added", "Paint Calculator - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (float.Parse(widthBox.Text) <= 0 || float.Parse(heightBox.Text) <= 0)
            {
                MessageBox.Show("The area entered is too small and has not been added.", "Paint Calculator - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MainForm.Calculator.AddWall(float.Parse(widthBox.Text), float.Parse(heightBox.Text));
            UpdateLabels();
            //Empty the boxes to prevent the user from accidentally entering an area twice.
            this.widthBox.Text = null;
            this.heightBox.Text = null;
            //If the areas array has any contents the user can move on.
            if (MainForm.Calculator.WallAreas.Count() > 0)
            {
                this.nextBtn.Enabled = true;
            }
        }

        private void removeWallBtn_Click(object sender, EventArgs e)
        {
            MainForm.Calculator.RemoveWall();
            UpdateLabels();
            if (MainForm.Calculator.WallAreas.Count() < 1)
            {
                this.nextBtn.Enabled = false;
            }
        }

        private void UpdateLabels()
        {
            this.WallsCountLbl.Text = MainForm.Calculator.WallAreas.Count.ToString();
            this.PaintAreaLbl.Text = MainForm.Calculator.GetTotalArea().ToString();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            Form Openings = new Openings();
            this.Hide();
            Openings.ShowDialog();
            this.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
